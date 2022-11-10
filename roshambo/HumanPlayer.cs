using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo
{
    public class HumanPlayer : Player
    {
        public override string Name {get;}
        public override Roshambo Roshambo { get; }
        public HumanPlayer(string name)
        {
            Name = name;
        }
        public HumanPlayer(int roshambo)
        {
            Roshambo = GenerateRoshambo(roshambo);
        }
        public HumanPlayer(string name, int roshambo)
        {
            Name = name;
            Roshambo = GenerateRoshambo(roshambo);
        }
        public override Roshambo GenerateRoshambo(int number)
        {
            return (Roshambo)number;
        }
    }
}
