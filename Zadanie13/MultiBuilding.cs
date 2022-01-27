using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class MultiBuilding : Building
    {
        public void floors()
        {
            Console.WriteLine("Этажность: 25");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MultiBuilding home = new MultiBuilding { adressHome = "Лубянка 37", lengthHome = "30", widthHome = "40", height = 80 };
            home.PrintInfo();
            home.floors();
        }
    }
}
