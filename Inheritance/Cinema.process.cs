using G_NET_27_OOP_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_3.Inheritance
{
    internal partial class Cinema
    {

        public void printAll()
        {
            Console.WriteLine($"Cinema Name : {CinemaName}");
            bool found = false;
            foreach (var t in _ticket)
            {
                if (t != null)
                {
                    t.PrintTicket();
                    found = true;
                }
                if (!found)
                {
                    Console.WriteLine("Ticket not added yet");
                }

            }

        }
       
        public static void ProcessTicket(Ticket ticket)
        {
            if (ticket == null)
            {
                throw new ArgumentNullException(nameof(ticket));
            }
            ticket.PrintTicket();
        }

        public void PrintInfo()
        {

            Console.WriteLine($"Cinema Name :{CinemaName} -- All Tickets");

            foreach (var item in _ticket)
            {
                if (item != null)
                {
                    IPrintable printable = item;
                    printable.Print();
                }

            }

        }
    }
}
