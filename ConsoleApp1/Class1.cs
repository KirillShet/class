using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Avto
    {
        public string nom;
        public float bak;
        public float ras;
        public float speed;
        public float put;
        public int vrem;
        public float top;
        public int km;
        public void info()
        {
            Console.WriteLine("Введите номер авто: ");
            nom = Console.ReadLine();
            Console.WriteLine("Количество бензина в баке: ");
            bak = float.Parse(Console.ReadLine());
            Console.WriteLine("расход топлива на 100 м: ");
            ras = float.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine(nom);
            Console.WriteLine(bak);
            Console.WriteLine(ras);
        }
        public void zapravka()
        {
            Console.WriteLine("");
            top = float.Parse(Console.ReadLine());
        }

        public void move()
        {
            Console.WriteLine("Авто едет на расстояние в случайном диапозоне от 1000 м до 15000");
            Random rnd = new Random();
            km = rnd.Next(1000, 15000);
            Console.WriteLine("Авто проехало:" + km);
            put = (km / 100) * ras;
            if (bak < ras)
            {
                Console.WriteLine("Бензина в баке не хватит для того, чтобы доехать до нужного расстояния.");
                Console.WriteLine("");
            }
        }

       
    }

}
