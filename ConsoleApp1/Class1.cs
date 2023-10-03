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
        public float runaway;
        public float stopaway;
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
        public void move()
        {
            Console.WriteLine("Авто едет на расстояние в случайном диапозоне от 1000 м до 15000");
            int osh = 0;
            float litr = 0;
            int nedos = 0;
            mov = 0;
            proh = 0;
            float put = 0;
            int time = 0;
            int speed = 80;
            float t = 0;
            do
            {
                nedos = 0;
                osh = 0;
                Random rnd = new Random();
                km = rnd.Next(1000, 15000);
                time = km / speed;
                t = time * ras;
                Console.WriteLine("Авто проехало:" + km);
                put = km * ras / 100;
                if (bak < put)
                {
                    Console.WriteLine("Бензина в баке не хватит для того, чтобы доехать до нужного расстояния.");
                    dop = put - bak;
                    proh = km - (bak * 100) / ras;
                    mov = mov + (bak * 100) / ras;
                    Console.WriteLine("Проехал всего: " + mov + " Не доехал от нужного расстояния: " + proh);
                    Console.WriteLine("Для того, чтобы доехать до точки не хватает бензина: " + dop);
                    osh++;
                    do
                    {
                        Console.WriteLine("Если вы хотите заправить бак, то напишиту цифру 1, если нет - 2");
                        vibor = Convert.ToInt32(Console.ReadLine());
                        if (vibor == 1)
                        {
                            litr = float.Parse(Console.ReadLine());
                            mov = mov + (litr / ras * 100);
                            bak = bak + litr;
                            if (litr < dop)
                            {
                                dop -= litr;
                                proh = km - (bak * 100) / ras;
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
                    } while (nedos > 0);
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
        public void zapravka()
        {
            bak = bak + top;
            dop -= top;
            Console.WriteLine("Еще не хватает топлива: " + dop + " Всего в баке:" + bak);

        }
        public void ostatok()
        {
            proh = (km - bak * 100 / ras);
            Console.WriteLine("Проехал всего: " + mov + " Не доехал от нужного расстояния: " + proh);
        }
        public void move2()
        {
            int osh = 0;
            float time2 = 0;
            float time = 0;
            float speed = 80;
            float t = 0;
            do
            {
                osh = 0;
                mov = 0;
                proh = 0;
                Random rnd = new Random();
                km = rnd.Next(1000, 15000);
                time = km / speed;
                time2 = (ras * 4) / 5;
                t = time * time2;
                Console.WriteLine("Авто проехало:" + km);
                if (bak < t)
                {
                    osh++;
                    mov += bak * 100 / ras;
                    proh = (km - bak * 100 / ras);
                    Console.WriteLine(t);
                    dop = (float)Math.Round(t - bak, 2);
                    Console.WriteLine("Проехал всего: " + mov + " Не доехал от нужного расстояния: " + proh);
                    Console.WriteLine("Для того, чтобы доехать до точки не хватает бензина: " + dop);
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        Console.WriteLine("Если вы хотите заправить бак, то напишиту цифру 1, если нет - 2");
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.Y:
                                top = float.Parse(Console.ReadLine());
                                if (top < dop)
                                {
                                    zapravka();
                                    move2();
                                }
                                break;
                            case ConsoleKey.N:
                                ostatok();
                                break;
                        }
                       /* if (vibor == 1)
                        {
                            zapravka();
                            if (top >= dop)
                            {
                                osh--;
                            }
                            if 
                        }
                        else if (vibor == 2)
                        {
                            osh++;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели неправильное чисило или ввели букву.");
                        }*/

                }
                else
                {
                    mov += mov + km;
                }
            } while (osh == 0);
        }
        public void maxmove()
        {
            runaway += mov;
            Console.WriteLine(runaway);
            stopaway += km - proh;
            Console.WriteLine(stopaway);
        }
        public void accident()
        {
            int var = 0;
            Random rnd = new Random();

        }
    }
}
