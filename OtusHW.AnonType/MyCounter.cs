using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW.AnonType
{
    internal class MyCounter
    {
        private int counter = 0;

        public int Value { get { return counter; } }

        public void Increment() { counter++; }
        public void Reset() { counter = 0; }
    }
}
