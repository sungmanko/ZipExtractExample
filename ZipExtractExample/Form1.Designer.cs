namespace ZipExtractExample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTarget1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTarget2 = new System.Windows.Forms.Button();
            this.txtTarget2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTarget1
            // 
            this.txtTarget1.Location = new System.Drawing.Point(26, 34);
            this.txtTarget1.Name = "txtTarget1";
            this.txtTarget1.Size = new System.Drawing.Size(295, 22);
            this.txtTarget1.TabIndex = 0;
            this.txtTarget1.Text = "C:\\Users\\kangf\\Desktop\\aaaaaaa\\ClientCustomer.zip";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTarget1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "圧縮ファイルパス";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTarget2);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "解凍フォルダ";
            // 
            // btnTarget2
            // 
            this.btnTarget2.Location = new System.Drawing.Point(296, 226);
            this.btnTarget2.Name = "btnTarget2";
            this.btnTarget2.Size = new System.Drawing.Size(75, 23);
            this.btnTarget2.TabIndex = 1;
            this.btnTarget2.Text = "button1";
            this.btnTarget2.UseVisualStyleBackColor = true;
            this.btnTarget2.Click += new System.EventHandler(this.btnTarget2_Click);
            // 
            // txtTarget2
            // 
            this.txtTarget2.Location = new System.Drawing.Point(26, 34);
            this.txtTarget2.Name = "txtTarget2";
            this.txtTarget2.Size = new System.Drawing.Size(295, 22);
            this.txtTarget2.TabIndex = 0;
            this.txtTarget2.Text = "C:\\Users\\kangf\\Desktop\\aaaaaaa\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 277);
            this.Controls.Add(this.btnTarget2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarget1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTarget2;
        private System.Windows.Forms.Button btnTarget2;
    }
}

