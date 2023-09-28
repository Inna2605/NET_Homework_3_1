//Створіть клас «Веб-сайт». Необхідно зберігати у полях класу: назву сайту, шлях до сайту, опис сайту, ip-адресу сайту.
//Реалізуйте методи класу для введення даних, виведення даних. Реалізуйте доступ до окремих полів через методи класу. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NET_Homework_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Website MySite = new Website("My Site", "http://www.mysite.com", "Це мій власний веб-сайт");

            Console.WriteLine("Початкові дані сайту:");
            MySite.OutputData();
            Console.WriteLine();

            MySite.InputData("Нова назва", "http://www.newsite.com", "Опис нового сайту");
            Console.WriteLine("Змінені дані сайту:") ;
            MySite.OutputData();
            Console.ReadLine();
        }
    }
}
