using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Logs> Logs { get; set; }

        public UserContext()
            : base("Data Source=BINKA_PC;Initial Catalog=ConsoleApp;Integrated Security=True")
        {

        }
    }
}
