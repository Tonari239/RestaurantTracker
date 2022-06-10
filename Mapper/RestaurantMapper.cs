using RestaurantTracker.DataLayer.Entities;
using RestaurantTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTracker.Mapper
{
    public static class RestaurantMapper
    {
        public static RestaurantViewModel RestaurantToRestaurantVM(Restaurant Restaurant)
        {
            RestaurantViewModel RestaurantVM = new RestaurantViewModel()
            {
                Id = Restaurant.Id,
                Address = Restaurant.Address,
                ImgUrl = Restaurant.ImgUrl,
                Cleanness = Restaurant.Cleanness,
                VeganFriendly = Restaurant.VeganFriendly,
                PetFriendly = Restaurant.PetFriendly,
                FreeToilet = Restaurant.FreeToilet,
                HospitalityLevel = Restaurant.HospitalityLevel,
                DateAdded = Restaurant.DateAdded
            };
            return RestaurantVM;
        }

        public static Restaurant RestaurantVMToRestaurant(RestaurantViewModel RestaurantVM)
        {
            Restaurant Restaurant = new Restaurant()
            {
                Id = RestaurantVM.Id,
                Address = RestaurantVM.Address,
                ImgUrl = RestaurantVM.ImgUrl,
                Cleanness = RestaurantVM.Cleanness,
                VeganFriendly = RestaurantVM.VeganFriendly,
                PetFriendly = RestaurantVM.PetFriendly,
                FreeToilet = RestaurantVM.FreeToilet,
                HospitalityLevel = RestaurantVM.HospitalityLevel,
                DateAdded = RestaurantVM.DateAdded
            };
            return Restaurant;
        }
    }

}
