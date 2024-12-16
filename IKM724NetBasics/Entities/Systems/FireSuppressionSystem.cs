using IKM724NetBasics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Systems
{
    public class FireSuppressionSystem : IControllable
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Fire suppression system activated.");
        }
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Fire suppression system deactivated.");

        }
    }
}
