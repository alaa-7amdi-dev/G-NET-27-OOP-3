using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_3.Interfaces
{
    internal interface IBooking_ICancellatoin
    {
        public bool  IsBooked { get; }
        bool Book();
        bool Cancel();
    }
}
