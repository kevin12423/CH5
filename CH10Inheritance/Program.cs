using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class letterClient
    {
        static void Main(string[] args)
        {
            Letter l1 = new Letter("Kevin", "October 6");
            CertifiedLetter cL1 = new CertifiedLetter("kevin", "Oct. 12", 43423);
            Console.WriteLine(l1.ToString());
            Console.WriteLine(cL1.ToString());
        }
    }
}
