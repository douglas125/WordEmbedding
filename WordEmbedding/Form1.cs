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

        WordEmbedding we;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Embedding|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                we = new WordEmbedding(ofd.FileName);
            }
        }

        #region Word
        private void btnSearchWord_Click(object sender, EventArgs e)
        {
            List<WordEmbedding.WordDistance> wd = we.CosineDistances(txtWordSearch.Text);
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
        }
        #endregion
    }
}
