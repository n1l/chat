﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat.authentification
{
    [Serializable()]
    class User : IComparable<User>
    {
        string login;
        string password;

        public string Login { get; set; }

        public string Password { get; set; }

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public int CompareTo(User other)
        {
            if (this.login == other.login && this.password == other.password)
                return 0;

            return -1;
        }
    }
}
