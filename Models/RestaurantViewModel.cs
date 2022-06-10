using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTracker.Models
{
    public class RestaurantViewModel : BaseViewModel
    {
        [DisplayName("Чистота")]

        public int Cleanness { get; set; }

        [DisplayName("Гостоприемство")]
        public int HospitalityLevel { get; set; }

        [DisplayName("Линк на снимката")]
        public string ImgUrl { get; set; }


        [Required(ErrorMessage = "Моля въведете адреса!")]
        [DisplayName("Адрес")]
        public string Address { get; set; }

        [DisplayName("Има вегански опции")]
        public bool VeganFriendly { get; set; }

        [DisplayName("Безплатна за употреба тоалетна")]
        public bool FreeToilet { get; set; }

        [DisplayName("Опции за домашни любимци")]
        public bool PetFriendly { get; set; }

        [DisplayName("Дата на създаване")]
        public DateTime DateAdded { get; set; }
    }
}
