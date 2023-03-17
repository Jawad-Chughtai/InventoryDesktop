using System.ComponentModel.DataAnnotations;

namespace InventoryDesktop.EntityFramework.Distributors
{
    public class Distributor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}
