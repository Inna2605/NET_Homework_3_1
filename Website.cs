//Створіть клас «Веб-сайт». Необхідно зберігати у полях класу: назву сайту, шлях до сайту, опис сайту, ip-адресу сайту.
//Реалізуйте методи класу для введення даних, виведення даних. Реалізуйте доступ до окремих полів через методи класу. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_3_1
{
    internal class Website
    {
        private string _url;
        private string _title;
        private string _description;

        public Website(string name, string url, string description)
        {
            _title = name;
            _url = url;
            _description = description;
        }

        public void InputData(string title, string url, string description)
        {
            _title = title;
            _url = url;
            _description = description;
        }

        public void OutputData()
        {
            Console.WriteLine($"Назва сайту: {_title}");
            Console.WriteLine($"Шлях до сайту: {_url}");
            Console.WriteLine($"Опис сайту: {_description}");
        }
        public string SiteName 
        {
            get { return _title; }
            set { _title = value; }
        }
        public string SiteUrl 
        {
            get { return _url; }
            set { _url = value; }
        }
        public string SiteDescription 
        {
            get { return _description; }
            set { _description = value; }
        }         
    }
}
