using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMovie
{
    class PhimTinhCamFactory:List
    {
        public override void SetPhim()
        {
            film = new PhimTinhCam("PhimTinhCam");
        }
    }
}
