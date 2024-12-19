using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claw_Machine
{
    public class Reward
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public Reward (string name, decimal value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return $"{Name} - value of {Value:c}";
        }
    }
}
