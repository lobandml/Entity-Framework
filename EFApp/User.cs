using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFApp
{
    class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public Tags tag{get; set;}

        public User( string name, string pass)
        {
            this.Name = name;
            this.tag = new Tags();
            ChangePass(pass);
        }
        public void ChangePass(string pass)
        {
            Password = pass.GetHashCode().ToString();
        }
    }
}
