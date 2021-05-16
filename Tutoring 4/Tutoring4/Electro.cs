using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring4
{
    class Electro
    {
        public string AS(string name, int num)
        {
            if (name == "전자기기")
            {
                if (num >= 2)
                {
                    return "AS 2년 보장";
                }
                
            }
            return null;
        }
    }
}
