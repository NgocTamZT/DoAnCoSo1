using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testcsdl.Table;

namespace testcsdl
{
    public class database : DbContext
    {
        public database() : base("databasehocvusv")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Lop> Lops { get; set; }

        public DbSet<DonVi> DonVis { get; set; }

        public DbSet<DanhMuc> DanhMucs { get; set; }

        public DbSet<HocVu> HocVus { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
