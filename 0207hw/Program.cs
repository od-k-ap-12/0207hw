using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Website website = new Website("name", "path", "description", "ip");
            website.Print();
            Magazine magazine = new Magazine("name", 1999, "description", "phone","email");
            website.Print();
            Shop shop = new Shop("name", "address", "description", "phone","email");
            website.Print();
        }
    }
}
