using RestaurantTracker.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTracker.DataLayer.Repositories
{
    public class RestaurantRepository : CRUDrepository<Restaurant>
    {

        public RestaurantRepository(RestaurantDbContext context) : base(context, context.Restaurants)
        {

        }
    }
}
