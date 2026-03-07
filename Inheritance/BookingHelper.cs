using G_NET_27_OOP_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_3.Inheritance
{
    internal class BookingHelper
    {

        public static void Helper(IPrintable[] printable) 
        {
            foreach (IPrintable item in printable)
            {
                if (item !=null)
                {
                    item.Print();
                }
            }
        
        }
    }
}
