using PenyewaanMotorJogjaApp.Controller;
using PenyewaanMotorJogjaApp.Model.Entity;
using PenyewaanMotorJogjaApp.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PenyewaanMotorJogjaApp.View
{
    public partial class FrmMotor : Form
    {
        private MotorController _controllermotor = new MotorController();
        public FrmMotor()
        {
            InitializeComponent();
        }
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            var motor = new Motor
            {
                NoPolisi = textNamaMotor.Text,
                MerekMotor = textMerekMotor.Text,
                WarnaMotor = textWarna.Text,
                NoMesin = textMesin.Text,
                Harga = textRangka.Text.ToString(),
                ThnProduksi = textProduksi.Text,
                Status = textStatus.Text,
            };
            int result = _controllermotor.Create(motor);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil ditambahkan !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var motor = new Motor
            {
                NoPolisi = labelNoPolisi.Text,
                MerekMotor = textMotorUp.Text,
                WarnaMotor = textWarnaUp.Text,
                NoMesin = textMesinUp.Text,
                Harga = textRangkaUp.Text,
                ThnProduksi = textProduksiUp.Text,
                Status = textStatusUp.Text,
            };
            int result = _controllermotor.Update(motor);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil diUpdate !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
                textMotorUp.Select();
            }
            else
            {
                MessageBox.Show("Data gagal di Update !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ClearTextBox()
        {
            textMotorUp.Clear();
            textWarnaUp.Clear();
            textWarna.Clear();
            textMesinUp.Clear();
            textRangkaUp.Clear();
            textProduksiUp.Clear();
            textStatusUp.Clear();
            textStatusDell.Clear();
            textNamaMotor.Clear();
            textMerekMotor.Clear();
            textMesin.Clear();
            textRangka.Clear();
            textProduksi.Clear();
            textStatus.Clear();
        }
        private void buttonCari_Click(object sender, EventArgs e)
        {

            string name = textCari.Text;
            List<Motor> foundCustomers = _controllermotor.CariMotor(name);
            if (foundCustomers.Count > 0)
            {
                dataGridView1.DataSource = foundCustomers;
                foreach (var item in foundCustomers)
                {
                    //update
                    labelNoPolisi.Text = item.NoPolisi.ToString();
                    textMotorUp.Text = item.MerekMotor.ToString();
                    textWarnaUp.Text = item.WarnaMotor.ToString();
                    textMesinUp.Text = item.NoMesin.ToString();
                    textRangkaUp.Text = item.Harga.ToString();
                    textProduksiUp.Text = item.ThnProduksi.ToString();
                    textStatusUp.Text = item.Status.ToString();

                    //delete
                    labelNoPolisiDell.Text = item.NoPolisi.ToString();
                    textMotorDell.Text = item.MerekMotor.ToString();
                    textWarnaDell.Text = item.WarnaMotor.ToString();
                    textMesinDell.Text = item.NoMesin.ToString();
                    textRangkaDell.Text = item.Harga.ToString();
                    textProduksiDell.Text = item.ThnProduksi.ToString();
                    textStatusDell.Text = item.Status.ToString();

                }
            }
            else
            {
                MessageBox.Show("Tidak ditemukan customer dengan nama " + name, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            groupBoxcari.Visible = false;
            groupBoxcari.SendToBack();
            groupBoxcari.Enabled = false;
            groupBoxCreate.Visible = true;
            groupBoxCreate.Enabled = true;
            groupBoxEntityUp.Visible = false;
            groupBoxEntityDell.Visible = false;
            ClearTextBox();
            groupBoxCreate.BringToFront();
        }
        private void groupBoxEntityUp_Enter(object sender, EventArgs e)
        {

        }
        private void EntityMotorgroupBox_Enter(object sender, EventArgs e)
        {

        }
        private void buttonUpt_Click(object sender, EventArgs e)
        {

        }
        private void FrmMotor_Load(object sender, EventArgs e)
        {

        }
        private void buttonUpt_Click_1(object sender, EventArgs e)
        {
            ClearTextBox();
            dataGridView1.DataSource = _controllermotor.ReadAllMotor();
            groupBoxcari.Enabled = true;
            groupBoxcari.Visible = true;
            groupBoxcari.BringToFront();
            groupBoxCreate.Visible = false;
            groupBoxCreate.Enabled = false;
            groupBoxEntityUp.Visible = true;
            groupBoxEntityUp.Enabled = true;
            groupBoxEntityUp.BringToFront();
            dataGridView1.Visible = true;
            dataGridView1.BringToFront();
            groupBoxEntityDell.Visible = false;

        }
        private void btnDell_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            buttonCariDell.Enabled = true;
            buttonCariDell.Visible = true;
            buttonCari.Visible = false;
            buttonCari.SendToBack();
            buttonCari.Enabled = false;
            dataGridView1.DataSource = _controllermotor.ReadAllMotor();
            groupBoxCreate.Visible = false;
            groupBoxCreate.Enabled = false;
            groupBoxEntityUp.Visible = true;
            groupBoxEntityUp.Enabled = true;
            groupBoxEntityDell.Visible = true;
            groupBoxEntityDell.Enabled = true;
            groupBoxEntityDell.BringToFront();
            dataGridView1.Visible = true;
            dataGridView1.BringToFront();
            groupBoxEntityDell.Visible = true;
            groupBoxEntityDell.BringToFront();
            groupBoxEntityDell.BringToFront();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var motor = new Motor
            {
                NoPolisi = labelNoPolisiDell.Text,
                MerekMotor = textMotorDell.Text,
                WarnaMotor = textWarnaDell.Text,
                NoMesin = textMesinDell.Text,
                Harga = textRangka.Text.ToString(),
                ThnProduksi = textProduksiDell.Text,
                Status = textStatusDell.Text,
            };
            int result = _controllermotor.Delete(motor);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil Dihapus !", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();

                textMotorUp.Select();
            }
            else
            {
                MessageBox.Show("Data gagal di Update !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void buttonCariDell_Click(object sender, EventArgs e)
        {
            string name = textCari.Text;
            List<Motor> foundCustomers = _controllermotor.CariMotor(name);
            if (foundCustomers.Count > 0)
            {
                dataGridView1.DataSource = foundCustomers;
                foreach (var item in foundCustomers)
                {
                    //update
                    labelNoPolisi.Text = item.NoPolisi.ToString();
                    textMotorUp.Text = item.MerekMotor.ToString();
                    textWarnaUp.Text = item.WarnaMotor.ToString();
                    textMesinUp.Text = item.NoMesin.ToString();
                    textRangkaUp.Text = item.Harga.ToString();
                    textProduksiUp.Text = item.ThnProduksi.ToString();
                    textStatusUp.Text = item.Status.ToString();

                    //delete
                    labelNoPolisiDell.Text = item.NoPolisi.ToString();
                    textMotorDell.Text = item.MerekMotor.ToString();
                    textWarnaDell.Text = item.WarnaMotor.ToString();
                    textMesinDell.Text = item.NoMesin.ToString();
                    textRangkaDell.Text = item.Harga.ToString();
                    textProduksiDell.Text = item.ThnProduksi.ToString();
                    textStatusDell.Text = item.Status.ToString();

                }
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            this.Close();
        }

        private void buttonBatalDell_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            this.Close();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            this.Close();
        }
    }
}
