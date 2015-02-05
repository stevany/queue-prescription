using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace antrianFM
{
    public partial class Form1 : Form
    {
       Context _ctx = new Context();
       string usr, conn, nomor, noResep;
       
       bool rl, racikan;
       int lantai; 
        public Form1(string UserName, bool Role, int lt)
        {
            InitializeComponent();
            lblUser.Text = UserName;
            usr = UserName;
            rl = Role;
            lantai = lt;
            racikan = false;
            conn = "Data Source=10.1.0.1;Initial Catalog=his;User ID=sa;Password=";
            dataGridView1.Columns[1].Width = 300;
            txtNoResep.ReadOnly=true;
          

        }

        void readNumber(string nama, string connectionString)
        {
            string query ;
          
            query = " select PrescriptionNo, firstName from transPrescription t inner join registration r on t.registrationNo=r.registrationNo " +
                    " inner join patient p on r.patientId=p.patientId where firstName like '" + nama + "%' and  CONVERT(VARCHAR, prescriptiondate, 112) = CONVERT(VARCHAR, GETDATE(), 112) " +
                    " and left(prescriptionno,3)='rso'";
           
            SqlConnection c = new SqlConnection(connectionString);
               
            
            SqlCommand command = new SqlCommand(query, c);
            c.Open();
            Console.WriteLine(query);
            SqlDataReader reader = command.ExecuteReader();
            List<Receipt> list = new List<Receipt>();    
             
            while (reader.Read())
            {
                list.Add(new Receipt { NoResep = reader["PrescriptionNo"].ToString(), Pasien = reader["firstName"].ToString() });
                noResep=reader["PrescriptionNo"].ToString();
            }
            c.Close();
            dataGridView2.DataSource = list;
            dataGridView2.Columns[0].Width =120;
            dataGridView2.Columns[1].Width = 300;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            save();
            
        }
        void save()
        {
            string query;

            query = " select isRFlag from transPrescriptionItem  where prescriptionno='" + noResep + "'";

            SqlConnection c = new SqlConnection(conn);


            SqlCommand command = new SqlCommand(query, c);
            c.Open();

            SqlDataReader reader = command.ExecuteReader();
            racikan = false;

            while (reader.Read())
            {
                Console.WriteLine(reader["isRFlag"].ToString());
                if (reader["isRFlag"].ToString().Equals("False")) racikan = true;
            }
            c.Close();
            FmAntrian fmAntrian = new FmAntrian
            {
                Nomor = txtNoResep.Text.Trim().ToUpper(),
                Racikan = racikan,
                lantai = lantai,
                TglInsert = DateTime.Now,
                TglUpdate = DateTime.Now,
                UsrInsert = usr,
                UsrUpdate = usr
            };
            _ctx.FmAntrian.Add(fmAntrian);
            _ctx.SaveChanges();
            load();
            txtPasien.Text = "";
            txtPasien.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
           
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            foreach (DataGridViewRow d in dataGridView1.Rows)
            {

                int i = Convert.ToInt32(d.Cells[0].Value);
                Console.WriteLine(i);
                var update = from f in _ctx.FmAntrian
                             where f.AntrianId == i 
                             select f;
                foreach (var f in update)
                {
                    f.Racikan = Convert.ToBoolean(d.Cells[2].Value);
                    f.Ambil = Convert.ToBoolean(d.Cells[3].Value);
                    f.TglUpdate = DateTime.Now;
                    f.UsrUpdate = usr;
                    
                }
 
            }
            _ctx.SaveChanges();
            load();
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            var nonRacik = from n in _ctx.FmAntrian
                           where n.Ambil.Equals(false) && n.lantai.Equals(lantai)
                           select n;

            dataGridView1.DataSource = nonRacik.ToList();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtNoResep_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Return)
            {
                save();
            //    base.OnShown(e);
            }
        }

        private void btnOK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSave_Click(sender,e);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow d in dataGridView1.Rows)
            {
                bool n = Convert.ToBoolean(d.Cells[3].Value);
                d.Cells[3].Value = n==true?false:true;

            }
        }  
        
        private void txtPasien_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView2.Visible.Equals(true))
            {
                readNumber(txtPasien.Text.Trim(), conn);
            }
            txtNoResep.Text = "";
        }

        private void txtPasien_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.KeyCode.ToString());
            switch (e.KeyCode)
            {
                case Keys.F1 :
                    dataGridView2.Visible = true;
                    readNumber(txtPasien.Text.Trim(), conn);
                    txtPasien.Focus();
                    break;
                case Keys.Down :
                    if (dataGridView2.Visible.Equals(true))
                        dataGridView2.Focus();
                        break;
              
                case Keys.Escape :
                        dataGridView2.Visible = false;
                        break;
            }
        }

        private void txtPasien_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char) Keys.Escape: 
                    dataGridView2.Visible = false;
                    break;
                case (char) Keys.Return :
                    if (dataGridView2.Visible.Equals(true))
                    {
                        dataGridView2.Visible = false;
                      
                    }
               string query ; 
               if (txtNoResep.Text==""){
                   query = " select PrescriptionNo, firstName from transPrescription t inner join registration r on t.registrationNo=r.registrationNo inner join patient p on r.patientId=p.patientId " +
                           " where firstName like '" + txtPasien.Text.Trim() + "' and  CONVERT(VARCHAR, prescriptiondate, 112) = CONVERT(VARCHAR, GETDATE(), 112) " +
                           " and left(prescriptionno,3)='rso'";
               
               }else{
                   query = " select PrescriptionNo, firstName from transPrescription t inner join registration r on t.registrationNo=r.registrationNo inner join patient p on r.patientId=p.patientId " +
                           " where prescriptionNo= '" + nomor + "'";
               
               }
                SqlConnection c = new SqlConnection(conn);
               
                SqlCommand command = new SqlCommand(query, c);
                c.Open();
          
                SqlDataReader reader = command.ExecuteReader();
                
                if(reader.Read())
                {
                    txtPasien.Text= reader["firstName"].ToString();
                    nomor=reader["PrescriptionNo"].ToString();
                    txtNoResep.Text = nomor.Substring(nomor.Length-4);
                }
                else
                {
                    dataGridView2.Visible = true;
                    readNumber(txtPasien.Text.Trim(), conn);
                    txtPasien.Focus();
                }                
                c.Close();
                break;
            }
        }

        public class Receipt
        {
            public string NoResep { get; set; }
            public string Pasien { get; set; }
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* switch (e.KeyChar)
            {
                case (char) Keys.Enter:
                    dataGridView2.Visible = false;
                    txtNoResep.Text = nomr.Substring(nomr.Length-4);
                    txtPasien_KeyPress(sender, e);
                    break;
                case (char)Keys.Escape:
                    dataGridView2.Visible = false;
                    break;
            

            }*/
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    dataGridView2.Visible = false;

                    nomor= dataGridView2[0,dataGridView2.CurrentCell.RowIndex].Value.ToString();
                    txtPasien.Text = dataGridView2[1, dataGridView2.CurrentCell.RowIndex].Value.ToString();
                    txtNoResep.Text = nomor.Substring(nomor.Length - 4);
                  
                    break;
                case Keys.Escape:
                    dataGridView2.Visible = false;
                    break;


            }
        }

        private void txtNoResep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                save();
                //    base.OnShown(e);
            }
        }

        
     /*   private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomor = Convert.ToString(dataGridView2[0, e.RowIndex].Value);
            Console.WriteLine(nomor);
            
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            nomr=dataGridView2.CurrentCell.OwningRow.ToString();
            Console.WriteLine(nomr);
            
        }*/
      
    }
}
