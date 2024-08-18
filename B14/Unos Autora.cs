using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B14
{
    public partial class Unos_Autora : Form
    {
        public Unos_Autora()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void radioButton2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButton2.Checked)
            {
                button1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                dateTimePicker1.Enabled = false;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void radioButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            button2.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("AutorID", textBox1.Text);
            parameters.Add("Ime", textBox2.Text);
            parameters.Add("Prezime", textBox3.Text);
            parameters.Add("DatumRodjenja", dateTimePicker1.Value);
            Konekcija.newTableRecord("dbo.Autor", parameters);
            MessageBox.Show("Uspesno ste uneli Autora!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source = DESKTOP-R0GJOHE\SQLEXPRESS;initial Catalog=B14;Integrated Security = SSPI;Connect Timeout =30; Encrypt = False;TrustServerCertificate = False;ApplicationIntent =ReadWrite;MultiSubnetFailover = False";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand("DELETE FROM Autor WHERE AutorID= '" + textBox1.Text + "'", conn);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Autor je uspesno obrisan!");
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
        }
        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}