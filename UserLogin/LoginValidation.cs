using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class LoginValidation
    {
        private string username;
        private string password;
        private string errorMessage;
        private ActionOnError errorAction;

        public delegate void ActionOnError(string errorMsg);

        public static UserRoles currentUserRole { get; private set; }

        public LoginValidation(string username, string password, ActionOnError errorAction)
        {
            this.username = username;
            this.password = password;
            this.errorAction = errorAction;
        }

        public bool User_Input(ref User user)
        {
            bool emptyUserName;
            emptyUserName = username.Equals(string.Empty);

            if (emptyUserName)
            {
                errorMessage = "Не е посочено потребителско име";
                errorAction(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            bool emptyPassword;
            emptyPassword = password.Equals(string.Empty);

            if (emptyPassword)
            {
                errorMessage = "Не е посочена парола";
                errorAction(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            if (username.Length < 4)
            {
                errorMessage = "Потребителското име трябва да бъде поне 5 символа";
                errorAction(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            if (password.Length < 4)
            {
                errorMessage = "Паролата трябва да бъде поне 5 символа";
                errorAction(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            user = UserData.LogginCorrect(username, password);

            if (user == null)
            {
                errorMessage = "Потребителят не беше намерен";
                errorAction(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            currentUserRole = (UserRoles)user.Role;
            Logger.LogActivity("Успешен Login");
            return true;
        }
    }
}
