using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClient.Model
{
    class Seat
    {
        public Seat(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
