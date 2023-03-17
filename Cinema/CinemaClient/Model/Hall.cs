using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClient.Model
{
    class Hall
    {
        public List<SeatRow> SeatRows{ get; set; }
        public Hall(int rowCount)
        {
            SeatRows = new List<SeatRow>(rowCount);
            int seatCount = 14;

            for (int i = 0; i < rowCount; i++)
            {
                SeatRows.Add(new SeatRow(i + 1, seatCount));
                seatCount -= 2;
            }
        }

    }
}
