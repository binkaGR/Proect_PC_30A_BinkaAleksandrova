using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public string Username
        {
            get;
            set;
        }
        public string Pasword
        {
            get;
            set;
        }
        public string FakNum
        {
            get;
            set;
        }
        public int Role
        {
            get;
            set;
        }

        public DateTime Created
        {
            get;
            set;
        }

        public DateTime AccountExpireDate
        {
            get;
            set;
        }
    }
}
