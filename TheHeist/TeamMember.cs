using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace TheHeist
{
    class TeamMember
    {
        public string Name { get; set; } = "";
        public int SkillLevel { get; set; } = 0;
        public decimal CourageFactor { get; set; } = 0;

        public TeamMember()
        {
            do
            {
                Console.WriteLine("Enter in the team member's name.");
                var name = Console.ReadLine();
                if (name == "")
                {
                    return;
                }
                else
                {
                    Name = name;
                }
            } while (Name == "");

            Console.WriteLine("Enter in the team member's skill level.");
            var skillLevel = Console.ReadLine();
            SkillLevel = Convert.ToInt32(skillLevel);
            Console.WriteLine("Enter in the team member's courage factor.(This should be between 0.0 and 2.0)");
            var courageFactor = Console.ReadLine();
            CourageFactor = Convert.ToDecimal(courageFactor);
            DisplayInfo();
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Team Member Name: {Name}");
            Console.WriteLine($"Skill Level: {SkillLevel}");
            Console.WriteLine($"Courage Factor: {CourageFactor}");
        }
    }
}
