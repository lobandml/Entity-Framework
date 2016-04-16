using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace EFApp
{
    class AppContext:DbContext
    {
        public AppContext():base("DbConnection")
        { 
        
        }
          
        public DbSet<User> Users { get; set; }
        public DbSet<Workstation> Stations { get; set; }
    }
}
