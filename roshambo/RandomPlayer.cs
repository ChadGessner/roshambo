using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo
{
    public class RandomPlayer : Player
    {
        public override string Name { get; }
        public override Roshambo Roshambo { get; }
        public Random random = new Random();
        public RandomPlayer(string name)
        {
            Name = name;
            Roshambo = GenerateRoshambo(random.Next(0,3));
        }
        public override Roshambo GenerateRoshambo(int number)
        {
            return (Roshambo)number;
        }
    }
}
