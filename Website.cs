//Створіть клас «Веб-сайт». Необхідно зберігати у полях класу: назву сайту, шлях до сайту, опис сайту, ip-адресу сайту.
//Реалізуйте методи класу для введення даних, виведення даних. Реалізуйте доступ до окремих полів через методи класу. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NET_Homework_3_1
{
    internal class Website
    {
        public string SiteName { get; set; }
        public string SiteUrl { get; set; }
        public string SiteDescription { get; set; }

        public Website(string name, string url, string description)
        {
            SiteName = name;
            SiteUrl = url;
            SiteDescription = description;
        }

        public void InputData(string name, string url, string description)
        {
            SiteName = name;
            SiteUrl = url;
            SiteDescription = description;
        }

        public void OutputData()
        {
            Console.WriteLine($"Назва сайту: {SiteName}");
            Console.WriteLine($"Шлях до сайту: {SiteUrl}");
            Console.WriteLine($"Опис сайту: {SiteDescription}");
        }
                 
    }
}
