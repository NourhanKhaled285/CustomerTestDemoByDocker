using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Entities;
using WebApplication7.Repositories;

namespace WebApplication7.Controllers
{
    public class CustomerController : Controller
    {
        readonly GenericRepository<Customer> CustomerRepository;
        public CustomerController(GenericRepository<Customer> CustomerRepository)
        {
           this.CustomerRepository = CustomerRepository;    


        }
        public async Task<IActionResult> Index()
        {
            var Customers = await CustomerRepository.ReadAll();
          
           
            return View(Customers);
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer )
        {
            if (ModelState.IsValid)
            {
                
                if (((await CustomerRepository.ReadAll()).Any(e => e.CustomerEmail == customer.CustomerEmail)))
                    return RedirectToAction(nameof(Index));


                else
                {
                    await CustomerRepository.Create(customer);

                }

                    return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

    }
}
