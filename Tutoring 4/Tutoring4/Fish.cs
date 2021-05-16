using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring4
{
    class Fish
    {
        public string Discount(string name, int num)
        {
            if(name == "생선")
            {
                if (num >= 5)
                {
                    return "폐기할인";
                }
            }
            return null;
        }
    }
}
