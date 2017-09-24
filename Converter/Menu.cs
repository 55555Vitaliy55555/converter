using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Menu
    {
        char ans;
        int choice;

        public void Display()
        {
            Console.WriteLine("1 - перевод F -> C");
            Console.WriteLine("2 - перевод C -> F");
            Console.WriteLine("3 - Выход");
        }
    }
}
