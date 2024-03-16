namespace transferObject.Models
{
    public class Item : BaseEntity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }
    }
}
