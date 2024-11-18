using QuanLyKhoHangMayTinh.NhapHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHangMayTinh
{
    public partial class FormNhapHang : Form
    {
        private DanhSachHangNhap dsMH = new DanhSachHangNhap();
        private DanhSachDonHangNhap dsDH = new DanhSachDonHangNhap();
        private int index = 1;
        private int mhidx = -1;

        private void renderDGV(DataGridView dgv, List<QuanLyHangNhap> tmp)
        {
            dgv.DataSource = tmp.ToList();

        }

        private void renderDGVDH(DataGridView dgv, List<DonHang> tmp)
        {
            dgv.DataSource = tmp.ToList();

        }

        void reset()
        {
            txt_NhGiaNhap.Clear();
            txt_NhMaHangHoa.Clear();

            txt_NhSoLuong.Clear();
            txt_NhTenHangHoa.Clear();
        }


        public FormNhapHang()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {   

            string nh_MaHangHoa = txt_NhMaHangHoa.Text;
            string nh_TenHangHoa = txt_NhTenHangHoa.Text;
            int nh_SoLuong = int.Parse(txt_NhSoLuong.Text);
            int nh_GiaNhap = int.Parse(txt_NhGiaNhap.Text);
            string nh_MaDonNhap = "DH" + index;
            string nh_MaNhanVien = txt_NhMaNhanVien.Text;
            DateTime nh_NgayNhap = dt_NhNgayNhapHang.Value;
            DonHang dh = new DonHang();
            QuanLyHangNhap tmp = new QuanLyHangNhap(nh_MaNhanVien, nh_NgayNhap, nh_MaHangHoa, nh_TenHangHoa, nh_SoLuong, nh_MaDonNhap, nh_GiaNhap);
            if (dsMH.Nh_matHangAdd(tmp))
            {
                MessageBox.Show("Đã Thêm!!");
                renderDGV(dgvMatHang, dsMH.MatHangArr);
                this.dgvMatHang.Columns["nh_MaNhanVien"].Visible = false;
                //this.dgvMatHang.Columns["nh_MaDonNhap"].Visible = false;
                reset();

            }
            else
            {
                MessageBox.Show("Vui Lòng Điền Mã Nhân Viên!");
            }
            
        }

        private void dgvMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvMatHang.Rows[e.RowIndex];
            mhidx = e.RowIndex;
            txt_NhGiaNhap.Text = Convert.ToString(row.Cells["col_GiaNhap"].Value);
            txt_NhMaHangHoa.Text = Convert.ToString(row.Cells["col_MaHang"].Value);
            txt_NhMaNhanVien.Text = Convert.ToString(row.Cells["nh_MaNhanVien"].Value);
            txt_NhSoLuong.Text = Convert.ToString(row.Cells["col_SoLuong"].Value);
            txt_NhTenHangHoa.Text = Convert.ToString(row.Cells["col_TenHang"].Value);
        }

        private void btn_NhFix_Click(object sender, EventArgs e)
        {
            
            dsMH.MatHangArr[mhidx].Nh_SoLuong = int.Parse(txt_NhSoLuong.Text);
            //dsMH.MatHangArr[mhidx].Nh_NgayNhapHang = dt_NhNgayNhapHang.Value;
            dsMH.MatHangArr[mhidx].Nh_TenHangHoa = txt_NhTenHangHoa.Text;
            dsMH.MatHangArr[mhidx].Nh_MaHangHoa = txt_NhMaHangHoa.Text;
            dsMH.MatHangArr[mhidx].Nh_GiaNhap =int.Parse(txt_NhGiaNhap.Text);
            dsMH.MatHangArr[mhidx].Nh_MaNhanVien = txt_NhMaNhanVien.Text;
            renderDGV(dgvMatHang, dsMH.MatHangArr);
        }

        private void btn_NhDel_Click(object sender, EventArgs e)
        {
            dsMH.MatHangArr.Remove(dsMH.MatHangArr[mhidx]);
            renderDGV(dgvMatHang, dsMH.MatHangArr);
        }

        private void btn_NhConfirm_Click(object sender, EventArgs e)
        {
            string mNV = txt_NhMaNhanVien.Text;
            DateTime nN = dt_NhNgayNhapHang.Value;
            string mDH = "DH" + index;
            int tT = dsMH.Nh_ThanhTienDonHangNhap(mDH);
            DonHang dh = new DonHang(mDH, tT, mNV, nN);
            dsDH.DonHangArr.Add(dh);
            renderDGVDH(dgv_DonNhapHang, dsDH.DonHangArr);
            txt_NhMaNhanVien.Clear();
            index++;
        }

        private void txt_NhMaHangHoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
