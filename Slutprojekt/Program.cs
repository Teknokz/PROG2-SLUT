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

            Lawyers myLawyer = new Lawyers();

            System.Console.WriteLine("Vad heter advokaten?");

            string n = Console.ReadLine();

            myLawyer.name = n;

            System.Console.WriteLine("Du har valt namnet" + n);

            while(gameActive == 1)
            {

                Console.Clear();

            System.Console.WriteLine("Hur vill du gå tillväga?");
            System.Console.WriteLine("1) Lägga till fler brott i brottslagret");
            System.Console.WriteLine("2) Åklaga för följande brott");
            System.Console.WriteLine("3) Lägga till Kunskap");

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

            else if(userguess == 3)
            {
                
                Console.Clear();

                System.Console.WriteLine("Hur mycket knowledge vill du lägga till?");

                input = Console.ReadLine();

                int.TryParse(input, out userguess);

                myLawyer.addKnowledge(userguess);

                System.Console.WriteLine("Du har nu " + myLawyer.Knowledge + " Knowledge");

                System.Threading.Thread.Sleep(1000);

                
            }

            }
            

            



            Console.ReadLine();
        }
    }
}
