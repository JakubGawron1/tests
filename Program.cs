using System;


namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero zenek = new Hero();
            Ghost duszek = new Ghost();
            Cat kotek = new Cat();
            HeroKid herokid = new HeroKid();

            // Funkcje z klasy dostępne dla postaci bez względu kim jest i co robi
            zenek.Zyje();
            duszek.Zyje();
            kotek.Zyje();
            herokid.Zyje();

           // Klasa HeroKid implementuje te same fukcje co klasa Hero
           herokid.Attack();
           // a także własne funkcje
           herokid.Placz();
            // Funkcje z interfacu
            zenek.Attack();
            zenek.Go();
            kotek.Attack();
            kotek.Go();
            duszek.Attack();
            duszek.Go();
            zenek.Leczenie();
            // Funkcje specyficzne
            zenek.Speak();
            duszek.Fly();
            kotek.Drap();
        }
    }


}
