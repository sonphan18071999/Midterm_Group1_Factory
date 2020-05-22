using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMovie
{
    class PhimVienTuongFactory : List
    {
        public override void SetPhim()
        {
            film = new PhimVienTuong("PhimVienTuong");
        }
    }
}
