using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordEmbedding
{
    public class WordEmbedding
    {
        /// <summary>Create new word embedding class from file</summary>
        /// <param name="filename">Word embedding file</param>
        public WordEmbedding(string filename)
        {
            string sepdec = (1.1).ToString().Substring(1, 1);
            using (StreamReader sr = new StreamReader(filename))
            {
                //header
                string line = sr.ReadLine();
                int dim = int.Parse(line.Split()[1]);
                int n = 0;
                _wordVecLen = dim;
                while (!sr.EndOfStream)
                {
                    n++;
                    string[] s = sr.ReadLine().Replace(".", sepdec).Split();
                    int dif = s.Length - dim;

                    if (dif == 1)
                    {
                        string token = s[0];
                        for (int k = 1; k < dif; k++)
                            token += " " + s[k];

                        float[] embedding = new float[dim];
                        for (int k = 0; k < dim; k++) embedding[k] = float.Parse(s[k + dif].Replace(".", sepdec));
                        if (!dicWords.ContainsKey(token.Trim())) dicWords.Add(token.Trim(), embedding);
                        else
                        {
                            //?
                        }
                    }
                }
            }
        }
        /// <summary>Word dictionary</summary>
        public SortedDictionary<string, float[]> dicWords = new SortedDictionary<string, float[]>();

        /// <summary>Word vector length</summary>
        int _wordVecLen;

        /// <summary>Retrieves word vector or zeroes if it does not exist</summary>
        /// <param name="word">Word to get vector</param>
        /// <returns></returns>
        public float[] GetWordVec(string word)
        {
            float[] v;
            if (dicWords.TryGetValue(word, out v)) return v;
            else return new float[_wordVecLen];
        }

        /// <summary>Computes word analogy: leftside is to rightside as queryTerm is to what</summary>
        /// <param name="leftSide">Left side of analogy</param>
        /// <param name="rightSide">Right side of analogy</param>
        /// <param name="queryTerm">Query term</param>
        /// <returns></returns>
        public List<WordDistance> ComputeAnalogy(List<string> leftSide, List<string> rightSide, string queryTerm)
        {
            if (leftSide.Count != rightSide.Count) throw new Exception("Right side must have the same number of elements as left side");
            float[] queryVec = dicWords[queryTerm];

            //leftSide - rightSide = queryTerm - ans
            float[] searchVec = new float[_wordVecLen];
            float nSums = 0;
            for (int k = 0; k < leftSide.Count; k++)
            {
                float[] v1, v2;
                if (dicWords.TryGetValue(leftSide[k], out v1) && dicWords.TryGetValue(rightSide[k], out v2))
                {
                    nSums+=1;
                    for (int p = 0; p < _wordVecLen; p++) searchVec[p] += v2[p] - v1[p];
                }
            }

            nSums = 1.0f / nSums;

            for (int p = 0; p < _wordVecLen; p++) searchVec[p] = queryVec[p] + searchVec[p] * nSums;

            return CosineDistances(searchVec, "analog:"+queryTerm);
        }

        #region Cosine distances
        public class WordDistance : IComparable<WordDistance>
        {
            public string w1;
            public string w2;
            public float distance;
            public int CompareTo(WordDistance other)
            {
                return distance.CompareTo(other.distance);
            }
            public override string ToString()
            {
                return w1 + " : " + w2 + " " + distance.ToString();
            }
        }

        /// <summary>Compute cosine distances of a given word to all other words.</summary>
        /// <param name="w1">Word</param>
        /// <returns></returns>
        public List<WordDistance> CosineDistances(string w1)
        {
            if (!dicWords.ContainsKey(w1)) return null;
            float[] v1 = dicWords[w1];
            return CosineDistances(v1, w1);
        }
        public List<WordDistance> CosineDistances(float[] v1, string label)
        {
            List<float[]> wordvecs = dicWords.Values.ToList();
            List<string> words = dicWords.Keys.ToList();
            List<WordDistance> lstWd = new List<WordDistance>();
            for (int k = 0; k < words.Count; k++) lstWd.Add(new WordDistance());
            double w1Abs = 0;
            for (int q = 0; q < v1.Length; q++) w1Abs += v1[q] * v1[q];
            w1Abs = Math.Sqrt(w1Abs);
            //for (int k = 0; k < words.Count; k++)
            Parallel.For(0, words.Count, k =>
            {
                lstWd[k].w1 = label;
                lstWd[k].w2 = words[k];
                float[] v2 = wordvecs[k];
                double w2Abs = 0;
                for (int q = 0; q < v1.Length; q++) w2Abs += v2[q] * v2[q];
                w2Abs = Math.Sqrt(w2Abs);
                double v1v2 = 0;
                for (int q = 0; q < v1.Length; q++) v1v2 += v1[q] * v2[q];
                lstWd[k].distance = 1.0f - (float)(v1v2 / (w1Abs * w2Abs));
                //double l2dist = 0;
                //for (int q = 0; q < v1.Length; q++) l2dist += (v1[q] - v2[q])* (v1[q] - v2[q]);
                //lstWd[k].distance = (float)Math.Sqrt(l2dist);
            });
            lstWd = lstWd.OrderBy(v => v.distance).ToList<WordDistance>();
            return lstWd;
        }
        #endregion
    }
}