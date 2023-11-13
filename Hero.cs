using System;
using System.Reflection.Metadata.Ecma335;


namespace dotnetcore
{
    public class Hero : Character, ISkills, IHealthSkills
    {
        // Klasa tworzy obiekt (np. Postaci tak jak w tym przypadku oraz kilka funkcji które posiada ta postać )
        

        // Funkcja Szczedgólne tylko dla postaci Hero dlatego jest w klasie 
        public void Speak(){
            Console.WriteLine("Bohater mówi");
        }

        // Fukcje pobrane z Interfejsu a nastepnie zaimplementowana
        

        public void Go(){
            Console.WriteLine("Bohater Idzie");
        }
        
        public void Attack(){
            Console.WriteLine("Bohater mówi");
        }
        public void Leczenie(){
            Console.WriteLine("Bohater leczy złamania");
        }
    }

    public class HeroKid : Hero
    {
        public void Placz(){
            Console.WriteLine("Dziecko płacze");
        }
    }
}