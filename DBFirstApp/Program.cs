using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new myDBEntities1())
            {
                var user1 = new User { Title = "Oleg" };
                var user2 = new User { Title = "Igor" };
                var city1 = new City { Name = "Dnepropetrovsk" };
                user1.City = city1;
                user2.City = city1;
                city1.User.Add(user1);
                city1.User.Add(user2);


                db.AddToUser(user1);
                db.AddToUser(user2);
                db.AddToCity(city1);

                db.SaveChanges();

                var query = from b in db.User
                            select b;

                foreach (var item in query)
                {
                    Console.WriteLine("{0} : {1}",item.UserId,item.Title);
                } 
            }
            Console.ReadKey();
        }
    }
}
