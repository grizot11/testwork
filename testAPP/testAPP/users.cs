using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAPP
{
    class users
    {
        public struct User
        {
            public string name;
            public string year;

        }
        public static string connectionString = @"Data Source=DESKTOP-NCDJAS8\SQLEXPRESS;Initial Catalog=testWS;Integrated Security=True";

        public static List<User> Get()
        {
            var userList = new List<User>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"SELECT films.Name, films.Year, info.Descp FROM films INNER JOIN info ON films.Type = info.Type";
                SqlCommand command = new SqlCommand(sql, connection);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.name = reader[0].ToString();
                    user.year = reader[1].ToString();
                    user.year = reader[1].ToString();
                    userList.Add(user);
                }
            }
            return userList;
        }
    }
}
