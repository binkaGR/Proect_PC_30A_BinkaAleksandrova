using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using UserLogin;

namespace StudentInfoSystem 
{
    public class StudentInfoContext : DbContext
{
        public DbSet<Student> Students { get; set; }

        public DbSet<User> Users { get; set; }

        public StudentInfoContext()
            : base(Properties.Settings.Default.DbConnect)
        {

        }
    }
}