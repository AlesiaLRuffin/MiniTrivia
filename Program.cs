using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTrivia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mini Trivia
            Console.WriteLine("Let's play trivia");
            Console.WriteLine("The categories are 'Food' 'Music' and 'Sports'\nPick a category");

            string inputC = Console.ReadLine();

            switch (inputC)
            {
                case "Food":
                    Console.WriteLine("What savoury pudding is traditionally served on Robert 'Rabbie' Burns night?");
                    string foodAnswer = "Haggis";
                    string inputF = Console.ReadLine();
                    if (inputF.Equals(foodAnswer))
                    { Console.WriteLine("Correct, You are a real Foodie!"); }
                    else
                    { Console.WriteLine("The correct answer is Haggis, that was a tough question."); }
                      Console.ReadLine();
                    
                    break;

                case "Music":
                    Console.WriteLine("Who wrote and performed the song 'Sometimes it Snows in April'?");
                    string musicAnswer = "Prince";
                    string inputM = Console.ReadLine();
                    if (inputM.Equals(musicAnswer))
                    { Console.WriteLine("Wow, You really know music!"); }
                    else
                    { Console.WriteLine("Sorry that answer is incorrect, I hope you don't call yourself a Prince fan, LOL!"); }
                      Console.ReadLine();
                    break;

                case "Sports":
                    Console.WriteLine("What sport has the fastest, hardest ball, clocked at 188 miles per hour?");
                    string sportsAnswer = "Jai Alai";
                    string inputS = Console.ReadLine();
                    if (inputS.Equals(sportsAnswer))
                    { Console.WriteLine("Right you are!"); }
                    else
                    { Console.WriteLine("No worries,this is an obscure sport that most people don't know about"); }
                      Console.ReadLine();
                    break;
            }
        }
    }
}     
