using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerKonzola
{
    class Program
    {
        static void Main(string[] args)
        {
            Server s = new ServerKonzola.Server();
            if (s.pokreniServer())
            {
                string x = "1. \n2. \n3.";
                Console.WriteLine(x);
            }
        }
    }
}
