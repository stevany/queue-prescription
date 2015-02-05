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
    public partial class Form3 : Form
    {
        Context _ctx = new Context();
      
        public Form3()
        {
            InitializeComponent();
          

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            load();
        }

        
        void load()
        {
            var resep = from n in _ctx.FmUser select n;
            fmUserDataGridView.DataSource = resep.ToList();

        }

        private void fmUserDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(fmUserDataGridView[0, fmUserDataGridView.CurrentRow.Index].Value);
            var query= from u in _ctx.FmUser where u.UserId.Equals(id) select u;
            foreach (var u in query)
            {
                txtUserId.Text = u.UserId.ToString();
                txtUserName.Text = u.UserName.ToString();
                txtPassword.Text = EncryptorEngine.Decrypt(u.Password, true);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string clearText = txtPassword.Text.Trim();
            FmUser fmUser = new FmUser
            {
                UserName = txtUserName.Text.Trim(),
                Password = EncryptorEngine.Encrypt(clearText, true),
                Role=chkRole.Checked
            };
            _ctx.FmUser.Add(fmUser);
            _ctx.SaveChanges();
            load();
        }

      
    }
}
