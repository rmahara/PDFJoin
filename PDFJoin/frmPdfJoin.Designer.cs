
namespace PDFJoin
{
    partial class frmPdfJoin
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
            this.txtPdf1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPdf2 = new System.Windows.Forms.TextBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPdf1
            // 
            this.txtPdf1.Location = new System.Drawing.Point(56, 21);
            this.txtPdf1.Name = "txtPdf1";
            this.txtPdf1.Size = new System.Drawing.Size(712, 23);
            this.txtPdf1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "PDF1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PDF2";
            // 
            // txtPdf2
            // 
            this.txtPdf2.Location = new System.Drawing.Point(56, 50);
            this.txtPdf2.Name = "txtPdf2";
            this.txtPdf2.Size = new System.Drawing.Size(712, 23);
            this.txtPdf2.TabIndex = 2;
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(783, 21);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(88, 81);
            this.btnJoin.TabIndex = 4;
            this.btnJoin.Text = "Join\r\nOutput";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "output";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(56, 79);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(712, 23);
            this.txtOutput.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(16, 118);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(51, 15);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "メッセージ";
            // 
            // frmPdfJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 135);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPdf2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPdf1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPdfJoin";
            this.Text = "PDFJoin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPdf1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPdf2;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblMessage;
    }
}

