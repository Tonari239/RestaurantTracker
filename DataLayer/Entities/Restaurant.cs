using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTracker.DataLayer.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public  int Cleanness { get; set; }
        public  int HospitalityLevel { get; set; }
        public string ImgUrl { get; set; }
        //TODO zvukova izolaciq ; ventilaciq
        public string Address { get; set; }
        public bool VeganFriendly { get; set; }
        public bool FreeToilet { get; set; }
        public bool PetFriendly { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime UpdateDate { get; set; }

        public Restaurant()
        {
            this.ImgUrl = "https://www.allianceplast.com/wp-content/uploads/2017/11/no-image.png";
        }
    }
}
