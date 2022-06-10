using Microsoft.AspNetCore.Mvc;
using RestaurantTracker.DataLayer;
using RestaurantTracker.DataLayer.Entities;
using RestaurantTracker.DataLayer.Repositories;
using RestaurantTracker.Mapper;
using RestaurantTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTracker.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDbContext _context;
        private RestaurantRepository _RestaurantRepo;
        private IEnumerable<Restaurant> Restaurants;
        RestaurantsViewModel RestaurantsVM = new RestaurantsViewModel();
        public RestaurantController(RestaurantDbContext cont)
        {
            _context = cont;
            _RestaurantRepo = new RestaurantRepository(_context);
            Restaurants = _RestaurantRepo.GetAll();

            RestaurantsVM.RestaurantViewModels = Restaurants.Select(tvm => new RestaurantViewModel() // ne izpolzvame ADD/Remove tuk
            {
                Id = tvm.Id,
                Address = tvm.Address,
                VeganFriendly = tvm.VeganFriendly,
                PetFriendly = tvm.PetFriendly,
                Cleanness = tvm.Cleanness,
                FreeToilet = tvm.FreeToilet,
                ImgUrl = tvm.ImgUrl,
                HospitalityLevel = tvm.HospitalityLevel,

            });
        }




        public IActionResult Index()
        {

            return View(@"~/Views/Restaurant/_Index.cshtml", RestaurantsVM);
        }

        [HttpGet]
        public IActionResult Create(Restaurant Restaurant)
        {
            RestaurantViewModel vm = RestaurantMapper.RestaurantToRestaurantVM(Restaurant);

            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(RestaurantViewModel RestaurantVM)
        {
            if (!ModelState.IsValid)
            {
                return View(RestaurantVM);
            }
            Restaurant Restaurant = RestaurantMapper.RestaurantVMToRestaurant(RestaurantVM);

            _RestaurantRepo.Add(Restaurant);

            return RedirectToAction("Index", "Restaurant");
        }


        [HttpGet("Restaurant/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            RestaurantViewModel RestaurantVM = RestaurantsVM.RestaurantViewModels.FirstOrDefault(x => x.Id == id);
            return View(RestaurantVM);
        }

        [HttpPost]
        public IActionResult Edit(RestaurantViewModel RestaurantVM)
        {
            if (!ModelState.IsValid)
            {
                return View(RestaurantVM);
            }

            Restaurant Restaurant = _RestaurantRepo.GetById(RestaurantVM.Id);

            Restaurant.Id = RestaurantVM.Id;
            Restaurant.Address = RestaurantVM.Address;
            Restaurant.HospitalityLevel = RestaurantVM.HospitalityLevel;
            Restaurant.PetFriendly = RestaurantVM.PetFriendly;
            Restaurant.DateAdded = RestaurantVM.DateAdded;
            Restaurant.VeganFriendly = RestaurantVM.VeganFriendly;
            Restaurant.ImgUrl = RestaurantVM.ImgUrl;
            Restaurant.Cleanness = RestaurantVM.Cleanness;
            Restaurant.FreeToilet = RestaurantVM.FreeToilet;
            Restaurant.UpdateDate = DateTime.Now;


            _RestaurantRepo.Update(Restaurant);
            return RedirectToAction("Index", "Restaurant");
        }


        [HttpGet("Restaurant/GetRestaurant/{id}")]

        public IActionResult GetRestaurant(int id)
        {
            Restaurant Restaurant = _RestaurantRepo.GetById(id);
            RestaurantViewModel RestaurantVM = RestaurantMapper.RestaurantToRestaurantVM(Restaurant);
            return View(RestaurantVM);
        }
        public IActionResult DeleteWarningPage(int id)
        {
            RestaurantViewModel RestaurantVM = RestaurantsVM.RestaurantViewModels.FirstOrDefault(tVM => tVM.Id == id);
            return View(RestaurantVM);
        }

        [HttpGet("Restaurant/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            Restaurant Restaurant = _RestaurantRepo.GetById(id);
            _RestaurantRepo.Remove(Restaurant);
            return RedirectToAction("Index", "Restaurant");
        }


        public IActionResult Search(string searchAddress)
        {

            if (searchAddress == null || _RestaurantRepo.Get(t => t.Address.Contains(searchAddress.Trim())) == null)
            {
                return View(@"~/Views/Restaurant/_Index.cshtml", RestaurantsVM);
            }
            RestaurantsViewModel RestaurantVMS = new RestaurantsViewModel();
            string editedAddress = searchAddress.Trim();
            IQueryable<Restaurant> Restaurants = _RestaurantRepo._dbSet.Where(t => t.Address.Contains(editedAddress));

            RestaurantVMS.RestaurantViewModels = Restaurants.Select(t => RestaurantMapper.RestaurantToRestaurantVM(t));

            return View(RestaurantVMS);


        }
    }
}
