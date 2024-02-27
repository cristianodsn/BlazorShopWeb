namespace BlazorShop.Api.Entities
{
    public class Trolley
    {
        public int Id { get; set; }

        public User? User { get; set; }
        public int UserId { get; set; }

        public ICollection<ItemTrolley> Items { get; set; } = new List<ItemTrolley>();

    }
}
