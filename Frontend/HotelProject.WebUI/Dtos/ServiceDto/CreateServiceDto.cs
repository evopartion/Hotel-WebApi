using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage="Boş Bırakılamaz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public string Description { get; set; }
    }

}
