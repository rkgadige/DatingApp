using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }    
        [Required]
        [StringLength(9, MinimumLength=4, ErrorMessage="char lenght 4 and 8")]
        public string Password { get; set; }
        
    }
}