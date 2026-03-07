using G_NET_27_OOP_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_3.Inheritance
{
    internal class Ticket : IPrintable , IBooking_ICancellatoin , ICloneable<Ticket>
    {

        public bool IsBooked { get; private set; } = false;
        public string MovieName { get; set; }
        public int TicketId { get;  }
		protected private decimal _price;
        private static int _counter = 0;
        private decimal _tax = 0.14m;

        public Ticket(string movieName,  decimal price)
        {
            _counter++;
            MovieName = movieName;
            _price = price;
            TicketId = _counter;           
        }

        public decimal Price
		{
			get { return _price; }

			set {
				if(value > 0)
				  _price = value;     
			}
		}

        public void SetPrice(decimal price) 
        { 
            _price= price;
        
        }

        public void SetPrice(decimal baseprice, decimal Multiplier)
        {
           _price = baseprice * Multiplier;
        }

        public decimal PriceAfterTax => _price + (_price * _tax);


        public override string ToString()
        {
            return $" id :{TicketId} | Movie Name :{MovieName} | Price :{_price} | Price After Tax {PriceAfterTax}";

        }

        public static int GetTotalTicket()
        {
            return _counter;
        }

        public virtual void PrintTicket() 
        {
            Console.WriteLine($"TicketId : {TicketId} | Movie Name : {MovieName} |  Price : {Price}  | Price After Tax : {PriceAfterTax}" );
        }

        public virtual void Print()
        {
         
            Console.WriteLine($"TicketId : {TicketId} | Movie Name : {MovieName} |  Price : {Price}  | Price After Tax : {PriceAfterTax}  |" +
                $" Status :  {(IsBooked ? "Booked " : "Not Yet")}");

        }

        public bool Book()
        {
            if (IsBooked) 
            {
                Console.WriteLine($"Ticket : {TicketId} Is Already Booked");
                return false;
            }
            IsBooked = true;
            Console.WriteLine($"Ticket : {TicketId} booked successfully");
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked)
            {
                Console.WriteLine($"Ticket: {TicketId} is not booked yet");
                return false;
            }
            IsBooked = false;
            Console.WriteLine($"Ticket : {TicketId} cancelled successfully");
            return true;
        }

        public virtual Ticket Clone()
        {
          Ticket ticket = (Ticket) this.MemberwiseClone();
           return ticket;
        }
    }
}
