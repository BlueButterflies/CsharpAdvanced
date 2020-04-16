using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double Distance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumpPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumpPerKm;
        }

        public void CalcolletedTravelledDistance(double amountOfKm)
        {
            if (amountOfKm * this.FuelConsumptionPerKilometer <= this.FuelAmount)
            {
                this.FuelAmount -= amountOfKm * this.FuelConsumptionPerKilometer;

                this.Distance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.Distance}";
        }
    }
}
