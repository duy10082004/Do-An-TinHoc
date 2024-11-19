using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHangMayTinh.NhapHang
{
    internal class DanhSachHangNhap
    {
        private List<QuanLyHangNhap> matHangArr;

         
        
        public DanhSachHangNhap()
        {
            matHangArr = new List<QuanLyHangNhap>();
        }

        public DanhSachHangNhap (List<QuanLyHangNhap> matHangArr)
        {
            this.matHangArr = matHangArr;
        }

        public List<QuanLyHangNhap> MatHangArr
        {
            get
            {
                return matHangArr;
            }
            set
            {
                matHangArr = value;
            }
        }
         
        public bool Nh_matHangAdd (QuanLyHangNhap tmp)
        {   
            if (tmp.Nh_MaNhanVien != "") 
            {
                matHangArr.Add(tmp);
                return true;
            }
            else
            {
                return false;   
            }
        }

        public int Nh_ThanhTienDonHangNhap(string idx)
        {
            int result = 0;
            foreach (QuanLyHangNhap tmp in MatHangArr) 
            {
                if(tmp.Nh_MaDonNhap == idx)
                {
                    result += tmp.Nh_ThanhTienMatHang;
                }
            }
            return result;
        }

        private List <QuanLyHangNhap> dsMHTheoDH = new List<QuanLyHangNhap>();
        public List<QuanLyHangNhap> DsMHTHeoDH
        {
            get
            {
                return dsMHTheoDH;
            }
            set
            {
                dsMHTheoDH = value;
            }
        }
        
        public bool checkMHTheoDH (string tmp)
        {
            foreach(QuanLyHangNhap idx in matHangArr)
            {
                if (idx.Nh_MaDonNhap == tmp)
                {
                    dsMHTheoDH.Add(idx);
                }
            }

            if (dsMHTheoDH != null)
            {
                return true;
            }
            else
            {
                return false ;
            }
        }



    }
}
