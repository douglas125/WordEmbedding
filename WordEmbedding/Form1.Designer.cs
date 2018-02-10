namespace WordEmbedding
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbWords = new System.Windows.Forms.GroupBox();
            this.gbAnalogies = new System.Windows.Forms.GroupBox();
            this.txtWordSearch = new System.Windows.Forms.TextBox();
            this.btnSearchWord = new System.Windows.Forms.Button();
            this.txtAnalogies = new System.Windows.Forms.TextBox();
            this.btnAnalogySearch = new System.Windows.Forms.Button();
            this.cmbAnalogy = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picViewtSNE = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numCloseW = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.gbWords.SuspendLayout();
            this.gbAnalogies.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewtSNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCloseW)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // gbWords
            // 
            this.gbWords.Controls.Add(this.numCloseW);
            this.gbWords.Controls.Add(this.label1);
            this.gbWords.Controls.Add(this.btnSearchWord);
            this.gbWords.Controls.Add(this.txtWordSearch);
            this.gbWords.Enabled = false;
            this.gbWords.Location = new System.Drawing.Point(12, 27);
            this.gbWords.Name = "gbWords";
            this.gbWords.Size = new System.Drawing.Size(229, 83);
            this.gbWords.TabIndex = 1;
            this.gbWords.TabStop = false;
            this.gbWords.Text = "Words";
            // 
            // gbAnalogies
            // 
            this.gbAnalogies.Controls.Add(this.cmbAnalogy);
            this.gbAnalogies.Controls.Add(this.btnAnalogySearch);
            this.gbAnalogies.Controls.Add(this.txtAnalogies);
            this.gbAnalogies.Enabled = false;
            this.gbAnalogies.Location = new System.Drawing.Point(12, 129);
            this.gbAnalogies.Name = "gbAnalogies";
            this.gbAnalogies.Size = new System.Drawing.Size(229, 168);
            this.gbAnalogies.TabIndex = 1;
            this.gbAnalogies.TabStop = false;
            this.gbAnalogies.Text = "Analogies";
            // 
            // txtWordSearch
            // 
            this.txtWordSearch.Location = new System.Drawing.Point(6, 19);
            this.txtWordSearch.Name = "txtWordSearch";
            this.txtWordSearch.Size = new System.Drawing.Size(136, 20);
            this.txtWordSearch.TabIndex = 0;
            this.txtWordSearch.Text = "petróleo carro medicina";
            // 
            // btnSearchWord
            // 
            this.btnSearchWord.Location = new System.Drawing.Point(148, 19);
            this.btnSearchWord.Name = "btnSearchWord";
            this.btnSearchWord.Size = new System.Drawing.Size(75, 23);
            this.btnSearchWord.TabIndex = 1;
            this.btnSearchWord.Text = "Search";
            this.btnSearchWord.UseVisualStyleBackColor = true;
            this.btnSearchWord.Click += new System.EventHandler(this.btnSearchWord_Click);
            // 
            // txtAnalogies
            // 
            this.txtAnalogies.Location = new System.Drawing.Point(6, 19);
            this.txtAnalogies.Multiline = true;
            this.txtAnalogies.Name = "txtAnalogies";
            this.txtAnalogies.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnalogies.Size = new System.Drawing.Size(217, 103);
            this.txtAnalogies.TabIndex = 1;
            this.txtAnalogies.Text = "frança paris\r\nalemanha berlim\r\nsuécia ?";
            // 
            // btnAnalogySearch
            // 
            this.btnAnalogySearch.Location = new System.Drawing.Point(6, 128);
            this.btnAnalogySearch.Name = "btnAnalogySearch";
            this.btnAnalogySearch.Size = new System.Drawing.Size(75, 31);
            this.btnAnalogySearch.TabIndex = 2;
            this.btnAnalogySearch.Text = "Search";
            this.btnAnalogySearch.UseVisualStyleBackColor = true;
            this.btnAnalogySearch.Click += new System.EventHandler(this.btnAnalogySearch_Click);
            // 
            // cmbAnalogy
            // 
            this.cmbAnalogy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnalogy.FormattingEnabled = true;
            this.cmbAnalogy.Location = new System.Drawing.Point(87, 134);
            this.cmbAnalogy.Name = "cmbAnalogy";
            this.cmbAnalogy.Size = new System.Drawing.Size(136, 21);
            this.cmbAnalogy.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.picViewtSNE);
            this.groupBox3.Location = new System.Drawing.Point(247, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(720, 357);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visualization - t-Distributed Stochastic Neighbor Embedding (t-SNE)";
            // 
            // picViewtSNE
            // 
            this.picViewtSNE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picViewtSNE.Location = new System.Drawing.Point(6, 19);
            this.picViewtSNE.Name = "picViewtSNE";
            this.picViewtSNE.Size = new System.Drawing.Size(708, 332);
            this.picViewtSNE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picViewtSNE.TabIndex = 0;
            this.picViewtSNE.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of close words:";
            // 
            // numCloseW
            // 
            this.numCloseW.Location = new System.Drawing.Point(148, 52);
            this.numCloseW.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCloseW.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numCloseW.Name = "numCloseW";
            this.numCloseW.Size = new System.Drawing.Size(75, 20);
            this.numCloseW.TabIndex = 3;
            this.numCloseW.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 396);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbAnalogies);
            this.Controls.Add(this.gbWords);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Word embedding viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbWords.ResumeLayout(false);
            this.gbWords.PerformLayout();
            this.gbAnalogies.ResumeLayout(false);
            this.gbAnalogies.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picViewtSNE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCloseW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbWords;
        private System.Windows.Forms.Button btnSearchWord;
        private System.Windows.Forms.TextBox txtWordSearch;
        private System.Windows.Forms.GroupBox gbAnalogies;
        private System.Windows.Forms.ComboBox cmbAnalogy;
        private System.Windows.Forms.Button btnAnalogySearch;
        private System.Windows.Forms.TextBox txtAnalogies;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picViewtSNE;
        private System.Windows.Forms.NumericUpDown numCloseW;
        private System.Windows.Forms.Label label1;
    }
}

