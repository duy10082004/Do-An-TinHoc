using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHangMayTinh.NhapHang
{
    internal class QuanLyHangNhap
    {
        private string nh_MaNhanVien;
        private DateTime nh_NgayNhapHang;
        private string nh_MaDonNhap;
        private int nh_ThanhTienDonHang;


        private string nh_MaHangHoa;
        private string nh_TenHangHoa;
        private int nh_SoLuong;
        private int nh_GiaNhap;
        private int nh_ThanhTienMatHang;

        public QuanLyHangNhap()
        {
            nh_MaNhanVien = "";
            nh_NgayNhapHang = DateTime.Now;
            nh_MaHangHoa = "";
            nh_TenHangHoa = "";
            nh_SoLuong = 0;
            nh_GiaNhap = 0;
            nh_MaDonNhap = "";
            nh_ThanhTienDonHang = 0;
        }

        public QuanLyHangNhap (string nh_MaNhanVien, DateTime nh_NgayNhapHang, string nh_MaHangHoa, string nh_TenHangHoa, int nh_SoLuong
        , string nh_MaDonNhap, int nh_GiaNhap)
        {
            this.nh_MaNhanVien = nh_MaNhanVien;
            this.nh_NgayNhapHang = nh_NgayNhapHang;
            this.nh_MaHangHoa = nh_MaHangHoa;
            this.nh_TenHangHoa = nh_TenHangHoa;
            this.nh_SoLuong = nh_SoLuong;
            this.nh_MaDonNhap = nh_MaDonNhap;
            this.nh_GiaNhap = nh_GiaNhap;
        }

        public string Nh_MaNhanVien
        {
            get { return nh_MaNhanVien; }
            set { nh_MaNhanVien = value; }
        }

        public DateTime Nh_NgayNhapHang
        {
            get { return nh_NgayNhapHang;}
            set { Nh_NgayNhapHang=value; }
        }

        public string Nh_MaHangHoa
        {
            get
            {
                return nh_MaHangHoa;
            }
            set
            {
                nh_MaHangHoa = value;
            }
        }

        public string Nh_TenHangHoa
        {
            get
            {
                return nh_TenHangHoa;
            }
            set
            {
                nh_TenHangHoa = value;
            }
        }

        public int Nh_SoLuong
        {
            get
            {
                return nh_SoLuong;
            }
            set
            {
                nh_SoLuong = value;
            }
        }

        public int Nh_GiaNhap
        {
            get
            {
                return nh_GiaNhap;
            }
            set
            {
                nh_GiaNhap = value;
            }
        }

        public string Nh_MaDonNhap
        {
            get
            {
                return nh_MaDonNhap;
            }
            set
            {
                nh_MaDonNhap = value;
            }
        }

        
        public int Nh_ThanhTienMatHang
        {
            get 
            { 
                return nh_ThanhTienMatHang = nh_GiaNhap*nh_SoLuong;
            }
        }

    }
}
