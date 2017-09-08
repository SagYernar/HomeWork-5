using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызывайте по очереди
            //First();
            Second();
        }

        static void First()
        {
            //1.	Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка. 
            //Программа должна завершиться без ошибок.

            string adress;
            try
            {
                WebClient webClient = new WebClient();

                adress = "http://www.microsoft.com";
                Console.WriteLine(adress);
                webClient.DownloadString(adress); //этот будет доступен
                Console.WriteLine("Существует");

                adress = "http://www.цicrosoft.com";
                Console.WriteLine(adress);
                webClient.DownloadString(adress); //этот будет доступен
                Console.WriteLine("Существует");
            }
            catch (Exception)
            {
                Console.WriteLine("Не существует");
            }
            Console.ReadLine();
        }

        static void Second()
        {
            //2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. 
            //После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.

            const int size = 5;
            int[] array = new int[size] { 101, 202, 303, 404, 505 };
            int overSize = size + 1;

            try
            {
                for (int i = 0; i < overSize + 1; i++)
                {
                    Console.WriteLine("{0} - {1}", i, array[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Вы вышли заграницы массива");
            }
            Console.ReadLine();
        }
    }
}
