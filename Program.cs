using System;
using System.Collections.Generic;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine();

            int BankDifficulty;
            string userInput = "";

            void setBankDifficulty()
            {
                while (userInput == "")
                {
                    Console.Write("Please enter Bank Difficulty Level: ");
                    userInput = Console.ReadLine();
                }

                BankDifficulty = int.Parse(userInput);
            }

            setBankDifficulty();

            string memberName = "";
            int memberSkill = 0;
            double memberCourage = 0.0;
            int combinedSkills = 0;
            int teamLuck = new Random().Next(-11, 11);
            int BankDifficultyLevel = teamLuck + BankDifficulty;
            int trialRuns;
            int successfulRuns = 0;
            int failedRuns = 0;
            bool addNewMember = true;

            var memberList = new List<Member>();

            void createMember()
            {
                while (memberName == "")
                {
                    Console.Write("Please enter your name: ");
                    memberName = Console.ReadLine();
                }

                while (memberSkill == 0)
                {

                    Console.Write("Please enter your skill level (between 1 and 50): ");
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

                while (memberCourage == 0.0)
                {
                    Console.Write("Please enter your courage factor (between 0.0 and 2.0): ");
                    userInput = Console.ReadLine();
                    if (userInput == "")
                    {
                        memberCourage = 0.0;
                    }
                    else
                    {
                        memberCourage = double.Parse(userInput);
                    }
                }

                if (memberName != "" && memberSkill != 0 && memberCourage != 0.0)
                {
                    var newTeamMember = new Member(memberName, memberSkill, memberCourage);
                    memberList.Add(newTeamMember);
                    memberName = "";
                    memberSkill = 0;
                    memberCourage = 0;
                    Console.WriteLine();
                    Console.Write("Would you like to add a new member to the team? (Y/N): ");
                    Console.WriteLine();
                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "y")
                    {
                        addNewMember = true;
                    }
                    else
                    {
                        addNewMember = false;
                    }
                }
            }

            void createTeam()
            {
                var newTeam = new Team(memberList);
            }

            int setTrialRuns()
            {
                userInput = "";
                while (userInput == "")
                {
                    Console.WriteLine();
                    Console.Write("Please enter the number of trial runs you would like to perform: ");
                    userInput = Console.ReadLine();
                    Console.WriteLine();
                }
                return int.Parse(userInput);
            }

            int calculateCombinedSkills()
            {
                int skillsAddition = 0;
                foreach (var member in memberList)
                {
                    skillsAddition += member.SkillLevel;
                }
                return skillsAddition;
            }

            void calculateHeistResult(int difficultyLevel, int allTeamSkills)
            {
                Console.WriteLine("----Heist Trial Run----");
                Console.WriteLine($"Bank Difficulty: {difficultyLevel}");
                Console.WriteLine($"Team Skill Level: {allTeamSkills}");

                if (allTeamSkills >= difficultyLevel)
                {
                    Console.WriteLine("Yay, successfully robbed bank! :D");
                }
                else
                {
                    Console.WriteLine("Failed to rob bank! :(");
                }
            }

            void RunHeist()
            {

                combinedSkills = calculateCombinedSkills();

                for (int i = 0; i < trialRuns; i++)
                {
                    teamLuck = new Random().Next(-11, 11);
                    BankDifficultyLevel = teamLuck + BankDifficulty;
                    if (combinedSkills >= BankDifficultyLevel)
                    {
                        successfulRuns++;
                    }
                    else
                    {
                        failedRuns++;
                    }

                    calculateHeistResult(BankDifficultyLevel, combinedSkills);

                }
                combinedSkills = 0; // reset the combined skills of team members prior to each trial run
            }

            void createHeistReport()
            {
                Console.WriteLine();
                Console.WriteLine("----------Heist Report----------");
                Console.WriteLine($"Number of successful runs: {successfulRuns}");
                Console.WriteLine($"Number of failed runs: {failedRuns}");
            }


            while (addNewMember)
            {
                createMember();
            }

            createTeam();
            trialRuns = setTrialRuns();
            RunHeist();
            createHeistReport();
        }
    }
}



