using System;
using System.Collections.Generic;
using System.Text;

namespace BearAdapter
{
    class BrownBear : IBear
    {
        public bool Hibernating { get; set; }
        private Random rnd;

        public void Roar()
        {
            if (!Hibernating) Console.WriteLine("RAAAAAAAAAAWWWWWWWRRRYYYYYY");
            else Console.WriteLine("ZZZZzzzzzzzz(yyyy)~~~");
        }
        
        public void LookAt(object objectToLookAt)
        {
            if (!Hibernating) Console.WriteLine($"Bear looks menacingly at " +
                $"{objectToLookAt} ! ! !");
        }

        public void GoTowards(object objectToWalkTowards)
        {
            if (!Hibernating) Console.WriteLine($"Bear walks menacingly" +
                $"towards {objectToWalkTowards} ! ! !");
            else Console.WriteLine("Bear rolls over...");
        }

        public bool TryEat(object objectToEat)
        {
            if (!Hibernating && rnd.NextDouble() < 0.7)
            {
                Console.WriteLine("Bites za fisho ! ! !");
                return true;
            }
            else if (!Hibernating && rnd.NextDouble() > 0.7)
            {
                Console.WriteLine("Wwwwrrrryyyyyyyyyyy ! ! !");
                return false;
            }
            else
            {
                Console.WriteLine("ZZZZZZzzzzzzzzzz(yyyyyy) . . .");
                return false;
            }
        }

        public BrownBear(bool hibernating = false)
        {
            Hibernating = hibernating;
            rnd = new Random();
        }
    }
}
