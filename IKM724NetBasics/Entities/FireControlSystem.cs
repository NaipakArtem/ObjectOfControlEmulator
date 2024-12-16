using IKM724NetBasics.Entities.Sensors;
using IKM724NetBasics.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities
{
    public class FireControlSystem
    {
        public List<Sensor> Sensors { get; set; }
        public IKM724NetBasics.Entities.Systems.FireSuppressionSystem FireSuppression { get; set; }

        public FireControlSystem()
        {
            Sensors = new List<Sensor>();
            FireSuppression = new IKM724NetBasics.Entities.Systems.FireSuppressionSystem();
        }

        public void Monitor()
        {
            bool fireDetected = false;

            foreach (var sensor in Sensors) 
            { 
                sensor.ReadValue(); 
                if((sensor.Type == Enums.SensorType.Temperature && sensor.Value >= Constants.SystemConstants.temperatureThreshold) || (sensor.Type == Enums.SensorType.Smoke && sensor.Value >= Constants.SystemConstants.smokeThreshold)){
                    fireDetected = true;
                }
            }

            if (fireDetected)
            {
                FireSuppression.TurnOn();
            }
            else
            {
                FireSuppression.TurnOff();
            }
        }
    }
}