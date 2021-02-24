using Halimat.Interface;
using Halimat.Models;
using Microsoft.AspNetCore.Mvc;

namespace Halimat.Controllers
{
    public class ClubController : Controller
    {
       private readonly IAge _repo;
      public  ClubController(IAge repo)
      {
          _repo = repo;
      }
    
       public IActionResult Index()
       {
          return View();
       }  
       [HttpPost]
       public IActionResult agechecker(Age model)
       {
           var result = _repo.Checkage(model);
           ViewBag.ModelAgeOfCustomer = model.AgeOfCustomer;
            
           ViewBag.ModelAboveEighteen = "Welcome to Halimat Club, What drink would you like to order";
           return View();
       } 
       
    }
}