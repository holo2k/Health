using System;

namespace Health
{
    class Health
    {
        private int temperature;
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value < 34)
                    temperature = 34;
                if (value > 41)
                    temperature = 41;
                else temperature = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Health Health = new Health();
            Health.Temperature = 55;
            Console.WriteLine(Health.Temperature + " (В коде задано число > 41)");
            Health.Temperature = 36;
            Console.WriteLine(Health.Temperature);
        }
    }
}
