using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_3.Inheritance
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; private set; }


        public IMAXTicket(bool is3d, string movieName, decimal price) : base(movieName, price)
        {
			Is3D=is3d;
            if (is3d)
                Price += 30;
        }

        public override string ToString()
        {
            return $" id :{TicketId} | Movie Name :{MovieName} | Price :{Price} | Price After Tax {PriceAfterTax}";

        }


    }
}