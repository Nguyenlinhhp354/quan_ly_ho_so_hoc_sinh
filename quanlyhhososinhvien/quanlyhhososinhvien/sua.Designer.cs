namespace quanlyhhososinhvien
{
    partial class sua
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmasinhvien = new System.Windows.Forms.TextBox();
            this.txttensinhvien = new System.Windows.Forms.TextBox();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.txtcccd = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.datengaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combohedaotao = new System.Windows.Forms.ComboBox();
            this.hedaotaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlyhososinhvienDataSet2 = new quanlyhhososinhvien.quanlyhososinhvienDataSet2();
            this.combolop = new System.Windows.Forms.ComboBox();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlyhososinhvienDataSet15 = new quanlyhhososinhvien.quanlyhososinhvienDataSet15();
            this.lopTableAdapter = new quanlyhhososinhvien.quanlyhososinhvienDataSet15TableAdapters.lopTableAdapter();
            this.hedaotaoTableAdapter = new quanlyhhososinhvien.quanlyhososinhvienDataSet2TableAdapters.hedaotaoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hedaotaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CCCD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lớp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hệ đào tạo";
            // 
            // txtmasinhvien
            // 
            this.txtmasinhvien.Location = new System.Drawing.Point(123, 28);
            this.txtmasinhvien.Name = "txtmasinhvien";
            this.txtmasinhvien.Size = new System.Drawing.Size(179, 20);
            this.txtmasinhvien.TabIndex = 1;
            // 
            // txttensinhvien
            // 
            this.txttensinhvien.Location = new System.Drawing.Point(123, 68);
            this.txttensinhvien.Name = "txttensinhvien";
            this.txttensinhvien.Size = new System.Drawing.Size(179, 20);
            this.txttensinhvien.TabIndex = 2;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(123, 141);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(179, 20);
            this.txtgioitinh.TabIndex = 4;
            // 
            // txtcccd
            // 
            this.txtcccd.Location = new System.Drawing.Point(123, 183);
            this.txtcccd.Name = "txtcccd";
            this.txtcccd.Size = new System.Drawing.Size(179, 20);
            this.txtcccd.TabIndex = 5;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(123, 219);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(179, 20);
            this.txtsdt.TabIndex = 6;
            // 
            // datengaysinh
            // 
            this.datengaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh.Location = new System.Drawing.Point(123, 102);
            this.datengaysinh.Name = "datengaysinh";
            this.datengaysinh.Size = new System.Drawing.Size(179, 20);
            this.datengaysinh.TabIndex = 3;
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.Location = new System.Drawing.Point(221, 393);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 9;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(91, 393);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(122, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Thông tin học sinh";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.combohedaotao);
            this.groupBox1.Controls.Add(this.combolop);
            this.groupBox1.Controls.Add(this.txtmasinhvien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datengaysinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtcccd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtgioitinh);
            this.groupBox1.Controls.Add(this.txttensinhvien);
            this.groupBox1.Location = new System.Drawing.Point(42, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 331);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh";
            // 
            // combohedaotao
            // 
            this.combohedaotao.FormattingEnabled = true;
            this.combohedaotao.Location = new System.Drawing.Point(123, 299);
            this.combohedaotao.Name = "combohedaotao";
            this.combohedaotao.Size = new System.Drawing.Size(179, 21);
            this.combohedaotao.TabIndex = 8;
            // 
            // hedaotaoBindingSource
            // 
            this.hedaotaoBindingSource.DataMember = "hedaotao";
            this.hedaotaoBindingSource.DataSource = this.quanlyhososinhvienDataSet2;
            // 
            // quanlyhososinhvienDataSet2
            // 
            this.quanlyhososinhvienDataSet2.DataSetName = "quanlyhososinhvienDataSet2";
            this.quanlyhososinhvienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combolop
            // 
            this.combolop.FormattingEnabled = true;
            this.combolop.Location = new System.Drawing.Point(123, 260);
            this.combolop.Name = "combolop";
            this.combolop.Size = new System.Drawing.Size(179, 21);
            this.combolop.TabIndex = 8;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "lop";
            this.lopBindingSource.DataSource = this.quanlyhososinhvienDataSet15;
            // 
            // quanlyhososinhvienDataSet15
            // 
            this.quanlyhososinhvienDataSet15.DataSetName = "quanlyhososinhvienDataSet15";
            this.quanlyhososinhvienDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // hedaotaoTableAdapter
            // 
            this.hedaotaoTableAdapter.ClearBeforeFill = true;
            // 
            // sua
            // 
            this.AcceptButton = this.btnluu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::quanlyhhososinhvien.Properties.Resources.R;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Name = "sua";
            this.Text = "Thông tin học sinh";
            this.Load += new System.EventHandler(this.sua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hedaotaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmasinhvien;
        private System.Windows.Forms.TextBox txttensinhvien;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.TextBox txtcccd;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DateTimePicker datengaysinh;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combolop;
        private quanlyhososinhvienDataSet15 quanlyhososinhvienDataSet15;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private quanlyhososinhvienDataSet15TableAdapters.lopTableAdapter lopTableAdapter;
        private System.Windows.Forms.ComboBox combohedaotao;
        private quanlyhososinhvienDataSet2 quanlyhososinhvienDataSet2;
        private System.Windows.Forms.BindingSource hedaotaoBindingSource;
        private quanlyhososinhvienDataSet2TableAdapters.hedaotaoTableAdapter hedaotaoTableAdapter;
    }
}