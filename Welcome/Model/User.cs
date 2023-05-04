using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private UserRolesEnum _role;
        public UserRolesEnum Role
        {
            get { return _role; }
            set { _role = value; }
        }

        private int _facultyNumber;
        public virtual int FacultyNumber
        {
            get{ return _facultyNumber;}
            set{ _facultyNumber = value;}
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}