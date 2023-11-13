using System;
using System.Reflection.PortableExecutable;
using dotnetcore;

namespace dotnetcore
{
    public class Ghost : Character, ISkills
    {
        // Umiejętność specyficzna tylko dla Ducha
        public void Fly(){
            Console.WriteLine("Duch lata");
        }

        // Umiejętności globalne
        public void Go(){
            Console.WriteLine("Duch idzie");
        }
        public void Attack(){
            Console.WriteLine("Duch Atakuje");
        }
    }
}