using Accord.MachineLearning.Clustering;
using Accord.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordEmbedding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region t-SNE
        void tsnetest()
        { 
            Accord.Math.Random.Generator.Seed = 0;

            // Declare some observations
            double[][] observations =
            {
    new double[] { -5, -2, -1 },
    new double[] { -5, -5, -6 },
    new double[] {  2,  1,  1 },
    new double[] {  1,  1,  2 },
    new double[] {  1,  2,  2 },
    new double[] {  3,  1,  2 },
    new double[] { 11,  5,  4 },
    new double[] { 15,  5,  6 },
    new double[] { 10,  5,  6 },
};

            // Create a new t-SNE algorithm 
            TSNE tSNE = new TSNE()
            {
                NumberOfOutputs = 2,
                Perplexity = 1.5
            };

            // Transform to a reduced dimensionality space
            double[][] output = tSNE.Transform(observations);

            // Make it 1-dimensional
            double[] y = output.Reshape();
        }

        /// <summary>Accord t-SNE</summary>
        TSNE tSNE = new TSNE() { Perplexity = 18 } ;

        /// <summary>Build t-SNE. Use 100+ vectors</summary>
        /// <param name="wd">Word distances</param>
        /// <param name="nVecs">Number of vectors</param>
        /// <returns></returns>
        double[][] buildtSNE(List<WordEmbedding.WordDistance> wd, int nVecs)
        {
            List<float[]> ans = new List<float[]>();

            double[][] observ = new double[nVecs][];
            for (int k = 0; k < nVecs; k++)
            {
                float[] v = we.GetWordVec(wd[k].w2);
                observ[k] = new double[v.Length];
                for (int p = 0; p < v.Length; p++) observ[k][p] = v[p];
            }
            double[][] compressed = tSNE.Transform(observ);

            return compressed;
        }

        #endregion

        WordEmbedding we;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Embedding|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                we = new WordEmbedding(ofd.FileName);
                gbWords.Enabled = true;
                gbAnalogies.Enabled = true;
            }
        }

        #region Word
        private void btnSearchWord_Click(object sender, EventArgs e)
        {
            List<WordEmbedding.WordDistance> allWds = new List<WordEmbedding.WordDistance>();

            string[] s = txtWordSearch.Text.Split(new string[] { "\r\n", " " }, StringSplitOptions.RemoveEmptyEntries);
            int nWords = (int)numCloseW.Value;

            foreach (string ss in s)
            {
                List<WordEmbedding.WordDistance> wd = we.CosineDistances(ss);
                for (int k = 0; k < nWords; k++)
                {
                    if (k==0 || allWds.Where(word => word.w2 == wd[k].w2).Count() == 0)
                        allWds.Add(wd[k]);
                }
            }


            allWds = allWds.OrderBy(v => v.distance).ToList<WordEmbedding.WordDistance>();

        


            double[][] wordtSNE = buildtSNE(allWds, nWords);

            int w = picViewtSNE.Width, h = picViewtSNE.Height;
            Bitmap bmp = new Bitmap(w, h);

            float[] max = new float[2] { float.MinValue, float.MinValue };
            float[] min = new float[2] { float.MaxValue, float.MaxValue };

            for (int k = 0; k < wordtSNE.Length; k++)
            {
                for (int p = 0; p < wordtSNE[k].Length; p++)
                {
                    if (max[p] < wordtSNE[k][p]) max[p] = (float)wordtSNE[k][p];
                    if (min[p] > wordtSNE[k][p]) min[p] = (float)wordtSNE[k][p];
                }
            }
            Font f = new Font("Arial", 9);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, w, h);
            g.FillRectangle(Brushes.LightYellow, w/4, h/4, w/2, h/2);

            for (int k = 0; k < nWords; k++)
            {
                float x = (float)((wordtSNE[k][0] - min[0]) / (max[0] - min[0]));
                float y = (float)((wordtSNE[k][1] - min[1]) / (max[1] - min[1]));

                Brush b = k < s.Length ? Brushes.Red : Brushes.Black;

                g.FillEllipse(b, x * w, y * h, 5, 5);
                g.DrawString(allWds[k].w2, f, b, x * w + 3, y * h + 3);
            }


            picViewtSNE.Image = bmp;
        }
        #endregion


        #region Analogy
        private void btnAnalogySearch_Click(object sender, EventArgs e)
        {
            string[] lines = txtAnalogies.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            string queryTerm = "";
            List<string> leftSide = new List<string>(), rightSide = new List<string>();
            foreach (string s in lines)
            {
                string[] ss = s.Split();

                if (s.EndsWith("?")) queryTerm = ss[0];
                else
                {
                    leftSide.Add(ss[0]);
                    rightSide.Add(ss[1]);
                }
            }

            List<WordEmbedding.WordDistance> wd = we.ComputeAnalogy(leftSide, rightSide, queryTerm);

            cmbAnalogy.Items.Clear();
            for (int k = 0; k < 25; k++)
            {
                if (wd[k].w2 != queryTerm && !leftSide.Contains(wd[k].w2) && !rightSide.Contains(wd[k].w2))
                    cmbAnalogy.Items.Add(wd[k].w2 + " " + wd[k].distance);
            }
            cmbAnalogy.SelectedIndex = 0;

            string viewString = queryTerm;
            foreach (string ww in leftSide) viewString += " " + ww;
            foreach (string ww in rightSide) viewString += " " + ww;
            txtWordSearch.Text = viewString;
            btnSearchWord_Click(sender, e);
        }
        #endregion
    }
}
