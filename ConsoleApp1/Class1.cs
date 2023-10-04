using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Avto
    {
        private string nom;
        public float bak;
        public float ras;
        public float speed;
        public float vrem;
        public float top;
        public int km;
        private int vibor;
        private float dop;
        public float mov = 0;
        private float proh;
        private float runaway;
        private float stopaway;
        public float time;
        private float ac;
        private float ca;
        public float scor;
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
        public void move2()
        {
            int osh = 0;
            int nedos = 0;
            float time2 = 0;
            float time = 0;
            scor = 80;
            float t = 0;
            do
            {
                osh = 0;
                mov = 0;
                proh = 0;
                vrem = 0;
                Random rnd = new Random();
                km = rnd.Next(1000, 15000);
                time = km / scor;
                time2 = (ras * 4) / 5;
                t = (float)Math.Round((time + float.Parse("0,002778")) * time2, 2);
                Console.WriteLine("Авто проехало:" + km);
                if (bak < t)
                {
                    osh++;
                    mov += (float)Math.Round((bak / time2) * scor, 2);
                    proh = (float)Math.Round((km - ((bak / time2) * scor)), 2);
                    vrem = (float)Math.Round((bak / time2) * scor, 2);
                    Console.WriteLine(t);
                    dop = (float)Math.Round(t - bak, 2);
                    Console.WriteLine("Проехал всего: " + mov + " Не доехал от нужного расстояния: " + proh);
                    Console.WriteLine("Для того, чтобы доехать до точки не хватает бензина: " + dop);
                    do
                    {
                        Console.WriteLine("Если вы хотите заправить бак, то напишиту цифру 1, если нет - 2");
                        vibor = Convert.ToInt32(Console.ReadLine());
                        if (vibor == 1)
                        {
                            top = float.Parse(Console.ReadLine());
                            if (top >= dop)
                            {
                                nedos = 0;
                                bak = (float)Math.Round(bak + top, 2);
                                osh--;
                            }
                            else if (top < dop)
                            {
                                nedos++;
                                dop = (float)Math.Round(dop - top, 2);
                                mov += (float)Math.Round((top / time2) * scor, 2);
                                proh = (float)Math.Round((km - ((bak / time2) * scor + (top/ time2) * scor)), 2);
                                Console.WriteLine("Осталось проехать до конца пути: " + proh + " Нехватает топлива: " + dop);
                                bak = (float)Math.Round(bak + top, 2);
                                vrem+= (float)Math.Round((top / time2) * scor, 2);
                            }
                        }
                        else if (vibor == 2)
                        {
                            Console.WriteLine("Вы проехали:" + mov + " До конечной точки осталось: " + proh);
                            nedos = 0;
                            osh++;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели неправильное чисило или ввели букву.");
                        }
                    } while (nedos > 0);
                }
                else
                {
                    mov += mov + km;
                    bak -= t;
                    Console.WriteLine("Осталось бензина: " + bak);
                }
            } while (osh == 0);
        }
        public void boost()
        {
            time = float.Parse("0,0025");
            ac = scor / time;
            ac = (float)Math.Round(ac * (float)Math.Pow(time, 2) * 1000, 0);
            Console.WriteLine("Расстояние, потраченное на ускорение: " + ac); 
        }

        public void braking()
        {
            time = float.Parse("0,00825");
            ca = scor / time;
            ca = (float)Math.Round(ca * (float)Math.Pow(time, 2)* 1000, 0);
            Console.WriteLine("Расстояние, потраченное на торможение: " +ca);
        }
        public void maxmove()
        {
            runaway = mov;
            Console.WriteLine("Проехал всего: " + runaway);
            stopaway = vrem; 
            Console.WriteLine("Расстояние от начальной до конечной точки: " + stopaway);
        }
        public void accident()
        {
            int var = 0;
            Random rnd = new Random();

        }
    }
}
