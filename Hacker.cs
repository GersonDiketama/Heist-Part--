using System;
using System.Collections.Generic;

namespace Heist_Part_2
{
    public class Hacker : IRobber


    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int percentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - SkillLevel;

            Console.WriteLine($"Mr.{Name} is hacking the alarm system. Decreased security {SkillLevel}");

            if (bank.AlarmScore == 0)
            {
                Console.WriteLine($"Mr.{Name} has disabled the alarm system!");
            }
        }
    }
}