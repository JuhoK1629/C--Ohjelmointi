using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna pisteet: ");
            int pisteet = int.Parse(Console.ReadLine());
            switch (pisteet)
            {
                case 0: Console.WriteLine("Numerosi on 0"); break;
                case 2: Console.WriteLine("Numerosi on 1"); break;
                case 3: Console.WriteLine("Numerosi on 1"); break;
            }
            }
        }
    }
}
