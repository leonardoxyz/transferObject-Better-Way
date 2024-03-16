namespace transferObject.Models
{
    public class Character : BaseEntity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public List<Item> Inventory { get; set; } = new List<Item>();
    }
}
