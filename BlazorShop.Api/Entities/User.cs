using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Api.Entities
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string NameUser { get; set; } = string.Empty;

        public Trolley? Trolley { get; set; } 
    }
}
