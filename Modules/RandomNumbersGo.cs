using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma_216273.Modules
{
    public class RandomNumbersGo
    {
        private double randomFloat = 0;
        private int randomInt = 0;
        public RandomNumbersGo() { }

        private static readonly Random _random = new Random();

        public static int GetRandomInt(int min, int max)
        {
            var random = new RandomNumbersGo();
            random.randomInt = _random.Next(min, max);
            return random.randomInt;
        }

        public static double GetRandomDouble()
        {
            RandomNumbersGo random = new RandomNumbersGo();
            random.randomFloat = _random.NextDouble();
            return random.randomFloat;
        }
    }
}
