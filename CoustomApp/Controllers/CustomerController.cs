using CoustomApp.Data;
using CoustomApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoustomApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerDbContext customerDbContext;

        public CustomerController(CustomerDbContext customerDbContext)
        {
            this.customerDbContext = customerDbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Customer customer)
        {
            var custom = new Customer()
            {
                Name = customer.Name,
                Age = customer.Age,
                Address = customer.Address,
                Phone = customer.Phone
            };
            await customerDbContext.Customers.AddAsync(custom);
            await customerDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> ShowCustomers()
        {
            var customers = await customerDbContext.Customers.ToListAsync();
            return View(customers);
        }
    }
}
