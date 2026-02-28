using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_3.Inheritance
{
    internal class Projector
    {
        public bool IsRunning { get; private set; }

        public void Start()
        { 
          IsRunning = true;
            Console.WriteLine("Projector Started.");
         
        }

        public void Stop() 
        { 
            IsRunning = false;
            Console.WriteLine("Projector Stoped.");
                
        }
    }
}
