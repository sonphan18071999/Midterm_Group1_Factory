using PaymentMovie.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMovie
{
    abstract class List
    {
        protected Phim film;
        public abstract void SetPhim();
        public string PhimInfo()
        {
            return film.Description();
        }
    }
}
