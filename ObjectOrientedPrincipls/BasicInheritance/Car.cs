using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    public class Car
    {
        public int MaxSpeed { get; set; }
        public int MinSpeed { get; set; }

        private int _currentSpeed;

        public int Speed
        {
            get { return _currentSpeed; }
            set
            {
                _currentSpeed = value;
                if (_currentSpeed > MaxSpeed)
                {
                    _currentSpeed = MaxSpeed;
                }
            }
        }

        public Car()
        {
            MaxSpeed = 100;
            MinSpeed = 0;
        }

        public Car(int max)
        {
            MaxSpeed = max;
            MinSpeed = 0;
        }

        public Car(int max, int min)
        {
            MaxSpeed = max;
            MinSpeed = min;
        }

    }
}
