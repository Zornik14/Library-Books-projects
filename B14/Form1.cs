using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void autoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unos_Autora ua = new Unos_Autora();
            ua.Show();
            this.Hide();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void poAutorimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Po_autorima po = new Po_autorima();
            po.Show();
            this.Hide();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
            this.Hide();
        }
    }
}
