using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Controllers
{
    public class CustomerController : Controller
    {
        private BusContext buscontext;
        static List<Customer> customers = new List<Customer>();

        public CustomerController(BusContext context)
        {
            buscontext = context;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            List<Customer> customers = buscontext.Customers.ToList();
            return View(customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            Customer customer;
            customer = buscontext.Customers.Single(customer => customer.CustId == id);
            return View(customer);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {

            try
            {
                customers.Add(customer);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customer;
            try
            {
                customer = customers.Single(customer => customer.CustId == id);
            }
            catch (ArgumentNullException ane)
            {
                customer = null;
            }
            catch (InvalidOperationException ioe)
            {
                customer = null;
            }
            return View(customer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {

            Customer customer1 = customers.Single(ctr => ctr.CustId == id);
            customer1 = customer;
            return RedirectToAction("Index");
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
