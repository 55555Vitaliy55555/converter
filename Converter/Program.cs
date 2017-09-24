using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конвертер единиц измерения");

            Menu m = new Menu();
            m.Display();
        }
    }
}
