using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgoTatSon_Bai6
{
    internal class Compare : IComparer<Vehicle>
    {
        int IComparer<Vehicle>.Compare(Vehicle x, Vehicle y)
        {
            return  (int)(x.price - y.price);
        }
    }
}
