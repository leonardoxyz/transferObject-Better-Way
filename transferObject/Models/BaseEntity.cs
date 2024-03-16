namespace transferObject.Models
{
    public class BaseEntity
    {
        public DateTime DateCreated { get; set; }
        public DateTime DataUpdated { get; set; }
        public bool isDeleted { get; set; }

        public BaseEntity()
        {
            Random rdn = new Random();
            int range = (DateTime.Today - new DateTime(1995, 1, 1)).Days;
            DateCreated = new DateTime(1995, 1, 1).AddDays(rdn.Next(range));
            DataUpdated = DateCreated.AddDays(rdn.Next(1, 365));
            isDeleted = rdn.Next(0, 2) == 0;
        }
    }
}
