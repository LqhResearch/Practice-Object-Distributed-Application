
namespace WinForm
{
    partial class De_2
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
            this.rtxtAns = new System.Windows.Forms.RichTextBox();
            this.btnAns = new System.Windows.Forms.Button();
            this.txtNum7 = new System.Windows.Forms.TextBox();
            this.txtNum6 = new System.Windows.Forms.TextBox();
            this.txtNum5 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtAns
            // 
            this.rtxtAns.BackColor = System.Drawing.Color.White;
            this.rtxtAns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtAns.Location = new System.Drawing.Point(16, 100);
            this.rtxtAns.Name = "rtxtAns";
            this.rtxtAns.ReadOnly = true;
            this.rtxtAns.Size = new System.Drawing.Size(368, 60);
            this.rtxtAns.TabIndex = 19;
            this.rtxtAns.Text = "";
            // 
            // btnAns
            // 
            this.btnAns.Location = new System.Drawing.Point(163, 63);
            this.btnAns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(73, 30);
            this.btnAns.TabIndex = 18;
            this.btnAns.Text = "Kết quả";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // txtNum7
            // 
            this.txtNum7.Location = new System.Drawing.Point(338, 30);
            this.txtNum7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum7.Name = "txtNum7";
            this.txtNum7.Size = new System.Drawing.Size(46, 25);
            this.txtNum7.TabIndex = 17;
            this.txtNum7.Text = "0";
            this.txtNum7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum6
            // 
            this.txtNum6.Location = new System.Drawing.Point(284, 30);
            this.txtNum6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum6.Name = "txtNum6";
            this.txtNum6.Size = new System.Drawing.Size(46, 25);
            this.txtNum6.TabIndex = 16;
            this.txtNum6.Text = "0";
            this.txtNum6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum5
            // 
            this.txtNum5.Location = new System.Drawing.Point(230, 30);
            this.txtNum5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum5.Name = "txtNum5";
            this.txtNum5.Size = new System.Drawing.Size(46, 25);
            this.txtNum5.TabIndex = 15;
            this.txtNum5.Text = "0";
            this.txtNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum4
            // 
            this.txtNum4.Location = new System.Drawing.Point(177, 30);
            this.txtNum4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(46, 25);
            this.txtNum4.TabIndex = 14;
            this.txtNum4.Text = "0";
            this.txtNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(123, 30);
            this.txtNum3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(46, 25);
            this.txtNum3.TabIndex = 13;
            this.txtNum3.Text = "0";
            this.txtNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(69, 30);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(46, 25);
            this.txtNum2.TabIndex = 12;
            this.txtNum2.Text = "0";
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(16, 30);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(46, 25);
            this.txtNum1.TabIndex = 11;
            this.txtNum1.Text = "0";
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhập 7 số nguyên dương: ";
            // 
            // De_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(407, 181);
            this.Controls.Add(this.rtxtAns);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.txtNum7);
            this.Controls.Add(this.txtNum6);
            this.Controls.Add(this.txtNum5);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "De_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "De_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtAns;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.TextBox txtNum7;
        private System.Windows.Forms.TextBox txtNum6;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label1;
    }
}