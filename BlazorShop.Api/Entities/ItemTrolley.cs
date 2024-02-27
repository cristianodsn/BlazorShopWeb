namespace BlazorShop.Api.Entities
{
    public class ItemTrolley
    {
        public int Id { get; set; }
        public Trolley? Trolley { get; set; }
        public int TrolleyId { get; set; }
        public Product? Product { get; set; }
        public  int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
