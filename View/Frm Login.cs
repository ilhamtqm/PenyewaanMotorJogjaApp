using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using System.Runtime.Serialization;
using PenyewaanMotorJogjaApp.Controller;
using PenyewaanMotorJogjaApp.Model.Entity;
using PenyewaanMotorJogjaApp.Model.Context;
using System.Xml.Linq;

namespace PenyewaanMotorJogjaApp.View
{
    public partial class Login : Form
    {
        private FrmTransaksiBaru form = new FrmTransaksiBaru();
        private UserController _controller = new UserController();
        public Login()
        {
            InitializeComponent();
            Username.Text = "A1";
            Password.Text = "123";
            Username.TextChanged += new EventHandler(Username_TextChanged);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTransaksiBaru frm = new FrmTransaksiBaru();
            string user = Username.Text;
            string pass = Password.Text;
            if (_controller.Attempt(user, pass))
            {
                using (DbContext context = new DbContext())
                {

                    UserController usercontroller = new UserController();
                    string nama = Username.Text;
                    List<User> ambil = usercontroller.GetNama(nama);
                    if (ambil.Count > 0)
                    {
                        foreach (var item in ambil)
                        {
                            User.TampungNama = item.Nama;
                            FrmTransaksiBaru form = new FrmTransaksiBaru();
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
