namespace quanlyhhososinhvien
{
    partial class hocki
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
            this.combohocki = new System.Windows.Forms.ComboBox();
            this.hockiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanlyhososinhvienDataSet25 = new quanlyhhososinhvien.quanlyhososinhvienDataSet25();
            this.hockiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlyhososinhvienDataSet23 = new quanlyhhososinhvien.quanlyhososinhvienDataSet23();
            this.label1 = new System.Windows.Forms.Label();
            this.lbhoten = new System.Windows.Forms.Label();
            this.datadiemhocki = new System.Windows.Forms.DataGridView();
            this.mahocsinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocsinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hockiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemx1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemx2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketquahoctapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlyhososinhvienDataSet22 = new quanlyhhososinhvien.quanlyhososinhvienDataSet22();
            this.lbmasinhvien = new System.Windows.Forms.Label();
            this.ketquahoctapTableAdapter = new quanlyhhososinhvien.quanlyhososinhvienDataSet22TableAdapters.ketquahoctapTableAdapter();
            this.btnthoat = new System.Windows.Forms.Button();
            this.hockiTableAdapter = new quanlyhhososinhvien.quanlyhososinhvienDataSet23TableAdapters.hockiTableAdapter();
            this.btnthem = new System.Windows.Forms.Button();
            this.quanlyhososinhvienDataSet24 = new quanlyhhososinhvien.quanlyhososinhvienDataSet24();
            this.ketquahoctapTableAdapter1 = new quanlyhhososinhvien.quanlyhososinhvienDataSet24TableAdapters.ketquahoctapTableAdapter();
            this.hockiTableAdapter1 = new quanlyhhososinhvien.quanlyhososinhvienDataSet25TableAdapters.hockiTableAdapter();
            this.ketquahoctapTableAdapter2 = new quanlyhhososinhvien.quanlyhososinhvienDataSet25TableAdapters.ketquahoctapTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hockiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadiemhocki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquahoctapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet24)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // combohocki
            // 
            this.combohocki.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hockiBindingSource1, "hocki", true));
            this.combohocki.DataSource = this.hockiBindingSource;
            this.combohocki.DisplayMember = "hocki";
            this.combohocki.FormattingEnabled = true;
            this.combohocki.Location = new System.Drawing.Point(291, 22);
            this.combohocki.Name = "combohocki";
            this.combohocki.Size = new System.Drawing.Size(101, 21);
            this.combohocki.TabIndex = 4;
            this.combohocki.ValueMember = "hocki";
            this.combohocki.SelectedIndexChanged += new System.EventHandler(this.combohocki_SelectedIndexChanged);
            // 
            // hockiBindingSource1
            // 
            this.hockiBindingSource1.DataMember = "hocki";
            this.hockiBindingSource1.DataSource = this.quanlyhososinhvienDataSet25;
            // 
            // quanlyhososinhvienDataSet25
            // 
            this.quanlyhososinhvienDataSet25.DataSetName = "quanlyhososinhvienDataSet25";
            this.quanlyhososinhvienDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hockiBindingSource
            // 
            this.hockiBindingSource.DataMember = "hocki";
            this.hockiBindingSource.DataSource = this.quanlyhososinhvienDataSet25;
            // 
            // quanlyhososinhvienDataSet23
            // 
            this.quanlyhososinhvienDataSet23.DataSetName = "quanlyhososinhvienDataSet23";
            this.quanlyhososinhvienDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Điểm các học kì";
            // 
            // lbhoten
            // 
            this.lbhoten.AutoSize = true;
            this.lbhoten.Location = new System.Drawing.Point(64, 25);
            this.lbhoten.Name = "lbhoten";
            this.lbhoten.Size = new System.Drawing.Size(41, 13);
            this.lbhoten.TabIndex = 76;
            this.lbhoten.Text = "label25";
            this.lbhoten.Click += new System.EventHandler(this.lbhoten_Click);
            // 
            // datadiemhocki
            // 
            this.datadiemhocki.AutoGenerateColumns = false;
            this.datadiemhocki.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datadiemhocki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadiemhocki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahocsinhDataGridViewTextBoxColumn,
            this.tenhocsinhDataGridViewTextBoxColumn,
            this.tenmonhocDataGridViewTextBoxColumn,
            this.hockiDataGridViewTextBoxColumn,
            this.diemx1DataGridViewTextBoxColumn,
            this.diemx2DataGridViewTextBoxColumn,
            this.diemyDataGridViewTextBoxColumn,
            this.diemzDataGridViewTextBoxColumn});
            this.datadiemhocki.DataSource = this.ketquahoctapBindingSource;
            this.datadiemhocki.Location = new System.Drawing.Point(0, 115);
            this.datadiemhocki.Name = "datadiemhocki";
            this.datadiemhocki.Size = new System.Drawing.Size(843, 330);
            this.datadiemhocki.TabIndex = 77;
            this.datadiemhocki.SelectionChanged += new System.EventHandler(this.datadiemhocki_SelectionChanged);
            // 
            // mahocsinhDataGridViewTextBoxColumn
            // 
            this.mahocsinhDataGridViewTextBoxColumn.DataPropertyName = "mahocsinh";
            this.mahocsinhDataGridViewTextBoxColumn.HeaderText = "Mã học sinh";
            this.mahocsinhDataGridViewTextBoxColumn.Name = "mahocsinhDataGridViewTextBoxColumn";
            // 
            // tenhocsinhDataGridViewTextBoxColumn
            // 
            this.tenhocsinhDataGridViewTextBoxColumn.DataPropertyName = "tenhocsinh";
            this.tenhocsinhDataGridViewTextBoxColumn.HeaderText = "Tên học sinh";
            this.tenhocsinhDataGridViewTextBoxColumn.Name = "tenhocsinhDataGridViewTextBoxColumn";
            // 
            // tenmonhocDataGridViewTextBoxColumn
            // 
            this.tenmonhocDataGridViewTextBoxColumn.DataPropertyName = "tenmonhoc";
            this.tenmonhocDataGridViewTextBoxColumn.HeaderText = "Môn học";
            this.tenmonhocDataGridViewTextBoxColumn.Name = "tenmonhocDataGridViewTextBoxColumn";
            // 
            // hockiDataGridViewTextBoxColumn
            // 
            this.hockiDataGridViewTextBoxColumn.DataPropertyName = "hocki";
            this.hockiDataGridViewTextBoxColumn.HeaderText = "Học kì";
            this.hockiDataGridViewTextBoxColumn.Name = "hockiDataGridViewTextBoxColumn";
            // 
            // diemx1DataGridViewTextBoxColumn
            // 
            this.diemx1DataGridViewTextBoxColumn.DataPropertyName = "diemx1";
            this.diemx1DataGridViewTextBoxColumn.HeaderText = "Điểm x1";
            this.diemx1DataGridViewTextBoxColumn.Name = "diemx1DataGridViewTextBoxColumn";
            // 
            // diemx2DataGridViewTextBoxColumn
            // 
            this.diemx2DataGridViewTextBoxColumn.DataPropertyName = "diemx2";
            this.diemx2DataGridViewTextBoxColumn.HeaderText = "Điểm x2";
            this.diemx2DataGridViewTextBoxColumn.Name = "diemx2DataGridViewTextBoxColumn";
            // 
            // diemyDataGridViewTextBoxColumn
            // 
            this.diemyDataGridViewTextBoxColumn.DataPropertyName = "diemy";
            this.diemyDataGridViewTextBoxColumn.HeaderText = "Điểm y";
            this.diemyDataGridViewTextBoxColumn.Name = "diemyDataGridViewTextBoxColumn";
            // 
            // diemzDataGridViewTextBoxColumn
            // 
            this.diemzDataGridViewTextBoxColumn.DataPropertyName = "diemz";
            this.diemzDataGridViewTextBoxColumn.HeaderText = "Điểm z";
            this.diemzDataGridViewTextBoxColumn.Name = "diemzDataGridViewTextBoxColumn";
            // 
            // ketquahoctapBindingSource
            // 
            this.ketquahoctapBindingSource.DataMember = "ketquahoctap";
            this.ketquahoctapBindingSource.DataSource = this.quanlyhososinhvienDataSet25;
            // 
            // quanlyhososinhvienDataSet22
            // 
            this.quanlyhososinhvienDataSet22.DataSetName = "quanlyhososinhvienDataSet22";
            this.quanlyhososinhvienDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbmasinhvien
            // 
            this.lbmasinhvien.AutoSize = true;
            this.lbmasinhvien.Location = new System.Drawing.Point(6, 25);
            this.lbmasinhvien.Name = "lbmasinhvien";
            this.lbmasinhvien.Size = new System.Drawing.Size(41, 13);
            this.lbmasinhvien.TabIndex = 78;
            this.lbmasinhvien.Text = "label25";
            // 
            // ketquahoctapTableAdapter
            // 
            this.ketquahoctapTableAdapter.ClearBeforeFill = true;
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Location = new System.Drawing.Point(6, 20);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // hockiTableAdapter
            // 
            this.hockiTableAdapter.ClearBeforeFill = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(197, 20);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // quanlyhososinhvienDataSet24
            // 
            this.quanlyhososinhvienDataSet24.DataSetName = "quanlyhososinhvienDataSet24";
            this.quanlyhososinhvienDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ketquahoctapTableAdapter1
            // 
            this.ketquahoctapTableAdapter1.ClearBeforeFill = true;
            // 
            // hockiTableAdapter1
            // 
            this.hockiTableAdapter1.ClearBeforeFill = true;
            // 
            // ketquahoctapTableAdapter2
            // 
            this.ketquahoctapTableAdapter2.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.combohocki);
            this.groupBox1.Location = new System.Drawing.Point(442, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 53);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.lbmasinhvien);
            this.groupBox2.Controls.Add(this.lbhoten);
            this.groupBox2.Location = new System.Drawing.Point(0, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 53);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin học sinh";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hocki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quanlyhhososinhvien.Properties.Resources.R;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(844, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datadiemhocki);
            this.Controls.Add(this.label1);
            this.Name = "hocki";
            this.Text = "Điểm các học kì";
            this.Load += new System.EventHandler(this.hocki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hockiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datadiemhocki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketquahoctapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyhososinhvienDataSet24)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combohocki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbhoten;
        private System.Windows.Forms.DataGridView datadiemhocki;
        private System.Windows.Forms.Label lbmasinhvien;
        private quanlyhososinhvienDataSet22 quanlyhososinhvienDataSet22;
        private quanlyhososinhvienDataSet22TableAdapters.ketquahoctapTableAdapter ketquahoctapTableAdapter;
        private System.Windows.Forms.Button btnthoat;
        private quanlyhososinhvienDataSet23 quanlyhososinhvienDataSet23;
        private quanlyhososinhvienDataSet23TableAdapters.hockiTableAdapter hockiTableAdapter;
        private System.Windows.Forms.Button btnthem;
        private quanlyhososinhvienDataSet24 quanlyhososinhvienDataSet24;
        private quanlyhososinhvienDataSet24TableAdapters.ketquahoctapTableAdapter ketquahoctapTableAdapter1;
        private quanlyhososinhvienDataSet25 quanlyhososinhvienDataSet25;
        private System.Windows.Forms.BindingSource hockiBindingSource;
        private quanlyhososinhvienDataSet25TableAdapters.hockiTableAdapter hockiTableAdapter1;
        private System.Windows.Forms.BindingSource hockiBindingSource1;
        private System.Windows.Forms.BindingSource ketquahoctapBindingSource;
        private quanlyhososinhvienDataSet25TableAdapters.ketquahoctapTableAdapter ketquahoctapTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahocsinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocsinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hockiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemx1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemx2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemzDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}