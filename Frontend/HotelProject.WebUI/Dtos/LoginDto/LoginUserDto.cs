using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="boş bırakılamaz")]
        public string Username { get; set; }
        [Required(ErrorMessage = "boş bırakılamaz")]
        public string Password { get; set; }
    }
}
