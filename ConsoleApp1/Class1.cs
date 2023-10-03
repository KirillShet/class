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
        public int vrem;
        public float top;
        public int km;
        public int vibor;
        public float dop;
        public float mov = 0;
        public float proh = 0;
        public void info()
        {
            Console.WriteLine("Введите номер авто: ");
            nom = Console.ReadLine();
            Console.WriteLine("Количество бензина в баке: ");
            bak = float.Parse(Console.ReadLine());
            Console.WriteLine("расход топлива на 100 м: ");
            ras = float.Parse(Console.ReadLine());
            Console.Clear();
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
            int osh = 0;
            float litr = 0;
            int nedos = 0;
            mov = 0;
            proh = 0;
            float put = 0 ;
            do
            {
                nedos = 0;
                osh = 0;
                Random rnd = new Random();
                km = rnd.Next(1000, 15000);
                Console.WriteLine("Авто проехало:" + km);
                put = km * ras / 100;
                if (bak < put)
                {
                    Console.WriteLine("Бензина в баке не хватит для того, чтобы доехать до нужного расстояния.");
                    dop = put - bak;
                    proh = km- (bak * 100) / ras;
                    mov = mov +  (bak*100)/ras;
                    Console.WriteLine("Проехал всего: " + mov + " Не доехал от нужного расстояния: " + proh);
                    Console.WriteLine("Для того, чтобы доехать до точки не хватает: " + dop);
                    osh++;
                    do
                    {
                        Console.WriteLine("Если вы хотите заправить бак, то напишиту цифру 1, если нет - 2");
                        vibor = Convert.ToInt32(Console.ReadLine());
                        if (vibor == 1)
                        {
                            
                            litr = float.Parse(Console.ReadLine());
                            mov = mov + (litr/ras*100);
                            bak = bak + litr;
                            if (litr < dop)
                            {
                                dop -= litr;
                                nedos++;
                                Console.WriteLine("Топлива не хватит, чтобы доехать до точки.");
                            }
                            else
                            {
                                nedos = 0;
                                osh--;
                            }
                        }
                    else if (vibor == 2)
                    {
                            nedos = 0;
                        osh++;
                        Console.WriteLine("Всего проехал: " + mov + " Не доехал до нужного расстояния: " + proh);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неправильное чисило или ввели букву.");
                    }
                    } while (nedos > 0) ;
                }
                if (bak >= put)
                {
                    bak = bak - put;
                    mov = mov + km;
                    Console.WriteLine("Авто доедет до заданно точки.");
                    Console.WriteLine("Осталось топлива: " + bak);
                }
            }
            while (osh == 0);
        }

       
    }

}
