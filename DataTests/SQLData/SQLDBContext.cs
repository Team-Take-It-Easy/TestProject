using SQLData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData
{
    public class SQLDBContext: DbContext
    {
        public SQLDBContext()
            :base("TestUsersDb")
        {
            
        }

        public DbSet<User> Users { get; set; }

    }
}
