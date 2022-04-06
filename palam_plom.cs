using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string computer_choice1, user_choice, computer_choice2;
            Random r = new Random();
            int scoruser = 0, scorcomputer1 = 0, scorcomputer2 = 0, index;

            string[] options = new string[2];
            options[0] = "palam";
            options[1] = "polom";
            for (int i = 0; i < 5; i++)
            {
                index = r.Next(0, 2);
                computer_choice1 = options[index];
                computer_choice2 = options[index];
                user_choice = Console.ReadLine();
                Console.WriteLine(computer_choice1);
                Console.WriteLine(computer_choice2);
                if (computer_choice1 == "palam " && computer_choice2 == "palam" && user_choice == "polom")
                {
                    scoruser++;
                }
                if (computer_choice1 == "polom " && computer_choice2 == "palam" && user_choice == "palam")
                {
                    scorcomputer1++;
                }
                if (computer_choice1 == "palam " && computer_choice2 == "polom" && user_choice == "palam")
                {
                    scorcomputer2++;
                }
                if (computer_choice1 == "polom " && computer_choice2 == "polom" && user_choice == "palam")
                {
                    scoruser++;
                }
                if (computer_choice1 == "palam " && computer_choice2 == "polom" && user_choice == "polom")
                {
                    scorcomputer1++;
                }
                if (computer_choice1 == "polom " && computer_choice2 == "palam" && user_choice == "polom")
                {
                    scorcomputer2++;
                }
                
            }
            if (scorcomputer1>scorcomputer2 && scorcomputer1> scoruser)
            {
                Console.WriteLine("computer_choice1 win");
            }
            if (scoruser > scorcomputer1 && scoruser > scorcomputer1)
            {
                Console.WriteLine("user_choice win");
            }
            if (scoruser > scorcomputer1 && scoruser > scorcomputer2)
            {
                Console.WriteLine("user_choice win");
            }
            if (scorcomputer2 > scorcomputer1 && scorcomputer2 > scoruser)
            {
                Console.WriteLine("computer_choice2 win");
            }

        }
        }
}
