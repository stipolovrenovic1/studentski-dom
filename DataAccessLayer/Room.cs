using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class Room
    {
        public int Id { get; set; }

        public int RoomNumber { get; set; }

        public int Floor { get; set; }

        public int StudentNumber { get; set; }

        public int MaxStudents { get; set; }
    }
}
