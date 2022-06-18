using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSM.TABLES.Guide;
using DSM.TABLES.Pepole;
using Microsoft.EntityFrameworkCore;

namespace DSM.DAL
{
    public class DSMDBContext:DbContext
    {

        public DSMDBContext(DbContextOptions<DSMDBContext> options):base(options)
        {

        }


        public DSMDBContext()
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<ImagesScreen> screens { get; set; }
        public DbSet<ImagesScreen> images { get; set; }
        public DbSet<Mdeia> mdeias { get; set; }



    }
}
