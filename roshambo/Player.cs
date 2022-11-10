using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roshambo
{
    public abstract class Player 
    {
        public abstract string Name { get; }
        public abstract Roshambo Roshambo { get; }
        public abstract Roshambo GenerateRoshambo(int number);
        
    }
}
