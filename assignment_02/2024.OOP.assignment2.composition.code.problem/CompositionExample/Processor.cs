using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExample
{
    internal class Processor
    {
        public int clockSpeed;
        public Processor(int Clockspeed) 
        { 
            this.clockSpeed = Clockspeed;
        }

        public void StartUp()
        {
            Console.WriteLine("Starting the processor...");
        }
    }
}
