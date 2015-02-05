using antrianFM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrianFM
{

   
    public partial class Form2 : Form
    {
        Context _ctx = new Context();
       
        int i, j, lt, currPage;
       
        decimal totRowRacik, totRowNonRacik, pageSize;
        List<string> nonRacik1, nonRacik2;
        List<string> racik1, racik2;
        SoundPlayer player;
        public Form2()
        {
            InitializeComponent();
            string fl = Application.StartupPath + @"\\config.ini";
            IniFile inif = new IniFile(fl);
            lt = Convert.ToInt32(inif.Read("lantai", "nilai"));
            totRowRacik = 0;
            totRowNonRacik = 0;
            pageSize = 0;
            currPage = 0;
            player = new SoundPlayer(Application.StartupPath + @"\\bell.wav");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.lblNoResep.Parent = pictureBox1;
            this.lblNoResep.BackColor = Color.Transparent;
            this.label3.Parent = pictureBox1;
            this.label3.BackColor = Color.Transparent;
            timer1.Interval = 1000;          
            timer1.Start();
        }
        private IQueryable<FmAntrian> SelectAllQuery(IQueryable<FmAntrian> query)
        {
            return query;
        }
        private int SelectCountNonRacik()
        {
            var query= from q in _ctx.FmAntrian where q.Ambil.Equals(false) && q.lantai.Equals(lt) && q.Racikan.Equals(false)
                           select q;
            query = SelectAllQuery(query);
            return query.Count();

        }
        private int SelectCountRacik()
        {
            var query = from q in _ctx.FmAntrian
                        where q.Ambil.Equals(false) && q.lantai.Equals(lt) && q.Racikan.Equals(true)
                        select q;
            query = SelectAllQuery(query);
            return query.Count(); 
        }

        void load()
        {

            var tgl=DateTime.Now.AddSeconds(-20);
            var nonRacik = (from n in _ctx.FmAntrian
                            where n.Ambil.Equals(false) && n.Racikan.Equals(false) && n.lantai.Equals(lt)
                            orderby n.AntrianId 
                            select new { Nomor = n.Nomor }).OrderBy(c=>c.Nomor).Skip(currPage*12).Take(12);
            var racik = (from r in _ctx.FmAntrian
                         where r.Ambil.Equals(false) && r.Racikan.Equals(true) && r.lantai.Equals(lt)
                         orderby r.AntrianId 
                         select new { Nomor = r.Nomor }).OrderBy(d=>d.Nomor).Skip(currPage*12).Take(12);
            var top = (from r in _ctx.FmAntrian
                       where r.Ambil.Equals(false) && r.lantai.Equals(lt)
                       orderby r.AntrianId 
                       select new { Nomor = r.Nomor, Play=r.Play }).FirstOrDefault();
            var least=(from l in _ctx.FmAntrian   where l.Ambil.Equals(false) && l.lantai.Equals(lt) && l.Play.Equals(false)
                       orderby l.AntrianId descending
                       select new { Nomor = l.Nomor, Play=l.Play });
                  
            Console.WriteLine(tgl);
            nonRacik1 = new List<string>();
            nonRacik2 = new List<string>();
            racik1 = new List<string>();
            racik2 = new List<string>();
            i=0;
            j = 0;
            foreach (var n in nonRacik)
            {
                i++;
                if (i < 7)
                {
                   nonRacik1.Add(n.Nomor);
                 
                   
                }else{
                    nonRacik2.Add(n.Nomor);
                
                }
             }
            
            
            foreach (var r in racik)
            {
                j++;
                if (j < 7)
                {
                    racik1.Add(r.Nomor);
                }
                else
                {
                    racik2.Add(r.Nomor);
                }
            }


           
            dataGridView1.DataSource = racik1.Select(x => new { Value = x }).ToList();
            dataGridView1.Font = new Font("Verdana", 50);
            dataGridView1.Columns[0].Width = 240;
            foreach (DataGridViewRow r1 in dataGridView1.Rows)
            {
                Console.WriteLine(r1.Index);
                if ((r1.Index + 1) % 2 == 0)
                {
                    r1.DefaultCellStyle.BackColor = Color.Aquamarine;
                    r1.DefaultCellStyle.ForeColor = Color.DarkViolet;
                }
            }
            dataGridView2.DataSource = racik2.Select(x => new { Value = x }).ToList();
            dataGridView2.Font = new Font("Verdana", 50);
            dataGridView2.Columns[0].Width = 240;
            foreach (DataGridViewRow r2 in dataGridView2.Rows)
            {
                Console.WriteLine(r2.Index);
                if ((r2.Index + 1) % 2 == 0)
                {

                    r2.DefaultCellStyle.BackColor = Color.SpringGreen;
                    r2.DefaultCellStyle.ForeColor = Color.Goldenrod;
                }
            }
            dataGridView3.DataSource = nonRacik1.Select(x => new { Value = x }).ToList();
            dataGridView3.Font = new Font("Verdana", 50);
            dataGridView3.Columns[0].Width = 240;
            foreach (DataGridViewRow r3 in dataGridView3.Rows)
            {
                Console.WriteLine(r3.Index);
                if ((r3.Index + 1) % 2 == 0)
                {
                    r3.DefaultCellStyle.BackColor = Color.PaleTurquoise;
                    r3.DefaultCellStyle.ForeColor = Color.DarkViolet;
                }
            }
            dataGridView4.DataSource = nonRacik2.Select(x => new { Value = x }).ToList();
            dataGridView4.Font = new Font("Verdana", 50);
            dataGridView4.Columns[0].Width = 240;
            foreach (DataGridViewRow r4 in dataGridView4.Rows)
            {
                Console.WriteLine(r4.Index);
                if ((r4.Index + 1) % 2 == 0)
                {
                    r4.DefaultCellStyle.BackColor = Color.MediumSpringGreen;
                    r4.DefaultCellStyle.ForeColor = Color.Goldenrod;
                }
            }
            lblNoResep.Text = top==null? "" : top.Nomor;
            currPage = currPage + 1;
            if (least.Count()> 0)
            {
                if (least.FirstOrDefault().Play.Equals(false)) { player.Play(); }
                var update = from f in _ctx.FmAntrian
                             where f.Nomor.Equals(least.FirstOrDefault().Nomor) && f.lantai.Equals(lt) && f.Ambil.Equals(false)
                             select f;
                foreach (var f in update)
                {
                    f.Play = true;

                }
                _ctx.SaveChanges();

            }
                
            }
            
    
    
       
        private void Form2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                totRowRacik = SelectCountRacik();
                totRowNonRacik = SelectCountNonRacik();
                pageSize = totRowRacik > totRowNonRacik ? Math.Ceiling(totRowRacik / 12) : Math.Ceiling(totRowNonRacik / 12);
                if (totRowNonRacik > 0 || totRowRacik > 0)
                {
                    if (currPage + 1 > pageSize) currPage = 0;

                }
                else
                {
                    currPage = 0;
                }
                load();

            }
            catch (IOException o)
            {
                throw o;
            }
  
            
           
        }
            

       
    }
}
