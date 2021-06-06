using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using DAL;

namespace BLL
{
    public class UsersBLL
    {
        public static bool Login(string username, string password)
        {
            UsersDAL login = new UsersDAL();
            string hash_pass = Functions.CreateMD5(password).ToLower();

            if (hash_pass.Equals(login.Login(Functions.SanitizeString(username)).ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
