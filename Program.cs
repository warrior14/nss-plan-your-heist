using System;
using System.Collections.Generic;


namespace BankHeist 
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine();

            int BankDifficulty;
            string userInput = "";


            void setBankDifficulty()
            {
                while(userInput == "")
                {
                    Console.WriteLine("Please enter bank difficulty level: ");
                    userInput = Console.ReadLine();
                }

                BankDifficulty = int.Parse(userIput);
            }

            setBankDifficulty();


            string memberName = "";
            int memberSkill = 0;
            double memberCourage = 0.0;
            int combinedSkills = 0;
            int teamLuck = new Random().Next(-11, 11);
            int bankDifficultyLevel = teamLuck + BankDifficulty;
            int trialRuns; 
            int successfulRuns = 0;
            int failedRuns = 0;
            bool addNewMember = true;

            var memberList = new List<memberList>();

            void createMember()
            {
                while (memberName == "")
                {
                    Console.Write("Please enter your name: ");
                    memberName = Console.ReadLine();
                    {
                        while (memberSkill == 0)
                        {
                            Console.Write("Please enter your skill level between (1 and 50)");
                            userInput = Console.ReadLine();
                            if (userInput == "") 
                            {
                                memberSkill = 0;
                            }
                            else 
                            {
                                memberSkill = int.Parse(userInput);
                            }
                        }

                        while (memberCourage == 0.0 )
                        {
                            Console.Write("Please enter your courage factor (between 0.0 and 2.0)");
                            userInput = Console.ReadLine();
                            if (userInput == "")
                            {
                                memberCourage
                            }
                        }
                    }
                }
            }
        }
    }
}