using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTracker.Models
{
    public class RestaurantsViewModel
    {
        public IEnumerable<RestaurantViewModel> RestaurantViewModels { get; set; }
        public RestaurantsViewModel()
        {
            RestaurantViewModels = new HashSet<RestaurantViewModel>().AsEnumerable<RestaurantViewModel>();
        }
    }
}
