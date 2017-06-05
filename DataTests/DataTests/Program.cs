using PostgresData.Models;
using SQLData;
using SQLData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataTests
{
    public class Program
    {
        public static void Main()
        {
            var sqlContext = new SQLDBContext();

            var postgresContext = new PostgresDbContext();
            var reservation = new Reservation("reservation");

            var user = new User("user");

            reservation.UserId = 1;

            //user.Reservations.Add(reservation);

            postgresContext.Reservations.Add(reservation);

            postgresContext.SaveChanges();

            sqlContext.Users.Add(user);

            sqlContext.SaveChanges();

        }
    }
}
