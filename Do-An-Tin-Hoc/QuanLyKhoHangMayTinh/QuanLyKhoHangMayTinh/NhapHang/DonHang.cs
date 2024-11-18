using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHangMayTinh.NhapHang
{
    internal class DonHang
    {
        DanhSachHangNhap dshn = new DanhSachHangNhap();
        private string nh_MaDonHangNhap;
        private int nh_ThanhTienDonHangNhap;
        private string nh_MaNhanVienNhap;
        private DateTime nh_NgayNhapDonHang;

        public DonHang() 
        {
            this.nh_MaDonHangNhap = "";
            this.nh_ThanhTienDonHangNhap = 0;
            this.nh_NgayNhapDonHang = DateTime.Now;
        }
        public DonHang(string nh_MaDonHangNhap, int nh_ThanhTienDonHangNhap, string nh_MaNhanVienNhap, 
        DateTime nh_NgayNhapDonHang)
        {
            this.nh_MaDonHangNhap = nh_MaDonHangNhap;
            this.nh_ThanhTienDonHangNhap = nh_ThanhTienDonHangNhap;
            this.nh_MaNhanVienNhap = nh_MaNhanVienNhap;
            this.nh_NgayNhapDonHang = nh_NgayNhapDonHang;
        }

        public string Nh_MaDonHangNhap
        {
            get
            {
                return nh_MaDonHangNhap;
            }
            set
            {
                nh_MaDonHangNhap = value;
            }
        }

        public int Nh_ThanhTienDonHangNhap
        {
            get
            {
                return dshn.Nh_ThanhTienDonHangNhap(nh_MaDonHangNhap);
            }
        }

        public DateTime Nh_NgayNhapDonHang
        {
            get
            {
                return nh_NgayNhapDonHang;
            }
            set
            {
                nh_NgayNhapDonHang= value;
            }
        }

        public string Nh_MaNhanVienNhap
        {
            get
            {
                return nh_MaNhanVienNhap;
            }
            set
            {
                nh_MaNhanVienNhap= value;
            }
        }
    }
}
