using antrianFM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrianFM
{
    public partial class Form5 : Form
    {
        string usr;
        bool rl;
        int lantai;
        public Form5(string UserName, bool Role, int lt)
        {

            InitializeComponent();
            lblUser.Text = UserName;
            utilityToolStripMenuItem.Enabled = Role;
            usr = UserName;
            rl = Role;
            lantai = lt;
        }

        private void inputAntrianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(usr, rl, lantai);
            form1.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void viewInputAntrianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}
