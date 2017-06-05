using PostgresData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData
{
    public class PostgresDbContext: DbContext
    {
        public PostgresDbContext()
            :base("TestReservationsDb")
        {

        }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
