using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo{
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad Alanı zorunlu")]
        public string? Name { get; set; } // null

        [Required(ErrorMessage ="Telefon Alanı zorunlu")]
        public string? Phone { get; set; }

        [Required (ErrorMessage ="E-Mail Alanı zorunlu")]
        [EmailAddress(ErrorMessage ="Hatalı E-mail")]
        public string? Email { get; set; }

        [Required]
        public bool? willatend { get; set; }
    }
}