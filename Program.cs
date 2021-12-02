using System;
using System.Collections;
using System.Collections.Generic;

namespace Heist_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var lockPickingLawwyer = new LockSpecialist();
            var arnoldMuscle = new Muscle();
            var mrRobotTheHacker = new Hacker();

            var juniorLock = new LockSpecialist();
            var arnoldJuniorMuscle = new Muscle();
            var newFromMIT = new Hacker();

            var rolodex = new List<IRobber>()
            {
                lockPickingLawwyer, arnoldMuscle, mrRobotTheHacker, juniorLock, arnoldJuniorMuscle, newFromMIT
            };

            string newName = "m";

            while (newName != "")
            {
                if (newName == "")
                {
                    return;
                }

                Console.WriteLine($"Number of operatives in the rolodex:  {rolodex.Count}");

                Console.Write("Enter The Name of the new Crew Member:");


                newName = Console.ReadLine();


                Console.WriteLine(@$"
            1) Hacker( Disable alarms)
            2)Muscle( Disarms guards)
            3) Lock Specialist( Cracks vault)
            ");

                Console.WriteLine($"Choose your Operative's Class:");

                int newClassChoice = int.Parse(Console.ReadLine());

                Console.Write($"Enter your Operatives Skill Level (0-100):");

                int newSkillLevel = int.Parse(Console.ReadLine());

                Console.Write($"Enter your Operatives Percentange Cut (0-100):");

                int newPercentage = int.Parse(Console.ReadLine());






                IRobber newOperative;
                if (newClassChoice == 1)
                {
                    newOperative = new Hacker()
                    {
                        Name = newName,
                        SkillLevel = newSkillLevel,
                        percentageCut = newPercentage
                    };
                    rolodex.Add(newOperative);
                }

                else if (newClassChoice == 2)
                {
                    newOperative = new Muscle()
                    {
                        Name = newName,
                        SkillLevel = newSkillLevel,
                        percentageCut = newPercentage
                    };
                    rolodex.Add(newOperative);
                }

                else if (newClassChoice == 3)
                {
                    newOperative = new LockSpecialist()
                    {
                        Name = newName,
                        SkillLevel = newSkillLevel,
                        percentageCut = newPercentage
                    };
                    rolodex.Add(newOperative);
                }
            }




            var bank = new Bank()
            {
                CashOnHand = new Random().Next(50000, 1000000),
                AlarmScore = new Random().Next(0, 100),
                VaultScore = new Random().Next(0, 100),
                SecurityGuardScore = new Random().Next(0, 100)

            };

            if (bank.AlarmScore > bank.VaultScore)
            {
                Console.WriteLine($"Most Secure: Alarm");
                Console.WriteLine($"Least Secure: Vault");
            }

            else if (bank.VaultScore > bank.AlarmScore)

            {
                Console.WriteLine($"Most Secure: Vault");
                Console.WriteLine($"Least Secure: Alarm");
            }


            //rolodex report
            int index = 0;
            foreach (var rolodexes in rolodex)
            {
                Console.WriteLine($"Name: {rolodexes.Name}");
                Console.WriteLine($"Skill Level:{rolodexes.SkillLevel}");
                Console.WriteLine($"Percentage Cut: {rolodexes.percentageCut}");
                Console.WriteLine($"INDEX: {index++}");
            }

            var crew = new List<IRobber>()
            {

            };

            string selectingOperative = "m";
            while (selectingOperative != "")
            {

                Console.Write($"Enter the index of Operative: ");
                selectingOperative = Console.ReadLine();

                try
                {

                    crew.Add(rolodex[Convert.ToInt32(selectingOperative)]);


                    foreach (var crewOperative in crew)
                    {
                        if (crewOperative.Name == crewOperative.Name)
                        {
                            Console.WriteLine("user already exists");
                            Console.WriteLine($"Name: {crewOperative.Name}");
                            Console.WriteLine($"Skill Level:{crewOperative.SkillLevel}");
                            Console.WriteLine($"Percentage Cut: {crewOperative.percentageCut}");
                        }

                        else if (crewOperative.percentageCut > 45)
                        {
                            Console.WriteLine("");
                        }
                    }

                }

                catch (FormatException)
                {
                    Console.WriteLine("No INDEX Was entered");
                }
            }




        }
    }
}

