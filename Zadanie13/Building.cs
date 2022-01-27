using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class Building
    {
        public string adressHome { get; set; }
        public string lengthHome { get; set; }
        public string widthHome { get; set; }
        public int height { get; set; }
        static Building GetHome()
        {
            Building home = new Building();
            home.adressHome = "Лубянка 37";
            home.widthHome = "30";
            home.lengthHome = "40";
            home.height = 80;
            return home;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Информация о здании");
            Console.WriteLine($"Адрес: {adressHome}");
            Console.WriteLine($"Длина: {lengthHome} м");
            Console.WriteLine($"Ширина: {widthHome} м");
            Console.WriteLine($"Высота: {height} м");
        }
    }
}