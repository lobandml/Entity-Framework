using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFApp
{
    class Workstation
    {
        public int Id { get; set; }

        public List<User> users{get;set;}
        public string Name{get;set;}

        public Workstation(string name)
        {
        this.Name = name;
        users = new List<User>();
        }
    }
}
