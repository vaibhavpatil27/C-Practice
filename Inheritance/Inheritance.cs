using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface IName
    {
        void displayname(string a);
    }
    interface ILocation
    {
        void displaylocation(string b);
    }
    interface IAge
    {
        void displayage(string c);
    }
    class user : IName, ILocation, IAge
    {
        public void displayname(string a)
        {
            Console.WriteLine("Name : " + a);
        }
        public void displaylocation(string b)
        {
            Console.WriteLine("Location : " + b);
        }
        public void displayage(string c)
        {
            Console.WriteLine("Age : " + c);
        }
    }
}

