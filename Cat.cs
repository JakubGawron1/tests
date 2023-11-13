using System;
using System.Reflection.PortableExecutable;

namespace dotnetcore
{
    public class Cat : Character, ISkills, IHealthSkills
    {
        public void Drap(){
            Console.WriteLine("Kot drapie");
        }
        public void Go(){
            Console.WriteLine("Kot idzie ");

        }
        public void Attack(){
            Console.WriteLine("Kot Atakuje");
        }

        public void Leczenie(){
            Console.WriteLine("Kot sie leczy");
        }
    }
}