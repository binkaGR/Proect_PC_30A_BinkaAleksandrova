using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Въведете потребителско име:");
            string username = Console.ReadLine();
            Console.WriteLine("Въведете парола: ");
            string password = Console.ReadLine();

            LoginValidation validation = new LoginValidation(username, password, ActionOnError);

            User user = new User();

            if (validation.User_Input(ref user))
            {
                Console.WriteLine(user.Username);
                Console.WriteLine(user.Pasword);
                Console.WriteLine(user.FakNum);
                Console.WriteLine((UserRoles)user.Role);
                Console.WriteLine(user.Created);

                switch (user.Role)
                {
                    case 0:
                        Console.WriteLine($"Welcome, {(UserRoles)user.Role}");
                        break;
                    case 1:
                        Console.WriteLine($"Welcome, {(UserRoles)user.Role}");
                        Console.WriteLine();

                        ShowAdminMenu();
                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 0:
                                Console.WriteLine("Приятен ден!");

                                return;
                            case 1:

                                Console.Write("Въведете потребителско име: ");
                                string usernameForRole = Console.ReadLine();

                                Console.Write("Въведете новата роля (число): ");
                                UserRoles newRole = (UserRoles)int.Parse(Console.ReadLine());

                                UserData.AssingUserRole(usernameForRole, newRole);

                                break;
                            case 2:

                                Console.Write("Въведете потребителско име: ");
                                string usernameForStatus = Console.ReadLine();

                                Console.Write("Въведете новата дата: ");
                                DateTime resultDateTime;

                                DateTime.TryParse(Console.ReadLine(), out resultDateTime);

                                UserData.SetUserActiveTo(usernameForStatus, resultDateTime);

                                break;
                            case 3:
                                break;
                            case 4:

                                string log = File.ReadAllText("test.txt");
                                //Console.WriteLine(Logger.GetCurrentSessionActivities("Ivan");
                                StringBuilder sb_log = new StringBuilder();
                                IEnumerable<string> currentActs_log = Logger.GetCurrentSessionActivities("Ivan");
                                foreach (string line in currentActs_log)
                                {
                                    sb_log.Append(line);
                                }
                                Console.WriteLine(log);
                                break;
                            case 5:

                                //Console.WriteLine(Logger.GetCurrentSessionActivities());
                                StringBuilder sb = new StringBuilder();
                                IEnumerable<string> currentActs = Logger.GetCurrentSessionActivities("Ivan");
                                foreach (string line in currentActs)
                                {
                                    sb.Append(line);
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Welcome, {(UserRoles)user.Role}");
                        break;
                    case 3:
                        Console.WriteLine($"Welcome, {(UserRoles)user.Role}");
                        break;
                    case 4:
                        Console.WriteLine($"Welcome, {(UserRoles)user.Role}");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }

            void ActionOnError(string errorMessage)
            {
                Console.WriteLine($"{errorMessage}!");
            }

            void ShowAdminMenu()
            {
                Console.WriteLine("Изберете опция:");
                Console.WriteLine("1: Промяна на роля на потребител");
                Console.WriteLine("2: Промяна на активност на потребител");
                Console.WriteLine("3: Списък на потребителите");
                Console.WriteLine("4: Преглед на лог на активност");
                Console.WriteLine("5: Преглед на текущата активност");
            }

        }
    }
}
