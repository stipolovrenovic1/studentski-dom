using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class RoomRepository
    {      

        public List<Room> GetRooms()
        {
            List<Room> lRooms = new List<Room>();

            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM lovrenovic_Rooms";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lRooms.Add(new Room()
                        {
                            Id = (int)reader["Id"],
                            RoomNumber = (int)reader["RoomNumber"],
                            Floor = (int)reader["Floor"],
                            StudentNumber = (int)reader["StudentNumber"],
                            MaxStudents = (int)reader["MaxStudents"]
                        });
                    }
                }
            }

            return lRooms;
        }
        
        public List<Room> GetAvailableRooms()
        {
            List<Room> lAvailableRooms = new List<Room>();
            var rooms = GetRooms();

            lAvailableRooms = rooms.Where(x => x.StudentNumber < x.MaxStudents).ToList();

            return lAvailableRooms;
        }

        public void CreateRoom(Room oRoom)
        {
            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO lovrenovic_Rooms (FLOOR, ROOMNUMBER, STUDENTNUMBER, MAXSTUDENTS) VALUES ('" + oRoom.Floor + "','" + oRoom.RoomNumber + "','" + oRoom.StudentNumber + "','" + oRoom.MaxStudents + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void DeleteRoom(Room oRoom)
        {
            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";         

            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM lovrenovic_Rooms WHERE Id = " + oRoom.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }        
        }

        public void EditRoom(Room oRoom)
        {
            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE lovrenovic_Rooms SET ROOMNUMBER = " + oRoom.RoomNumber + ", FLOOR = " + oRoom.Floor + ", MAXSTUDENTS = " + oRoom.MaxStudents + " WHERE ID = " + oRoom.Id;
                //oCommand.CommandText = "UPDATE lovrenovic_Students SET FIRSTNAME = " + oStudent.FirstName + ", LASTNAME = " + oStudent.LastName + ", OIB = " + oStudent.OIB + ", COURSE = " + oStudent.Course + ", YEAR = " + oStudent.Year + " WHERE ID = " + oStudent.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }

        }
    }
}
