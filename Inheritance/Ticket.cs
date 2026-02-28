using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_3.Inheritance
{
    internal class Ticket
    {

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

        public decimal PriceAfterTax => _price + (_price * _tax);

        public override string ToString()
        {
            return $" id :{TicketId} | Movie Name :{MovieName} | Price :{_price} | Price After Tax {PriceAfterTax}";

        }

        public static int GetTotalTicket()
        {
            return _counter;
        }
    }
}
