using antrianFM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrianFM
{
    public partial class Form4 : Form
    {
        Context _ctx = new Context();
        int lt;
        public Form4()
        {
            InitializeComponent();
            string file = Path.GetFullPath("config.ini");
            IniFile inif = new IniFile(file);
            lt = Convert.ToInt32(inif.Read("lantai", "nilai"));
            Console.WriteLine(lt);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ok();
        }
        void ok()
        {
            var query = (from u in _ctx.FmUser where u.UserName.Equals(txtUserName.Text.Trim()) select u).FirstOrDefault();

            string pass = EncryptorEngine.Decrypt(query.Password, true);
            bool success = pass.Equals(txtPassword.Text.Trim()) ? true : false;
            if (success)
            {

                Form5 form5 = new Form5(query.UserName, query.Role, lt);
                form5.Show();
                this.Hide();



            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ok();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtPassword.Focus();
            }
        }
    }
}
