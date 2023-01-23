using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using PenyewaanMotorJogjaApp.Model.Entity;
using PenyewaanMotorJogjaApp.Model.Repository;
using PenyewaanMotorJogjaApp.Model.Context;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PenyewaanMotorJogjaApp.Model.Repository
{
    public class UserRepository
    {
        private SQLiteConnection _conn;
        public UserRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int ReadAttempt(string username, string password)
        {

            var result = 0;
            string sql = @"SELECT username,password,nama FROM User WHERE username=@username AND password=@password";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                       
                        result++;
                    }
                }
                return result;
            }
        }

        public List<User> GetNama(string username)
        {
            var result = new List<User>();
            string sql = @"SELECT * FROM User WHERE username=@username";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        var user = new User();
                        user.Username = dtr["username"].ToString();
                        user.Nama = dtr["nama"].ToString();
                        user.Password = dtr["password"].ToString();
                        result.Add(user);
                    }
                }
            }
            return result;
        }


    }
}