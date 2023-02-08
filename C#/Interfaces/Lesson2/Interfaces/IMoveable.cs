using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Interfaces
{
    interface IMoveable
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public UInt16 MaxSpeed { get; set; }
        public void Move()
        {
            Console.WriteLine("Imoveable moves");
        }
    }
}
