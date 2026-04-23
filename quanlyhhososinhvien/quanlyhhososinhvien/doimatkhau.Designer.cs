namespace quanlyhhososinhvien
{
    partial class doimatkhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatkhaucu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtxacnhan = new System.Windows.Forms.TextBox();
            this.checkpass = new System.Windows.Forms.CheckBox();
            this.btndoimatkhau = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtrandom = new System.Windows.Forms.TextBox();
            this.txtxacthuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // txtmatkhaucu
            // 
            this.txtmatkhaucu.Location = new System.Drawing.Point(166, 89);
            this.txtmatkhaucu.Name = "txtmatkhaucu";
            this.txtmatkhaucu.PasswordChar = '*';
            this.txtmatkhaucu.Size = new System.Drawing.Size(147, 20);
            this.txtmatkhaucu.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu mới";
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.Location = new System.Drawing.Point(166, 129);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.PasswordChar = '*';
            this.txtmatkhaumoi.Size = new System.Drawing.Size(147, 20);
            this.txtmatkhaumoi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // txtxacnhan
            // 
            this.txtxacnhan.Location = new System.Drawing.Point(166, 170);
            this.txtxacnhan.Name = "txtxacnhan";
            this.txtxacnhan.PasswordChar = '*';
            this.txtxacnhan.Size = new System.Drawing.Size(147, 20);
            this.txtxacnhan.TabIndex = 3;
            // 
            // checkpass
            // 
            this.checkpass.AutoSize = true;
            this.checkpass.Location = new System.Drawing.Point(66, 247);
            this.checkpass.Name = "checkpass";
            this.checkpass.Size = new System.Drawing.Size(109, 17);
            this.checkpass.TabIndex = 5;
            this.checkpass.Text = "Hiển thị mật khẩu";
            this.checkpass.UseVisualStyleBackColor = true;
            this.checkpass.CheckedChanged += new System.EventHandler(this.checkpass_CheckedChanged);
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.Location = new System.Drawing.Point(217, 289);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(96, 23);
            this.btndoimatkhau.TabIndex = 6;
            this.btndoimatkhau.Text = "Đổi mật khẩu";
            this.btndoimatkhau.UseVisualStyleBackColor = true;
            this.btndoimatkhau.Click += new System.EventHandler(this.btndoimatkhau_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(79, 289);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(96, 23);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtrandom
            // 
            this.txtrandom.Enabled = false;
            this.txtrandom.Location = new System.Drawing.Point(249, 212);
            this.txtrandom.Name = "txtrandom";
            this.txtrandom.Size = new System.Drawing.Size(79, 20);
            this.txtrandom.TabIndex = 14;
            // 
            // txtxacthuc
            // 
            this.txtxacthuc.Location = new System.Drawing.Point(143, 212);
            this.txtxacthuc.Name = "txtxacthuc";
            this.txtxacthuc.Size = new System.Drawing.Size(79, 20);
            this.txtxacthuc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(61, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã xác thực";
            // 
            // doimatkhau
            // 
            this.AcceptButton = this.btndoimatkhau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlyhhososinhvien.Properties.Resources.R;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(395, 372);
            this.Controls.Add(this.txtrandom);
            this.Controls.Add(this.txtxacthuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndoimatkhau);
            this.Controls.Add(this.checkpass);
            this.Controls.Add(this.txtxacnhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmatkhaumoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmatkhaucu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "doimatkhau";
            this.Text = "doimatkhau";
            this.Load += new System.EventHandler(this.doimatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmatkhaucu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtxacnhan;
        private System.Windows.Forms.CheckBox checkpass;
        private System.Windows.Forms.Button btndoimatkhau;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtrandom;
        private System.Windows.Forms.TextBox txtxacthuc;
        private System.Windows.Forms.Label label2;
    }
}