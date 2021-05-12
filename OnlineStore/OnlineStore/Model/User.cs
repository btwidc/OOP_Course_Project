using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Model
{
    public class User
    {
        public int id { get; set; }
        private string username; 
        private string password;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }   
 
        public User() { }

        public User(string username, string password) {
            this.username = username;
            this.password = password;
        }

    }
}
