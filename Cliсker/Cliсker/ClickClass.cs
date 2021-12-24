using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliker
{
    public static class ClickClass
    {
        public static bool ClickMethod(int bonus, double price, ref long point, ref int click)
        {
            if (point >= (price))
            {
                point -= Convert.ToInt64(Math.Round(price));
                click += bonus;
                return true;
            }
            return false;
        }
    }
}
