using System;
using System.Collections.Generic;

namespace Heist_Part_2
{
    public interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int percentageCut { get; set; }

        void PerformSkill(Bank bank);
    }
}