using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OIB { get; set; }

        public string Course { get; set; }

        public int Year { get; set; }

        public int RoomId { get; set; }
    }
}
