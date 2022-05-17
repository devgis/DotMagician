namespace TestDrawApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutPut = new System.Windows.Forms.TextBox();
            this.btGenerat = new System.Windows.Forms.Button();
            this.nudRowCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btFont = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(298, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(21, 12);
            this.tbInput.MaxLength = 200;
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(234, 112);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "青海长云暗雪山\r\n孤城遥望玉门关\r\n黄沙百战穿金甲\r\n不破楼兰终不还";
            // 
            // tbOutPut
            // 
            this.tbOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbOutPut.Location = new System.Drawing.Point(21, 144);
            this.tbOutPut.Multiline = true;
            this.tbOutPut.Name = "tbOutPut";
            this.tbOutPut.ReadOnly = true;
            this.tbOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutPut.Size = new System.Drawing.Size(1197, 608);
            this.tbOutPut.TabIndex = 2;
            // 
            // btGenerat
            // 
            this.btGenerat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGenerat.Location = new System.Drawing.Point(674, 83);
            this.btGenerat.Name = "btGenerat";
            this.btGenerat.Size = new System.Drawing.Size(75, 23);
            this.btGenerat.TabIndex = 3;
            this.btGenerat.Text = "生成点阵";
            this.btGenerat.UseVisualStyleBackColor = true;
            this.btGenerat.Click += new System.EventHandler(this.btGenerat_Click);
            // 
            // nudRowCount
            // 
            this.nudRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRowCount.Location = new System.Drawing.Point(629, 13);
            this.nudRowCount.Name = "nudRowCount";
            this.nudRowCount.Size = new System.Drawing.Size(120, 21);
            this.nudRowCount.TabIndex = 4;
            this.nudRowCount.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "每行字符：";
            // 
            // btFont
            // 
            this.btFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFont.Location = new System.Drawing.Point(575, 83);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(75, 23);
            this.btFont.TabIndex = 8;
            this.btFont.Text = "设置字体";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 787);
            this.Controls.Add(this.btFont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudRowCount);
            this.Controls.Add(this.btGenerat);
            this.Controls.Add(this.tbOutPut);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "汉字生成点阵";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutPut;
        private System.Windows.Forms.Button btGenerat;
        private System.Windows.Forms.NumericUpDown nudRowCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFont;
    }
}

