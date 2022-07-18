using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppVersta.Domain;
using WebAppVersta.Domain.Repositories;

namespace WebAppVersta.Controllers
{
    public class VerstaController : Controller
    {
        private readonly IOrdersItems ordersItems;
        public VerstaController(IOrdersItems ordersItems)
        {
            this.ordersItems = ordersItems;
        }
        public IActionResult Index()
        {
            var orders = ordersItems.GetAllOrders();
            return View(orders);
        }
        public IActionResult AddOrder()
        {
            var order = new Order();
            return View(order);
        }
        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                ordersItems.AddOreder(order);
                return RedirectToAction(nameof(VerstaController.Index), nameof(VerstaController).Replace("Controller", ""));
            }
            return View(order);
        }
    }
}
