using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class UserRepository
    {
        public List<User> GetUsers()
        {
            List<User> lUsers = new List<User>();

            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM lovrenovic_Users";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lUsers.Add(new User()
                        {
                            Id = (int)reader["Id"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            Username = (string)reader["Username"],
                            Password = (string)reader["Password"],
                            EmailAdress = (string)reader["EmailAdress"]                                                    
                        });
                    }
                }
            }

            return lUsers;
        }

        public void DeleteUser(User oUser)
        {
            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM lovrenovic_Users WHERE Id = " + oUser.Id;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void AddUser(User oUser)
        {
            string connectionString = @"Server=193.198.57.189; Initial Catalog = DOTNET2019; User ID = student; Password = stu!2019neT";
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO lovrenovic_Users (FIRSTNAME, LASTNAME, USERNAME, PASSWORD, EMAILADRESS) VALUES ('" + oUser.FirstName + "','" + oUser.LastName + "','" + oUser.Username + "','" + oUser.Password + "','" + oUser.EmailAdress + "')";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
    }
}
