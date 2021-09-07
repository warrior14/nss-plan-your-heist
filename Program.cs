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
                        while (userInput = "")
                        {
                            Console.WriteLine();
                            Console.Write("Please enter the number of trial runs you would like to perform: ");
                            userInput = Console.ReadLine();
                            Console.WriteLine();
                        }
                        return int.Parse(userInput);
                    }

                    int calculatedCombinedSkills()
                    {
                        int skillsAddition = 0;
                        foreach (var member in memberList)
                        {
                            skillAddition += member.SkillLevel;
                        }
                        return skillsAddition += member.SkillLevel;
                    }

                    void calculateHeistResult(int difficulty, int allTeamSkills)
                    {
                        Console.WriteLine("=====Trial Runs====");
                        Console.WriteLine($"Bank Difficulty: {difficultyLevel}");
                        Console.WriteLine($"Team Skill Level: {allTeamSkills}");
                    }
                    else 
                    {
                        Console.WriteLine("Failed to rob bank!");
                    }
                }

                void RunHeist()
                {
                    combinedSkills = calculateCombinedSkills();

                    for (int i = 0; i < trialRuns; i++)
                    {
                        teamLuck = new Random().Next(-11, 11);
                        BankDifficultyLevel = teamLuck + BankDifficulty;
                        if (combinedSkills >= BankDifficulty)
                        {
                            successfulRuns++;
                        }
                        else 
                        {
                            failedRuns++;
                        }


                        calculateHeistResult(BankDifficultyLevel, combinedSkills);
                    }
                }
            }
        }
    }
}