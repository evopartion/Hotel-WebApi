using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Numarasını Yazınız")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        [StringLength(100,ErrorMessage ="100 karakterden az gir")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public string BathCount { get; set; }
        
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public string Description { get; set; }
    }
}
