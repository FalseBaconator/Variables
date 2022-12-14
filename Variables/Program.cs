using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");
            Console.WriteLine();

            //Variables
            //Integers
            int score; //Declared
            score = 0; //Initialization
            int enemyPoints; //Declared
            enemyPoints = 100; //Init 100 points per kill
            Console.WriteLine("Score: " + score); //Display
            //score = 1000000; //Change
            score = score + enemyPoints; //Change killed 1 enemy
            Console.WriteLine("Score: " + score); //Display
            Console.WriteLine();

            //Floating Points (decimals)
            float lapTime; //Declare
            lapTime = 0.0f; //Init
            Console.WriteLine("Time: " + lapTime); //Display
            lapTime = 65.357f; //Change
            Console.WriteLine("Time: " + lapTime); //Display
            Console.WriteLine();

            //Strings of text
            string title; //Declared
            title = "Rookie"; //Initt
            Console.WriteLine("Title: " + title); //Display
            title = "Slightly Skilled Rookie"; //Change
            Console.WriteLine("Title: " + title); //Display
            Console.WriteLine();

            Console.ReadKey(true);

        }
    }
}
