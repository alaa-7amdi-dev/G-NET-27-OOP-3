using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_3.Inheritance
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string seat,string movieName , decimal price ) : base( movieName, price)
        {
            SeatNumber = seat;
        }

        public override string ToString()
        {
            return $" id :{TicketId} | Movie Name :{MovieName} | Price :{Price} | Price After Tax {PriceAfterTax}" +
                $"| Seat Number :{SeatNumber}";

        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($" Seat Number : {SeatNumber}");
        }

    }
}
