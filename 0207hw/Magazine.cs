using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207hw
{
    class Magazine
    {
        private string name;
        private int year;
        private string description;
        private string phone;
        private string email;
        public override string ToString()
        {
            return "Shop name: " + name + "\nYear of foundation: " + year + "\nShop description: " + description + "\nPhone: " + phone + "\n E-mail: " + email;
        }
        public string Name //prop
        {
            get => name;
            set => name = value;
        }
        public int Year //prop
        {
            get => year;
            set => year = value;
        }
        public string Description //prop
        {
            get => description;
            set => description = value;
        }
        public string Phone //prop
        {
            get => phone;
            set => phone = value;
        }
        public Magazine() { }
        public Magazine(string _name, int _year, string _description, string _phone, string _email)
        {
            name = _name;
            year = _year;
            description = _description;
            phone = _phone;
            email = _email;
        }
        public void Print()
        {
            Console.Write("Magazine name: " + name + "\nYear of foundation: " + year + "\nMagazine description: " + description + "\nPhone: " + phone + "\n E-mail: " + email);
        }

        public void Input()
        {
            Console.WriteLine("Enter shop name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter shop description: ");
            description = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            phone = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            email = Console.ReadLine();
        }
    }
}
