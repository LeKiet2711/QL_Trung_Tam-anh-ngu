using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TrungtamYOLA
{
    class Dshocvien
    {
        List<HocVien> dshv;
        public Dshocvien()
        {
            dshv = new List<HocVien>();
        }
        public void AddHV(HocVien hv)
        {
            dshv.Add(hv);
        }
    }
}
