using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo
{
    public class RockPlayer : Player
    {
        public override string Name { get; }
        public override Roshambo Roshambo { get; }
        public RockPlayer(string name)
        {
            Name = name;
            Roshambo = GenerateRoshambo(1);
        }
        public override Roshambo GenerateRoshambo(int number)
        {
            return (Roshambo)number;
        }

    }
}
