using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_3.Inheritance
{
    internal class Cinema
    {
        public string? CinemaName { get; set; }
        private Projector _projector { get; set; }
        public Ticket[] _ticket = new Ticket[20];

        public Cinema(string? cinemaName)
        {
            CinemaName = cinemaName;
            _projector = new();
        }

        public bool AddTicket(Ticket ticket)
        {
            for (int i = 0; i < _ticket.Length; i++)
            {
                if (_ticket[i] == null)
                {
                    _ticket[i] = ticket;
                    return true;
                }
            }
            return false;
        }

        public void printAll()
        {
            Console.WriteLine($"Cinema Name : {CinemaName}");
            foreach (var t in _ticket)
            {
                if (t != null)
                {
                    Console.WriteLine(t.ToString());
                }
                Console.WriteLine("Ticket not added yet");
            }

        }
        public void OpenCinema() 
        {
            Console.WriteLine($"==============Cinema Opened=============");
            _projector.Start();
        }
        public void CloseCinema() 
        {
            Console.WriteLine($"==============Cinema Closed================");
            _projector.Stop();
        }
    }


}

