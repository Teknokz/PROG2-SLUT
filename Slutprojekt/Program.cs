using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Medans gameActive = 1 så är spelet igång

            int gameActive = 1;
            
            int userguess = 0;

            System.Console.WriteLine("Vad heter du?");

            string n = Console.ReadLine();

            //Skapar instansen Court som tar n och skriver ut välkommen... + n

            Court newCourt = new Court(n);

            // Denna while loopen körs medans gameactive == 1 (Ganeactive blir 0 när spelaren förlorat eller vunnit)

            while(gameActive == 1)
            {

            System.Console.WriteLine("Hur vill du gå tillväga?");
            System.Console.WriteLine("1) Lägga till fler brott i brottslagret");
            System.Console.WriteLine("2) Åklaga för följande brott");

            string input = Console.ReadLine();
            
            bool success = int.TryParse(input, out userguess);

            //Om userguess == 1 så körs instasen och tillåter spelaren att lägga till fler brott

            if(userguess == 1)
            {
                
                Console.Clear();

                Crime laws = new Crime();

                System.Console.WriteLine("1");
                System.Console.WriteLine("Vilket brott vill du lägga till?");

                input = Console.ReadLine(); 

                Crime.crimes.Add(input);

                System.Console.WriteLine("Added " + input);

            }

            //Om userguess å andra sidan är == 2 så fortsätter spelet...

            else if(userguess == 2)
            {
                System.Console.WriteLine("2");

                 //Crime newCrime = new Crime();

            }   

            }
            

            



            Console.ReadLine();
        }
    }
}
