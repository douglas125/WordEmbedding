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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtWordSearch = new System.Windows.Forms.TextBox();
            this.btnSearchWord = new System.Windows.Forms.Button();
            this.txtAnalogies = new System.Windows.Forms.TextBox();
            this.btnAnalogySearch = new System.Windows.Forms.Button();
            this.cmbAnalogy = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchWord);
            this.groupBox1.Controls.Add(this.txtWordSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Words";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbAnalogy);
            this.groupBox2.Controls.Add(this.btnAnalogySearch);
            this.groupBox2.Controls.Add(this.txtAnalogies);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analogies";
            // 
            // txtWordSearch
            // 
            this.txtWordSearch.Location = new System.Drawing.Point(6, 19);
            this.txtWordSearch.Name = "txtWordSearch";
            this.txtWordSearch.Size = new System.Drawing.Size(136, 20);
            this.txtWordSearch.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Word embedding viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchWord;
        private System.Windows.Forms.TextBox txtWordSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAnalogy;
        private System.Windows.Forms.Button btnAnalogySearch;
        private System.Windows.Forms.TextBox txtAnalogies;
    }
}

