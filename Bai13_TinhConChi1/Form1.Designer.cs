namespace Bai13_TinhConChi1
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
            this.CanChi = new System.Windows.Forms.TextBox();
            this.chiArr = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.Label();
            this.lstNam = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CanChi
            // 
            this.CanChi.Location = new System.Drawing.Point(187, 36);
            this.CanChi.Name = "CanChi";
            this.CanChi.Size = new System.Drawing.Size(171, 20);
            this.CanChi.TabIndex = 0;
            // 
            // chiArr
            // 
            this.chiArr.Location = new System.Drawing.Point(187, 90);
            this.chiArr.Name = "chiArr";
            this.chiArr.Size = new System.Drawing.Size(171, 20);
            this.chiArr.TabIndex = 0;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(395, 34);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(74, 23);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(395, 88);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtNam
            // 
            this.txtNam.AutoSize = true;
            this.txtNam.Location = new System.Drawing.Point(116, 39);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(34, 13);
            this.txtNam.TabIndex = 2;
            this.txtNam.Text = "NĂM:";
            // 
            // txtKQ
            // 
            this.txtKQ.AutoSize = true;
            this.txtKQ.Location = new System.Drawing.Point(116, 93);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(54, 13);
            this.txtKQ.TabIndex = 2;
            this.txtKQ.Text = "KẾT QUẢ";
            // 
            // lstNam
            // 
            this.lstNam.FormattingEnabled = true;
            this.lstNam.Location = new System.Drawing.Point(545, 56);
            this.lstNam.Name = "lstNam";
            this.lstNam.Size = new System.Drawing.Size(224, 277);
            this.lstNam.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNam);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.chiArr);
            this.Controls.Add(this.CanChi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CanChi;
        private System.Windows.Forms.TextBox chiArr;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label txtNam;
        private System.Windows.Forms.Label txtKQ;
        private System.Windows.Forms.ListBox lstNam;
    }
}

