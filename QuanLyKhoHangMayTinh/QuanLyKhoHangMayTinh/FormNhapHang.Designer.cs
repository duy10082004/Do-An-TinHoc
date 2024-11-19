namespace QuanLyKhoHangMayTinh
{
    partial class FormNhapHang
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
            this.txt_NhMaNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NhConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_NhNgayNhapHang = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NhExit = new System.Windows.Forms.Button();
            this.dgv_DonNhapHang = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_NhGiaNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.col_MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_NhDel = new System.Windows.Forms.Button();
            this.btn_NhFix = new System.Windows.Forms.Button();
            this.btn_NhAdd = new System.Windows.Forms.Button();
            this.txt_NhSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NhTenHangHoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NhMaHangHoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonNhapHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NhMaNhanVien
            // 
            this.txt_NhMaNhanVien.Location = new System.Drawing.Point(47, 43);
            this.txt_NhMaNhanVien.Name = "txt_NhMaNhanVien";
            this.txt_NhMaNhanVien.Size = new System.Drawing.Size(202, 20);
            this.txt_NhMaNhanVien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // btn_NhConfirm
            // 
            this.btn_NhConfirm.Location = new System.Drawing.Point(47, 108);
            this.btn_NhConfirm.Name = "btn_NhConfirm";
            this.btn_NhConfirm.Size = new System.Drawing.Size(88, 29);
            this.btn_NhConfirm.TabIndex = 2;
            this.btn_NhConfirm.Text = "Xác Nhận";
            this.btn_NhConfirm.UseVisualStyleBackColor = true;
            this.btn_NhConfirm.Click += new System.EventHandler(this.btn_NhConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Nhập Hàng";
            // 
            // dt_NhNgayNhapHang
            // 
            this.dt_NhNgayNhapHang.Location = new System.Drawing.Point(47, 82);
            this.dt_NhNgayNhapHang.Name = "dt_NhNgayNhapHang";
            this.dt_NhNgayNhapHang.Size = new System.Drawing.Size(201, 20);
            this.dt_NhNgayNhapHang.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_NhExit);
            this.groupBox1.Controls.Add(this.dgv_DonNhapHang);
            this.groupBox1.Controls.Add(this.dt_NhNgayNhapHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_NhConfirm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_NhMaNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 494);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // btn_NhExit
            // 
            this.btn_NhExit.Location = new System.Drawing.Point(160, 108);
            this.btn_NhExit.Name = "btn_NhExit";
            this.btn_NhExit.Size = new System.Drawing.Size(88, 29);
            this.btn_NhExit.TabIndex = 11;
            this.btn_NhExit.Text = "Thoát";
            this.btn_NhExit.UseVisualStyleBackColor = true;
            this.btn_NhExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgv_DonNhapHang
            // 
            this.dgv_DonNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DonNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_DonNhapHang.Location = new System.Drawing.Point(6, 240);
            this.dgv_DonNhapHang.Name = "dgv_DonNhapHang";
            this.dgv_DonNhapHang.Size = new System.Drawing.Size(454, 248);
            this.dgv_DonNhapHang.TabIndex = 10;
            this.dgv_DonNhapHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_NhGiaNhap);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvMatHang);
            this.groupBox2.Controls.Add(this.btn_NhDel);
            this.groupBox2.Controls.Add(this.btn_NhFix);
            this.groupBox2.Controls.Add(this.btn_NhAdd);
            this.groupBox2.Controls.Add(this.txt_NhSoLuong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_NhTenHangHoa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_NhMaHangHoa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(517, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 494);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Đơn Hàng";
            // 
            // txt_NhGiaNhap
            // 
            this.txt_NhGiaNhap.Location = new System.Drawing.Point(32, 201);
            this.txt_NhGiaNhap.Name = "txt_NhGiaNhap";
            this.txt_NhGiaNhap.Size = new System.Drawing.Size(373, 20);
            this.txt_NhGiaNhap.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Giá Nhập";
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaHang,
            this.col_TenHang,
            this.col_SoLuong,
            this.col_GiaNhap,
            this.col_ThanhTien,
            this.col_NgayNhap});
            this.dgvMatHang.Location = new System.Drawing.Point(8, 240);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.Size = new System.Drawing.Size(613, 248);
            this.dgvMatHang.TabIndex = 9;
            this.dgvMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatHang_CellClick);
            this.dgvMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatHang_CellContentClick);
            // 
            // col_MaHang
            // 
            this.col_MaHang.DataPropertyName = "nh_MaHangHoa";
            this.col_MaHang.HeaderText = "Mã Hàng ";
            this.col_MaHang.Name = "col_MaHang";
            // 
            // col_TenHang
            // 
            this.col_TenHang.DataPropertyName = "nh_TenHangHoa";
            this.col_TenHang.HeaderText = "Tên Hàng";
            this.col_TenHang.Name = "col_TenHang";
            // 
            // col_SoLuong
            // 
            this.col_SoLuong.DataPropertyName = "nh_SoLuong";
            this.col_SoLuong.HeaderText = "Số Lượng";
            this.col_SoLuong.Name = "col_SoLuong";
            // 
            // col_GiaNhap
            // 
            this.col_GiaNhap.DataPropertyName = "nh_GiaNhap";
            this.col_GiaNhap.HeaderText = "Giá Nhập";
            this.col_GiaNhap.Name = "col_GiaNhap";
            // 
            // col_ThanhTien
            // 
            this.col_ThanhTien.DataPropertyName = "nh_ThanhTienMatHang";
            this.col_ThanhTien.HeaderText = "Thành Tiền";
            this.col_ThanhTien.Name = "col_ThanhTien";
            // 
            // col_NgayNhap
            // 
            this.col_NgayNhap.DataPropertyName = "nh_NgayNhapHang";
            this.col_NgayNhap.HeaderText = "Ngày Nhập";
            this.col_NgayNhap.Name = "col_NgayNhap";
            // 
            // btn_NhDel
            // 
            this.btn_NhDel.Location = new System.Drawing.Point(411, 149);
            this.btn_NhDel.Name = "btn_NhDel";
            this.btn_NhDel.Size = new System.Drawing.Size(88, 27);
            this.btn_NhDel.TabIndex = 8;
            this.btn_NhDel.Text = "Xóa";
            this.btn_NhDel.UseVisualStyleBackColor = true;
            this.btn_NhDel.Click += new System.EventHandler(this.btn_NhDel_Click);
            // 
            // btn_NhFix
            // 
            this.btn_NhFix.Location = new System.Drawing.Point(411, 99);
            this.btn_NhFix.Name = "btn_NhFix";
            this.btn_NhFix.Size = new System.Drawing.Size(88, 27);
            this.btn_NhFix.TabIndex = 7;
            this.btn_NhFix.Text = "Sửa";
            this.btn_NhFix.UseVisualStyleBackColor = true;
            this.btn_NhFix.Click += new System.EventHandler(this.btn_NhFix_Click);
            // 
            // btn_NhAdd
            // 
            this.btn_NhAdd.Location = new System.Drawing.Point(411, 47);
            this.btn_NhAdd.Name = "btn_NhAdd";
            this.btn_NhAdd.Size = new System.Drawing.Size(88, 27);
            this.btn_NhAdd.TabIndex = 6;
            this.btn_NhAdd.Text = "Thêm";
            this.btn_NhAdd.UseVisualStyleBackColor = true;
            this.btn_NhAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_NhSoLuong
            // 
            this.txt_NhSoLuong.Location = new System.Drawing.Point(32, 153);
            this.txt_NhSoLuong.Name = "txt_NhSoLuong";
            this.txt_NhSoLuong.Size = new System.Drawing.Size(373, 20);
            this.txt_NhSoLuong.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Lượng";
            // 
            // txt_NhTenHangHoa
            // 
            this.txt_NhTenHangHoa.Location = new System.Drawing.Point(32, 106);
            this.txt_NhTenHangHoa.Name = "txt_NhTenHangHoa";
            this.txt_NhTenHangHoa.Size = new System.Drawing.Size(373, 20);
            this.txt_NhTenHangHoa.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Hàng Hóa";
            // 
            // txt_NhMaHangHoa
            // 
            this.txt_NhMaHangHoa.Location = new System.Drawing.Point(32, 51);
            this.txt_NhMaHangHoa.Name = "txt_NhMaHangHoa";
            this.txt_NhMaHangHoa.Size = new System.Drawing.Size(373, 20);
            this.txt_NhMaHangHoa.TabIndex = 1;
            this.txt_NhMaHangHoa.TextChanged += new System.EventHandler(this.txt_NhMaHangHoa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hàng Hóa";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nh_MaNhanVienNhap";
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nh_NgayNhapDonHang";
            this.Column2.HeaderText = "Ngày Nhập";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nh_MaDonHangNhap";
            this.Column3.HeaderText = "Mã Đơn Hàng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nh_ThanhTienDonHangNhap";
            this.Column4.HeaderText = "Thành Tiền";
            this.Column4.Name = "Column4";
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNhapHang";
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonNhapHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NhMaNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NhConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_NhNgayNhapHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_NhSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NhTenHangHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NhMaHangHoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.Button btn_NhDel;
        private System.Windows.Forms.Button btn_NhFix;
        private System.Windows.Forms.Button btn_NhAdd;
        private System.Windows.Forms.DataGridView dgv_DonNhapHang;
        private System.Windows.Forms.TextBox txt_NhGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_NhExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

