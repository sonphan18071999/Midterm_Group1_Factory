using PaymentMovie.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMovie
{
    class PhimTinhCam: Phim
    {
        private string name;

    public PhimTinhCam(string name)
    {
        this.name = name;
    }

    public override string Description()
    {
        return "PhimTinhCam";
    }
}
}
