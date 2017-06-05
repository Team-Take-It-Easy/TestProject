namespace PostgresData.Models
{
    public class Reservation
    {
        public Reservation(string name)
        {
            this.Name = name;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int UserId { get; set; }
    }
}