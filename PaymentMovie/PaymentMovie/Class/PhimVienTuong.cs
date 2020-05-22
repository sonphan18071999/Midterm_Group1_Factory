using PaymentMovie.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMovie
{
    class PhimVienTuong : Phim
    {
        private string name;

        public PhimVienTuong(string name)
        {
            this.name = name;
        }

        public override string Description()
        {
            return "PhimVienTuong";
        }
    }
}
