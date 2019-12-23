using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace College_Management_System
{
    class login
    {
        SqlConnection con = Connection.authorize();
        string userType;
        string userName;
        string userPass;

        public login(string _usertype, string _user, string _pass)
        {
            userType = _usertype;
            userName = _user;
            userPass = _pass;
        }
        public bool getLogin()
        {
            bool _check;
            string query = "select * from Users where UserType='" +userType+ "' and Username = '" +userName+"' AND password = '" +userPass+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                _check = true;
            }
            else
            {
                _check = false;
            }
            return _check;
        }
    }
}
