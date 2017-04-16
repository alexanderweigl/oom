using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public enum Sensor
    {
        Speed,
        Temperature
    }
    class SensorCube
    {
        private Sensor type;
        private double value;

        public Sensor Type { get { return type; } }
        public double Value { get { return value; } }

        public SensorCube(Sensor type)
        {
            if(type == Sensor.Speed)
            {
                Random r = new Random();
                value = r.NextDouble() * (300 - 10) + 10;
                this.type = type;
            }
            if(type == Sensor.Temperature)
            {
                Random r = new Random();
                value = r.NextDouble() * (30 - 1) + 1;
                this.type = type;
            }
        }
    }
}
