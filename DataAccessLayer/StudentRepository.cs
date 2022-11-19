using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class StudentRepository
    {
        private RoomRepository _roomRepository = new RoomRepository();

        public List<Student> GetStudents()
        {
            List<Student> lStudents = new List<Student>();

            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM lovrenovic_Students";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lStudents.Add(new Student()
                        {
                            Id = (int)reader["Id"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            OIB = (string)reader["OIB"],
                            Course = (string)reader["Course"],
                            Year = (int)reader["Year"],
                            RoomId = (int)reader["RoomId"]
                        });
                    }
                }
            }
            return lStudents;
        }

        public List<StudentRoomless> GetRoomlessStudents()
        {
            List<StudentRoomless> lStudentsRoomless = new List<StudentRoomless>();

            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM lovrenovic_StudentsRoomless";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lStudentsRoomless.Add(new StudentRoomless()
                        {
                            Id = (int)reader["Id"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            OIB = (string)reader["OIB"],
                            Course = (string)reader["Course"],
                            Year = (int)reader["Year"]                       
                        });
                    }
                }
            }
            return lStudentsRoomless;
        }

        public List<Student> GetRoomStudents(int Id)
        {
            List<Student> lRoomStudents = new List<Student>();
            var lStudents = GetStudents();

            lRoomStudents = lStudents.Where(x => x.RoomId == Id).ToList();

            return lRoomStudents;
        }

        public void MoveIntoRoom(StudentRoomless oStudent, int Id)
        {
            var rooms = _roomRepository.GetRooms();        
            var newRoom = rooms.Where(x => x.Id == Id).First();
            int newAmount = newRoom.StudentNumber + 1;

            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO lovrenovic_Students VALUES ('" + oStudent.FirstName + "','" + oStudent.LastName + "','" + oStudent.OIB + "','" + oStudent.Course + "','" + oStudent.Year + "','" + Id + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE lovrenovic_Rooms SET StudentNumber= " + newAmount + " WHERE Id = " + Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }

            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM lovrenovic_StudentsRoomless WHERE Id = " + oStudent.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void MoveOut(Student oStudent, int Id)
        {
            var rooms = _roomRepository.GetRooms();

            var oldRoom = rooms.Where(x => x.Id == Id).First();
            int newAmount = oldRoom.StudentNumber - 1;

            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO lovrenovic_StudentsRoomless VALUES ('" + oStudent.FirstName + "','" + oStudent.LastName + "','" + oStudent.OIB + "','" + oStudent.Course + "','" + oStudent.Year + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }

            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE lovrenovic_Rooms SET StudentNumber= " + newAmount + " WHERE Id = " + Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }

            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM lovrenovic_Students WHERE Id = " + oStudent.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void Transfer(Student oStudent, int newId)
        {
            int oldId = oStudent.RoomId;
            
            var rooms = _roomRepository.GetRooms();          

            var oldRoom = rooms.Where(x => x.Id == oldId).First();
            int newOldAmount = oldRoom.StudentNumber - 1;

            var newRoom = rooms.Where(x => x.Id == newId).First();
            int newNewAmount = newRoom.StudentNumber + 1;

            oStudent.RoomId = newRoom.Id;

            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE lovrenovic_Students SET RoomId = " + oStudent.RoomId  + " WHERE Id = " + oStudent.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }

            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE lovrenovic_Rooms SET StudentNumber = " + newOldAmount + " WHERE Id = " + oldRoom.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }

            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE lovrenovic_Rooms SET StudentNumber = " + newNewAmount + " WHERE Id = " + newRoom.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        
        public void EditStudent(Student oStudent)
        {
            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE lovrenovic_Students SET FIRSTNAME = '" + oStudent.FirstName + "', LASTNAME = '" + oStudent.LastName + "', OIB = '" + oStudent.OIB + "', COURSE = '" + oStudent.Course + "', YEAR = " + oStudent.Year + " WHERE ID = " + oStudent.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void EditRoomlessStudent(StudentRoomless oStudent)
        {
            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE lovrenovic_StudentsRoomless SET FIRSTNAME = '" + oStudent.FirstName + "', LASTNAME = '" + oStudent.LastName + "', OIB = '" + oStudent.OIB + "', COURSE = '" + oStudent.Course + "', YEAR = " + oStudent.Year + " WHERE ID = " + oStudent.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void MoveOutRoomStudents(int roomId)
        {
            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";

            var students = GetRoomStudents(roomId);

            foreach (Student student in students)
            {
                using (DbConnection oConnection = new SqlConnection(connectionString))
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "DELETE FROM lovrenovic_Students WHERE Id = " + student.Id;
                    oConnection.Open();
                    using (DbDataReader oReader = oCommand.ExecuteReader())
                    {

                    }
                }

                using (DbConnection oConnection = new SqlConnection(connectionString))
                using (DbCommand oCommand = oConnection.CreateCommand())
                {
                    oCommand.CommandText = "INSERT INTO lovrenovic_StudentsRoomless (FIRSTNAME, LASTNAME, OIB, COURSE, YEAR) VALUES ('" + student.FirstName + "','" + student.LastName + "','" + student.OIB + "','" + student.Course + "'," + student.Year + ")";
                    oConnection.Open();
                    using (DbDataReader oReader = oCommand.ExecuteReader())
                    {

                    }
                }

            }
        }

        public void NewStudent(StudentRoomless oStudent)
        {
            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO lovrenovic_StudentsRoomless (FIRSTNAME, LASTNAME, OIB, COURSE, YEAR) VALUES ('" + oStudent.FirstName + "','" + oStudent.LastName + "','" + oStudent.OIB + "','" + oStudent.Course + "','" + oStudent.Year + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void DeleteStudent(Student oStudent)
        {
            int idRoom = oStudent.RoomId;
            var rooms = _roomRepository.GetRooms();
            int newAmount = rooms.Where(x => x.Id == idRoom).Select(x => x.StudentNumber).First() - 1;

            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM lovrenovic_Students WHERE Id = " + oStudent.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }

            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "UPDATE lovrenovic_Rooms SET StudentNumber = '" + newAmount + "' WHERE Id = " + idRoom;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void DeleteRoomlessStudent(StudentRoomless oStudent)
        {
            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM lovrenovic_StudentsRoomless WHERE Id = " + oStudent.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }       
        }
    }
}
