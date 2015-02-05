using AntrianFM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antrianFM
{
    class Context:DbContext 
    {
        public Context()
            : base("AntrianFM")
        {

        }
        public DbSet<FmAntrian> FmAntrian { get; set; }
        public DbSet<FmUser> FmUser { get; set; }
    }
}
