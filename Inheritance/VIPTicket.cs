using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_3.Inheritance
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess;
        public decimal ServiceFee = 50;

        public VIPTicket(bool lounge,decimal service ,string movieName, decimal price) : base(movieName, price)
        {
            LoungeAccess = lounge;
            ServiceFee = service;
        }
        public override string ToString()
        {
            return $" id :{TicketId} | Movie Name :{MovieName} | Price :{Price} | Price After Tax {PriceAfterTax}" +
                $"Lounge Access :{LoungeAccess} | Service : {ServiceFee}";

        }
        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($" |  Lounge Access :{LoungeAccess}  | Service : {ServiceFee} EGP");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" |  Lounge Access :{LoungeAccess}  | Service : {ServiceFee} EGP");

        }
        public override Ticket Clone()
        {
            VIPTicket vIP = (VIPTicket)this.MemberwiseClone();
            return vIP;
        }
    }
}
