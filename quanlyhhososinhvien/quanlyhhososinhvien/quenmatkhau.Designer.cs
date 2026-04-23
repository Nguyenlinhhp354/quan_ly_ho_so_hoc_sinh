namespace quanlyhhososinhvien
{
    partial class quenmatkhau
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtxacthuc = new System.Windows.Forms.TextBox();
            this.txtrandom = new System.Windows.Forms.TextBox();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhaubimat = new System.Windows.Forms.TextBox();
            this.btnkhoiphuc = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.checkpass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(81, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(81, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu bí mật";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(81, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã xác thực";
            // 
            // txtxacthuc
            // 
            this.txtxacthuc.Location = new System.Drawing.Point(163, 180);
            this.txtxacthuc.Name = "txtxacthuc";
            this.txtxacthuc.Size = new System.Drawing.Size(79, 20);
            this.txtxacthuc.TabIndex = 5;
            // 
            // txtrandom
            // 
            this.txtrandom.Enabled = false;
            this.txtrandom.Location = new System.Drawing.Point(269, 180);
            this.txtrandom.Name = "txtrandom";
            this.txtrandom.Size = new System.Drawing.Size(79, 20);
            this.txtrandom.TabIndex = 6;
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(189, 92);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(159, 20);
            this.txttaikhoan.TabIndex = 7;
            // 
            // txtmatkhaubimat
            // 
            this.txtmatkhaubimat.Location = new System.Drawing.Point(189, 135);
            this.txtmatkhaubimat.Name = "txtmatkhaubimat";
            this.txtmatkhaubimat.PasswordChar = '*';
            this.txtmatkhaubimat.Size = new System.Drawing.Size(159, 20);
            this.txtmatkhaubimat.TabIndex = 8;
            // 
            // btnkhoiphuc
            // 
            this.btnkhoiphuc.Location = new System.Drawing.Point(245, 258);
            this.btnkhoiphuc.Name = "btnkhoiphuc";
            this.btnkhoiphuc.Size = new System.Drawing.Size(75, 23);
            this.btnkhoiphuc.TabIndex = 9;
            this.btnkhoiphuc.Text = "Khôi phục";
            this.btnkhoiphuc.UseVisualStyleBackColor = true;
            this.btnkhoiphuc.Click += new System.EventHandler(this.btnkhoiphuc_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(112, 258);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // checkpass
            // 
            this.checkpass.AutoSize = true;
            this.checkpass.Location = new System.Drawing.Point(84, 225);
            this.checkpass.Name = "checkpass";
            this.checkpass.Size = new System.Drawing.Size(109, 17);
            this.checkpass.TabIndex = 11;
            this.checkpass.Text = "Hiển thị mật khẩu";
            this.checkpass.UseVisualStyleBackColor = true;
            this.checkpass.CheckedChanged += new System.EventHandler(this.checkpass_CheckedChanged);
            // 
            // quenmatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlyhhososinhvien.Properties.Resources.R;
            this.ClientSize = new System.Drawing.Size(453, 330);
            this.Controls.Add(this.checkpass);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnkhoiphuc);
            this.Controls.Add(this.txtmatkhaubimat);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.txtrandom);
            this.Controls.Add(this.txtxacthuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "quenmatkhau";
            this.Text = "quenmatkhau";
            this.Load += new System.EventHandler(this.quenmatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtxacthuc;
        private System.Windows.Forms.TextBox txtrandom;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.TextBox txtmatkhaubimat;
        private System.Windows.Forms.Button btnkhoiphuc;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.CheckBox checkpass;
    }
}