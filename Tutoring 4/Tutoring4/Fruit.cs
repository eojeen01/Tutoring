using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring4
{
    class Fruit
    {
        public string Fresh(string name)
        {
            if (name == "과일")
            {
                return "신선도 유지";
            }
            return null;
        }
    }
}
