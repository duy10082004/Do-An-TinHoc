using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHangMayTinh.NhapHang
{
    internal class DanhSachDonHangNhap
    {
        private List<DonHang> donHangArr;

        public DanhSachDonHangNhap()
        {
            this.donHangArr = new List<DonHang>();
        }
        public DanhSachDonHangNhap(List<DonHang> donHangArr)
        {
            this.donHangArr = donHangArr;
        }

        public List<DonHang> DonHangArr
        {
            get
            {
                return this.donHangArr;
            }
            set
            {
                this.donHangArr = value;
            }
        }
    }
}
