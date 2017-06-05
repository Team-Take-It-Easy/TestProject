using PostgresData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLData.Models
{
    public class User
    {
        //private ICollection<Reservation> reservations;

        public User()
        {
           // reservations = new HashSet<Reservation>();
        }

        public User(string name)
        {
            //reservations = new HashSet<Reservation>();
            this.Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
        /*
        public virtual ICollection<Reservation> Reservations
        {
            get
            {
                return this.reservations;
            }
            set
            {
                this.reservations = value;
            }
        }
        */
    }
}
