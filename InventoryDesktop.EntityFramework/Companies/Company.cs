using System.ComponentModel.DataAnnotations;

namespace InventoryDesktop.EntityFramework.Companies
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
