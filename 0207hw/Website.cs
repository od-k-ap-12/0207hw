using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207hw
{
    class Website
    {
        private string name;
        private string path;
        private string description;
        private string ip;
        public override string ToString()
        {
            return "Website name: " + name + "\nPath: " + path + "\nWebsite description: " + description + "\nIP: " + ip;
        }
        public string Name //prop
        {
            get => name;
            set => name = value;
        }
        public string Path //prop
        {
            get => path;
            set => path = value;
        }
        public string Description //prop
        {
            get => description;
            set => description = value;
        }
        public string IP //prop
        {
            get => ip;
            set => ip = value;
        }
        public Website() { }
        public Website(string _name, string _path, string _description, string _ip)
        {
            name = _name;
            path = _path;
            description = _description;
            ip = _ip;
        }
        public void Print()
        {
            Console.Write("Website name: " + name + "\nPath: " + path + "\nWebsite description: " + description + "\nIP: " + ip);
        }

        public void Input()
        {
            Console.WriteLine("Enter shop name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            path = Console.ReadLine();
            Console.WriteLine("Enter shop description: ");
            description = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            ip = Console.ReadLine();
        }
    }
}
