using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            bool ProgramContinues = true;
            while (ProgramContinues == true)
            {

                int userInput;
                Console.WriteLine("Please enter a number");

                userInput = int.Parse(Console.ReadLine());
                Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed");



                for (int i = 1; i <= userInput; i++)
                {
                    Console.WriteLine(i + "\t" + (i * i) + "\t" + (i * i * i));
                }

                string userChoice;
                Console.WriteLine("Do you want to continue?");
                userChoice = Console.ReadLine();

                if (userChoice == "no" || userChoice == "No")

                {
                    ProgramContinues = false;
                }


                



            }














        }
    }
}
