using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClient.Model
{
    class SeatRow
    {
        public int id;

        public List<Seat> Seats { get; set; }
        public SeatRow(int id, int seatCount)
        {
            this.id = id;
            Seats = new(seatCount);
            
            for (int i = 0; i < seatCount; i++)
            {
                Seats.Add(new(i));
            }
        }
    }
}
