using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class UserData
    {
        private static List<User> _testusers;
        public static List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testusers;
            }
            set
            {

            }
        }

        public static User LogginCorrect(string username, string password)
        {
            foreach (User user in TestUsers)
            {
                if (user.Username == username && user.Pasword == password)
                {
                    return user;
                }
            }

            return null;
        }

        public static void SetUserActiveTo(string username, DateTime newExpireDate)
        {
            foreach (User user in TestUsers)
            {
                if (user.Username == username)
                {
                    user.AccountExpireDate = newExpireDate;
                    Logger.LogActivity("Промяна на активност на " + username);
                }
            }
        }

        public static void AssingUserRole(string username, UserRoles role)
        {
            foreach (User user in TestUsers)
            {
                if (user.Username == username)
                {
                    user.Role = (int)role;
                    Logger.LogActivity("Промяна на роля на " + username);
                }
            }
        }

        private static void ResetTestUserData()
        {
            if (_testusers == null)
            {
                _testusers = new List<User>();

                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        _testusers.Add(new User()
                        {
                            Username = "admin",
                            Role = 1,
                            Created = DateTime.Now,
                            AccountExpireDate = DateTime.MaxValue,
                            FakNum = "121219038",
                            Pasword = "123456"
                        });
                    }

                    if (i == 1)
                    {
                        _testusers.Add(new User()
                        {
                            Username = "user1",
                            Role = 4,
                            Created = DateTime.Now,
                            AccountExpireDate = DateTime.MaxValue,
                            FakNum = "121219058",
                            Pasword = "654321"
                        });
                    }

                    if (i == 2)
                    {
                        _testusers.Add(new User()
                        {
                            Username = "user2",
                            Role = 4,
                            Created = DateTime.Now,
                            AccountExpireDate = DateTime.MaxValue,
                            FakNum = "121219038",
                            Pasword = "456789"
                        });
                    }
                }
            }
        }
    }
}
