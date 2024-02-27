using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TrungtamYOLA
{
    class HocVien
    {
        public string MaHocVien;
        public string MaKhoaHoc;
        public string SĐT;
        public string Email;
        public string DiaChi;
        public string CCCD;
        public string Hovaten;

        public string mahv
        {
            get { return MaHocVien; }
            set { MaHocVien=value; }
        }
        public string makh
        {
            get { return MaKhoaHoc; }
            set { MaKhoaHoc = value; }
        }
        public string sdt
        {
            get { return SĐT; }
            set { SĐT=value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; ; }
        }
        public string diachi
        {
            get { return DiaChi; }
            set { DiaChi = value ; }
        }
        public string cccd
        {
            get { return CCCD; }
            set { CCCD=value; }
        }
        public string hoten
        {
            get { return Hovaten; }
            set { Hovaten=value; }
        }
        public HocVien()
        {
            Hovaten = string.Empty;
            MaHocVien = string.Empty;
            MaKhoaHoc = string.Empty;
        }
        public HocVien(string MaHocVien, string MaKhoaHoc, string SĐT, string Email, string DiaChi, string CCCD, string Hovaten)
        {
            this.MaKhoaHoc = MaKhoaHoc;
            this.MaHocVien = MaHocVien;
            this.SĐT = SĐT;
            this.DiaChi = DiaChi;
            this.CCCD = CCCD;
            this.Hovaten = Hovaten;
            this.Email = Email;
        }
        public int tienhocphi()
        {
            int s = 0;
            if (MaKhoaHoc == "KH1")
            {
                s = 9500000;
            }
            else
            {
                if (MaKhoaHoc == "KH2")
                {
                    s = 8000000;
                }
                else
                {
                    if (MaKhoaHoc == "KH3")
                    {
                        s = 7000000;
                    }
                    else
                    {
                        if (MaKhoaHoc == "KH4")
                        {
                            s = 16450000;
                        }
                        else
                        {
                            if (MaKhoaHoc == "KH5")
                            {
                                s = 1400000;
                            }
                            else s = 1200000;
                        }
                    }
                }
            }
            return s;
        }
    }
}
