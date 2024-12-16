using IKM724NetBasics.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Sensors
{
    public class SmokeSensor : Sensor
    {
        public override SensorType Type => SensorType.Smoke;

        public SmokeSensor(string name, string description)
            : base (name, description){}

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 100;
            Console.WriteLine($"{Name} Smoke Level: {Value} %");
        }
    }
}