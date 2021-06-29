using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoftechead
{
  
    class Auto
    {
        private String model;
        private float capacity;
        private float fuel;
        private float consumption;

        public Auto(string model, float capacity, float fuel, float consumption)
        {
            this.model = model ?? throw new ArgumentNullException(nameof(model));
            this.capacity = capacity;
            this.fuel = fuel;
            this.consumption = consumption;
        }

        public String getModel()
        {
            return this.model;
        }

        public float getCapacity()
        {
            return this.capacity;
        }

        public float getFuel()
        {
            return this.fuel;
        }

        public float getConsumption()
        {
            return this.consumption;
        }
    }

}
