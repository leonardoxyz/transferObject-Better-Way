namespace transferObject.Dtos
{
    public class CharacterDto
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public List<ItemDto> InventoryList { get; set; } = new List<ItemDto>();
    }
}
