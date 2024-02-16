using System.ComponentModel.DataAnnotations;

namespace ProjectFile.Models
{
    public class GuestInvite
    {
        [Required]
        public string? name {  get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }
        public string? willAttend { get; set; }
    }
}
