using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string comp_choi, user_choice;
            Random r = new Random();
            int scoruser = 0, scorcom = 0, index;

            string[] options = new string[3];
            options[0] = "rock";
            options[1] = "paoer";
            options[2] = "scissor";
            for (int i = 0; i < 5; i++)
            {
               index = r.Next(0, 3);
                comp_choi = options[index];
                user_choice = Console.ReadLine();
                Console.WriteLine(comp_choi);

                if (comp_choi == "paper " && user_choice == "rock")
                {
                    scorcom++;
                }

                
                 else if (user_choice == "paper " &&  comp_choi== "rock")
                {
                    scoruser++;
                }

                else if (comp_choi == "scissor " && user_choice == "rock")
               {
                    scoruser++;
                }

                else if (user_choice == "scissor " && comp_choi == "rock")
                {
                    scorcom++;
                }
                else if (user_choice == "scissor " && comp_choi == "paper")
                {
                    scoruser++;
                }
                else if (comp_choi == "scissor " && user_choice == "paper")
                {
                    scorcom++;
                }
                else if (comp_choi == "scissor " && user_choice == "scissor")
                {
                    scorcom++;
                    scoruser++;
                }
                else if (comp_choi == "paper " && user_choice == "paper")
                {
                    scorcom++;
                    scoruser++;
                }
                else if (comp_choi == "rock " && user_choice == "rock")
                {
                    scorcom++;
                    scoruser++;
                }
              


            }
            if(scoruser>scorcom)
            {
                Console.WriteLine("you win");
            }
            else if(scoruser < scorcom)
            {
                Console.WriteLine("computer win");
            }
            else
            {
                Console.WriteLine("=");

            }
        }
    }
}
