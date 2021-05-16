using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring4
{
    class Owner
    {
        public string Purchase(string name, string num)
        {
            switch(name)
            {
                case "생선":
                    return num;
                case "과일":
                    return num;
                case "전자기기":
                    return num;
            }
            return null;
        }
    }
}
