using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{

    class UserClass
    {
        string username;
        string password;
        public UserClass(string _username, string _password) //constructor
        {
            username = _username;
            password = _password;
        }
        public void msg()
        {
            MessageBox.Show(username);
        }
    }
}
