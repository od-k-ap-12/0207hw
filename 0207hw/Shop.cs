using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0207hw
{
    class Shop
    {
        private string name;
        private string address;
        private string description;
        private string phone;
        private string email;
        public override string ToString()
        {
            return "Shop name: " + name + "\nAddress: " + address + "\nShop description: " + description + "\nPhone: " + phone + "\n E-mail: " + email;
        }
        public string Name //prop
        {
            get => name;
            set => name = value;
        }
        public string Address //prop
        {
            get => address;
            set => address = value;
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
        public string Email //prop
        {
            get => email;
            set => email = value;
        }
        public Shop() { }
        public Shop(string _name, string _address, string _description, string _phone, string _email)
        {
            name = _name;
            address = _address;
            description = _description;
            phone = _phone;
            email = _email;
        }
        public void Print()
        {
            Console.Write("Shop name: " + name + "\nAddress: " + address + "\nShop description: " + description + "\nPhone: " + phone + "\n E-mail: "+email);
        }

        public void Input()
        {
            Console.WriteLine("Enter shop name: ");
            name=Console.ReadLine();
            Console.WriteLine("Enter address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter shop description: ");
            description = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            phone = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            email = Console.ReadLine();
        }
    }
}
