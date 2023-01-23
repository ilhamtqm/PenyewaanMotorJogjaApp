using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenyewaanMotorJogjaApp.Model.Context;
using PenyewaanMotorJogjaApp.Model.Repository;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using PenyewaanMotorJogjaApp.Model.Entity;

namespace PenyewaanMotorJogjaApp.Controller
{
    public class UserController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private UserRepository _repository;
        //Method untuk ngecek username dan password di database
        public bool Attempt(string username, string password)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                //memanggil  collection
                List<User> list = new List<User>();
                // membuat objek class repository
                _repository = new UserRepository(context);
                // panggil method ReadAttempt class repository untuk menambahkan data
                result = _repository.ReadAttempt(username, password);
                
            }


            if (result == 0)
                MessageBox.Show("Username dan Password tidak ditemukan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result == 1;
        }
        //Method untuk membuat collection
        public List<User> GetNama(string username)
        {
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new UserRepository(context);
                // panggil method GetNama class repository untuk menambahkan data
                return _repository.GetNama(username);

            }

        }
    }
}