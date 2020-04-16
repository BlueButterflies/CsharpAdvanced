using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tires
    {
        private double pressure;
        private int age;

        public Tires(double perssure, int age)
        {
            this.Perssure = perssure;
            this.Age = age;
        }

        public double Perssure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
