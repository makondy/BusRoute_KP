using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Кр_2варіант_
{
    public interface ITicketOperations
    {
        void BookTicket(int count);    // Оформлення квитків
        void ReturnTicket(int count);  // Повернення квитків
    }

    public class Ticket : ITicketOperations
    {
        private int totalTicketsSold;

        public int TotalTicketsSold
        {
            get => totalTicketsSold;
            private set => totalTicketsSold = value;
        }

        public void BookTicket(int count)
        {
            TotalTicketsSold += count;
            Console.WriteLine($"{count} tickets booked successfully!");
        }

        public void ReturnTicket(int count)
        {
            if (count > TotalTicketsSold)
            {
                Console.WriteLine("Error: Not enough tickets sold to return!");
            }
            else
            {
                TotalTicketsSold -= count;
                Console.WriteLine($"{count} tickets returned successfully!");
            }
        }
    }
}
