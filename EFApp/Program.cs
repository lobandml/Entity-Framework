using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EFApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (AppContext db = new AppContext())
            {
                User user1 = new User("Oleg", "100");
                User user2 = new User("Nikita", "200");
                User user3 = new User("Admin", "300");
                user3.tag.Active=true;

                Workstation station = new Workstation("Server");
                station.users .Add( user1);
                station.users.Add(user3);

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.Users.Add(user3);

                db.Stations.Add(station);
                db.SaveChanges();
            }
           // Console.ReadKey();
        }
    }
}
