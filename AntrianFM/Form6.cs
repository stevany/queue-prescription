using antrianFM;
using Microsoft.Reporting.WinForms;
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
    public partial class Form6 : Form
    {
        Context _ctx = new Context();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            load();
         
        }
        void load()
        {
            
            DateTime tanggal1 = Convert.ToDateTime(tgl.Value.ToString("yyyy-MM-dd") + " 00:00:00");
            DateTime tanggal2 = Convert.ToDateTime(tgl2.Value.ToString("yyyy-MM-dd") + " 23:59:59");
          //  int lantai = cmbLantai.SelectedIndex+1;
          
            var a = from b in _ctx.FmAntrian
                    where b.TglInsert >= tanggal1 && b.TglInsert <= tanggal2 
                    orderby b.AntrianId
                    select b ;
            string fl = Application.StartupPath + @"\\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource ds = new ReportDataSource("DataSet1", a.ToList());
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.ReportPath = fl;
        
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            load();

            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
