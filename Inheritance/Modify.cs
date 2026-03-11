using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_3.Inheritance
{
    internal static class Modify
    {
        public static string GetFormettedReceipt(this Ticket ticket) 
        {
            return $@" 
              TicketeId : {ticket.TicketId}  
              MOVIE NAME : {ticket.MovieName}
              price : {ticket.Price}
              Final price : {ticket.PriceAfterTax}
              Status : Booked
                        ";
        }

        public static decimal GetTotalRevenue(this Ticket[] tickets)
        {
            return tickets.Sum(t => t.Price);
        }
    }
}
