using System.ComponentModel.DataAnnotations;

namespace InventoryDesktop.EntityFramework.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string? LastName { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }

        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [Required]
        public string Role { get; set; }    
        
        public bool IsIncluded { get; set; } = true;

        public DateTime CreationTime { get; set; } = new DateTime();

        public string CreationTimeString { get { return CreationTime.ToString("MMM, dd yyyy hh:mm tt"); } }

        public bool IsDeleted { get; set; } = false;
    }
}
