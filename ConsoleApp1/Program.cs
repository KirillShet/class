using ConsoleApp1;
using System.Data;
using System.Net.Http.Headers;

class programm
{
    static void Main()
    {
        Avto[] cars = new Avto[5];
        for (int i = 0; i< cars.Length; i++)
        {
            cars[i] = new Avto();
            cars[i].info();
            cars[i].output();
        }
    }
    static void rastoin()
    {
        Avto car = new Avto();
        /*do
        {

        }
        while () ;*/
    }
}