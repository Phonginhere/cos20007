using System;

namespace CounterTask
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //declare object
            Counter[] myCounters = new Counter[3];
            //assign value
            myCounters[0] = new Counter("Counter 1");
            myCounters[1] = new Counter("Counter 2");
            myCounters[2] = myCounters[0];

            //loop i from 0 to 9, by using for loop
            for (int i = 0; i < 10; i++)
            {
                //call Increment method of Counter object at index 0
                myCounters[0].Increment();

            }
            //loop i from 0 to 14, by using for loop
            for (int i = 0; i < 10; i++)
            {
                //call Increment method of Counter object at index 1
                myCounters[1].Increment();

            }

            //tel MainClass to Print Counters, pass in counters
            PrintCounters(myCounters);

            //tell myCounters[2] to reset
            myCounters[2].Reset();

            //tel MainClass to Print Counters, pass in counters
            PrintCounters(myCounters);
        }


        private static void PrintCounters(Counter[] counters)
        {

            foreach (Counter c in counters)
            {
                Console.WriteLine("{0}, {1}", c.Name, c.Tick);
            }
        }
    }
}
