namespace quanlyhhososinhvien
{
    partial class timkiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checklop = new System.Windows.Forms.CheckBox();
            this.combolop = new System.Windows.Forms.ComboBox();
            this.thongtinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlyhososinhvienDataSet1 = new quanlyhhososinhvien.quanlyhososinhvienDataSet1();
            this.txtmahocsinh2 = new System.Windows.Forms.TextBox();
            this.txtcccd2 = new System.Windows.Forms.TextBox();
            this.datengaysinh2 = new System.Windows.Forms.DateTimePicker();
            this.txtmahocsinh1 = new System.Windows.Forms.TextBox();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datengaysinh1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtcccd1 = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.butthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.thongtinTableAdapter = new quanlyhhososinhvien.quanlyhososinhvienDataSet1TableAdapters.thongtinTableAdapter();
            this.quanlyhososinhvienDataSet34 = new quanlyhhososinhvien.quanlyhososinhvienDataSet34();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new quanlyhhososinhvien.quanlyhososinhvienDataSet34TableAdapters.lopTableAdapter();
            this.checkhedaotao = new System.Windows.Forms.CheckBox();
            this.combohedaotao = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.quanlyhososinhvienDataSet35 = new quanlyhhososinhvien.quanlyhososinhvienDataSet35();
            this.hedaotaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hedaotaoTableAdapter = new quanlyhhososinhvien.quanlyhososinhvienDataSet35TableAdapters.hedaotaoTableAdapter();
            this.hedaotaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hedaotaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hedaotaoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.checkhedaotao);
            this.groupBox1.Controls.Add(this.combohedaotao);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.checklop);
            this.groupBox1.Controls.Add(this.combolop);
            this.groupBox1.Controls.Add(this.txtmahocsinh2);
            this.groupBox1.Controls.Add(this.txtcccd2);
            this.groupBox1.Controls.Add(this.datengaysinh2);
            this.groupBox1.Controls.Add(this.txtmahocsinh1);
            this.groupBox1.Controls.Add(this.rdnu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdnam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.datengaysinh1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtcccd1);
            this.groupBox1.Location = new System.Drawing.Point(46, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 312);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // checklop
            // 
            this.checklop.AutoSize = true;
            this.checklop.Location = new System.Drawing.Point(263, 231);
            this.checklop.Name = "checklop";
            this.checklop.Size = new System.Drawing.Size(44, 17);
            this.checklop.TabIndex = 12;
            this.checklop.Text = "Lớp";
            this.checklop.UseVisualStyleBackColor = true;
            this.checklop.CheckedChanged += new System.EventHandler(this.checklop_CheckedChanged);
            // 
            // combolop
            // 
            this.combolop.Enabled = false;
            this.combolop.FormattingEnabled = true;
            this.combolop.Location = new System.Drawing.Point(96, 230);
            this.combolop.Name = "combolop";
            this.combolop.Size = new System.Drawing.Size(159, 21);
            this.combolop.TabIndex = 11;
            // 
            // thongtinBindingSource
            // 
            this.thongtinBindingSource.DataMember = "thongtin";
            this.thongtinBindingSource.DataSource = this.quanlyhososinhvienDataSet1;
            // 
            // quanlyhososinhvienDataSet1
            // 
            this.quanlyhososinhvienDataSet1.DataSetName = "quanlyhososinhvienDataSet1";
            this.quanlyhososinhvienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtmahocsinh2
            // 
            this.txtmahocsinh2.Location = new System.Drawing.Point(236, 20);
            this.txtmahocsinh2.MaxLength = 999999;
            this.txtmahocsinh2.Name = "txtmahocsinh2";
            this.txtmahocsinh2.Size = new System.Drawing.Size(95, 20);
            this.txtmahocsinh2.TabIndex = 2;
            // 
            // txtcccd2
            // 
            this.txtcccd2.Location = new System.Drawing.Point(236, 155);
            this.txtcccd2.Name = "txtcccd2";
            this.txtcccd2.Size = new System.Drawing.Size(95, 20);
            this.txtcccd2.TabIndex = 9;
            // 
            // datengaysinh2
            // 
            this.datengaysinh2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh2.Location = new System.Drawing.Point(236, 87);
            this.datengaysinh2.Name = "datengaysinh2";
            this.datengaysinh2.Size = new System.Drawing.Size(95, 20);
            this.datengaysinh2.TabIndex = 5;
            // 
            // txtmahocsinh1
            // 
            this.txtmahocsinh1.Location = new System.Drawing.Point(96, 19);
            this.txtmahocsinh1.MaxLength = 999999;
            this.txtmahocsinh1.Name = "txtmahocsinh1";
            this.txtmahocsinh1.Size = new System.Drawing.Size(95, 20);
            this.txtmahocsinh1.TabIndex = 1;
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(216, 123);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(39, 17);
            this.rdnu.TabIndex = 7;
            this.rdnu.TabStop = true;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên";
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Location = new System.Drawing.Point(96, 123);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(47, 17);
            this.rdnam.TabIndex = 6;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // datengaysinh1
            // 
            this.datengaysinh1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaysinh1.Location = new System.Drawing.Point(96, 87);
            this.datengaysinh1.Name = "datengaysinh1";
            this.datengaysinh1.Size = new System.Drawing.Size(95, 20);
            this.datengaysinh1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "CCCD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "SĐT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lớp";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(96, 54);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(235, 20);
            this.txthoten.TabIndex = 3;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(96, 192);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(235, 20);
            this.txtsdt.TabIndex = 1;
            // 
            // txtcccd1
            // 
            this.txtcccd1.Location = new System.Drawing.Point(96, 158);
            this.txtcccd1.Name = "txtcccd1";
            this.txtcccd1.Size = new System.Drawing.Size(95, 20);
            this.txtcccd1.TabIndex = 8;
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btntimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntimkiem.Location = new System.Drawing.Point(246, 386);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 28);
            this.btntimkiem.TabIndex = 13;
            this.btntimkiem.Text = "Lọc";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // butthoat
            // 
            this.butthoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butthoat.Location = new System.Drawing.Point(126, 386);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 28);
            this.butthoat.TabIndex = 14;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = false;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nhập thông tin sinh viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // thongtinTableAdapter
            // 
            this.thongtinTableAdapter.ClearBeforeFill = true;
            // 
            // quanlyhososinhvienDataSet34
            // 
            this.quanlyhososinhvienDataSet34.DataSetName = "quanlyhososinhvienDataSet34";
            this.quanlyhososinhvienDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "lop";
            this.lopBindingSource.DataSource = this.quanlyhososinhvienDataSet34;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // checkhedaotao
            // 
            this.checkhedaotao.AutoSize = true;
            this.checkhedaotao.Location = new System.Drawing.Point(263, 271);
            this.checkhedaotao.Name = "checkhedaotao";
            this.checkhedaotao.Size = new System.Drawing.Size(80, 17);
            this.checkhedaotao.TabIndex = 15;
            this.checkhedaotao.Text = "Hệ đào tạo";
            this.checkhedaotao.UseVisualStyleBackColor = true;
            this.checkhedaotao.CheckedChanged += new System.EventHandler(this.checkhedaotao_CheckedChanged);
            // 
            // combohedaotao
            // 
            this.combohedaotao.Enabled = false;
            this.combohedaotao.FormattingEnabled = true;
            this.combohedaotao.Location = new System.Drawing.Point(96, 270);
            this.combohedaotao.Name = "combohedaotao";
            this.combohedaotao.Size = new System.Drawing.Size(159, 21);
            this.combohedaotao.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Hệ đào tạo";
            // 
            // quanlyhososinhvienDataSet35
            // 
            this.quanlyhososinhvienDataSet35.DataSetName = "quanlyhososinhvienDataSet35";
            this.quanlyhososinhvienDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hedaotaoBindingSource
            // 
            this.hedaotaoBindingSource.DataMember = "hedaotao";
            this.hedaotaoBindingSource.DataSource = this.quanlyhososinhvienDataSet35;
            // 
            // hedaotaoTableAdapter
            // 
            this.hedaotaoTableAdapter.ClearBeforeFill = true;
            // 
            // hedaotaoBindingSource1
            // 
            this.hedaotaoBindingSource1.DataMember = "hedaotao";
            this.hedaotaoBindingSource1.DataSource = this.quanlyhososinhvienDataSet35;
            // 
            // timkiem
            // 
            this.AcceptButton = this.btntimkiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlyhhososinhvien.Properties.Resources.R;
            this.CancelButton = this.butthoat;
            this.ClientSize = new System.Drawing.Size(461, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.groupBox1);
            this.Name = "timkiem";
            this.Text = "Tìm kiếm học sinh";
            this.Load += new System.EventHandler(this.timkiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongtinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hedaotaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hedaotaoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmahocsinh1;
        private System.Windows.Forms.RadioButton rdnu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datengaysinh1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtcccd1;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datengaysinh2;
        private System.Windows.Forms.TextBox txtcccd2;
        private System.Windows.Forms.TextBox txtmahocsinh2;
        private System.Windows.Forms.ComboBox combolop;
        private quanlyhososinhvienDataSet1 quanlyhososinhvienDataSet1;
        private System.Windows.Forms.BindingSource thongtinBindingSource;
        private quanlyhososinhvienDataSet1TableAdapters.thongtinTableAdapter thongtinTableAdapter;
        private System.Windows.Forms.CheckBox checklop;
        private quanlyhososinhvienDataSet34 quanlyhososinhvienDataSet34;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private quanlyhososinhvienDataSet34TableAdapters.lopTableAdapter lopTableAdapter;
        private System.Windows.Forms.CheckBox checkhedaotao;
        private System.Windows.Forms.ComboBox combohedaotao;
        private System.Windows.Forms.Label label9;
        private quanlyhososinhvienDataSet35 quanlyhososinhvienDataSet35;
        private System.Windows.Forms.BindingSource hedaotaoBindingSource;
        private quanlyhososinhvienDataSet35TableAdapters.hedaotaoTableAdapter hedaotaoTableAdapter;
        private System.Windows.Forms.BindingSource hedaotaoBindingSource1;
    }
}