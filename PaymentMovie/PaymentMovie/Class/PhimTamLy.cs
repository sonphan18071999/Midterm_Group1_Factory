using PaymentMovie.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMovie
{
    class PhimTamLy:Phim
    {
        private string name;

        public PhimTamLy(string name)
        {
            this.name = name;
        }

        public override string Description()
        {
            return "PhimTamLy";
        }
    }
}
