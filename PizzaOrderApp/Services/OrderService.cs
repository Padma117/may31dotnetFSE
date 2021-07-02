using PizzaOrderApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace PizzaOrderApp.Services
{
    public class OrderService
    {
        StoreContext context;
        
        public OrderService()
        {
            context = new StoreContext();
        }
        public List<Item> GetAllItems()
        {
            //connect to database fetch all the Pizza details, puts it in a list and gives us
            return context.Items.ToList();
        }
        public List<PizzaSize> GetAllSizes()
        {
            //connect to database fetch all the Pizza details, puts it in a list and gives us
            return context.pizzaSizes.ToList();
        }
        public List<PizzaCrust> GetAllCrusts()
        {
            //connect to database fetch all the Pizza details, puts it in a list and gives us
            return context.pizzaCrusts.ToList();
        }
        public List<topping> GetAllToppings()
        {
            //connect to database fetch all the Pizza details, puts it in a list and gives us
            return context.toppings.ToList();
        }

        public Item GetItem(int id)
        {
            Item item = context.Items.Where(item => item.PizzaId == id).FirstOrDefault();
            return item;
        }

        public PizzaSize GetSize(int id)
        {
            PizzaSize size = context.pizzaSizes.Where(size => size.SizeId == id).FirstOrDefault();
            return size;
        }

        public PizzaCrust GetCrust(int id)
        {
            PizzaCrust crust = context.pizzaCrusts.Where(crust => crust.CrustId == id).FirstOrDefault();
            return crust;
        }

 

        public topping Gettopping(int id)
        {
            topping topping = context.toppings.Where(topping => topping.ToppingId == id).FirstOrDefault();
            return topping;
        }

        public bool AddOrder(Order order)
        {
            //adds it to the local dbset
            context.Orders.Add(order);
            //makes the insert in to the database
            context.SaveChanges();
            return true;
        }
        public bool AddOrderDetails(OrderDetail orderdetail)
        {
            //adds it to the local dbset
            context.OrderDetails.Add(orderdetail);
            //makes the insert in to the database
            context.SaveChanges();
            return true;
        }

        public Order GetOrder(int id)
        {
            Order order = context.Orders.Where(order => order.OrderId == id).FirstOrDefault();
            return order;
        }

        public OrderDetail GetOrderDetail(int id)
        {
            OrderDetail orderdetail= context.OrderDetails.Where(orderdetail => orderdetail.OrderId == id).FirstOrDefault();
            return orderdetail;
        }

        internal bool RemoveOrderDetails(int id)
        {
            OrderDetail myorddetail = GetOrderDetail(id);
            if (myorddetail != null)
            {
                context.OrderDetails.Remove(myorddetail);
                context.SaveChanges();
                Order myord = GetOrder(id);
                context.Orders.Remove(myord);
                context.SaveChanges();
                return true;
            }
            else
            {
                Console.WriteLine("Order doesnot exist.. please try again");
                return false;
            }
           
        }


    }

   
}
