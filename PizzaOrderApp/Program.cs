using PizzaOrderApp.Models;
using PizzaOrderApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace PizzaOrderApp
{
    class Program
    {
        UserService userService;
        OrderService OrderService;
        public Program()
        {
            userService = new UserService();
            OrderService = new OrderService();
        }
        void UserCheck()
        {
            User myUser = TakeUserDetails();
            int UserSelection;
            int choice = 0;
            bool VerifySelection = false;
            bool mainloop = false;
            Item selecteditem = new Item();
            PizzaCrust selectedcrust = new PizzaCrust();
            PizzaSize selectedsize = new PizzaSize();
            topping selectedtopping = new topping();
            topping addtionaltopping = new topping();
            StoreContext context1 = new StoreContext();
            if (userService.UserLogin(myUser))
            {
                while (!mainloop)
                {
                    Console.WriteLine("Welcome to the Pizza App");
                    Console.WriteLine("Enter Selection");
                    Console.WriteLine("1 \t Create New Order");
                    Console.WriteLine("2 \t View existing Order");
                    Console.WriteLine("3 \t Cancel Order");
                    Console.WriteLine("4 \t Quit");
                    while (!Int32.TryParse(Console.ReadLine(), out UserSelection))
                    {
                        Console.WriteLine("Invalid entry. Try again...");
                    }
                    switch (UserSelection)
                    {
                        case 1:
                            List<Item> items = OrderService.GetAllItems();
                            Console.WriteLine("Pizza ID \t Pizza Name \t\t Pizza Price");
                            foreach (var item in items)
                            {
                                Console.WriteLine(item.PizzaId + "\t\t" + item.PizzaName + "\t\t" + item.Pizzaprice);
                            }
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Please select the Pizza ID");
                            VerifySelection = false;
                            while (!VerifySelection)
                            {
                                while (!Int32.TryParse(Console.ReadLine(), out choice))
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }
                                selecteditem = OrderService.GetItem(choice);
                                if (selecteditem != null)
                                {
                                    Console.WriteLine("you have selected " + selecteditem.PizzaName);
                                    VerifySelection = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }
                            }

                            List<PizzaSize> pizzaSizes = OrderService.GetAllSizes();
                            Console.WriteLine("\nSize ID \t Size \t\t Size Price");
                            foreach (var PizzaSize in pizzaSizes)
                            {
                                Console.WriteLine(PizzaSize.SizeId + "\t\t" + PizzaSize.Size + "    \t" + PizzaSize.Sizeprice);

                            }
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Please select the Pizza Size");
                            VerifySelection = false;
                            while (!VerifySelection)
                            {
                                while (!Int32.TryParse(Console.ReadLine(), out choice))
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }
                                selectedsize = OrderService.GetSize(choice);

                                if (selectedsize != null)
                                {
                                    Console.WriteLine("you have selected " + selectedsize.Size);
                                    VerifySelection = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }
                            }
                            List<PizzaCrust> pizzaCrusts = OrderService.GetAllCrusts();
                            Console.WriteLine("\nCrust ID \t Crust Name \t\t Crust Price");
                            foreach (var PizzaCrust in pizzaCrusts)
                            {
                                Console.WriteLine(PizzaCrust.CrustId + "\t\t" + PizzaCrust.CrustName + "    \t" + PizzaCrust.Crustprice);

                            }
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Please select the Pizza Crust Id");
                            VerifySelection = false;
                            while (!VerifySelection)
                            {
                                while (!Int32.TryParse(Console.ReadLine(), out choice))
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }
                                selectedcrust = OrderService.GetCrust(choice);
                                if (selectedcrust != null)
                                {
                                    Console.WriteLine("you have selected " + selectedcrust.CrustName);
                                    VerifySelection = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }

                            }
                            List<topping> toppings = OrderService.GetAllToppings();
                            Console.WriteLine("\nID \t Topping Name \t\t Topping Price");
                            foreach (var topping in toppings)
                            {
                                Console.WriteLine(topping.ToppingId + "\t" + topping.ToppingName + "    \t\t" + topping.Toppingprice);

                            }
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Please select the Pizza Topping ID");
                            VerifySelection = false;
                            while (!VerifySelection)
                            {
                                while (!Int32.TryParse(Console.ReadLine(), out choice))
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }
                                selectedtopping = OrderService.Gettopping(choice);
                                if (selectedtopping != null)
                                {
                                    Console.WriteLine("you have selected " + selectedtopping.ToppingName);
                                    VerifySelection = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }
                            }
                            Console.WriteLine("--------------------------");
                            Console.WriteLine("Please select 2nd Topping ID");
                            VerifySelection = false;
                            while (!VerifySelection)
                            {
                                while (!Int32.TryParse(Console.ReadLine(), out choice))
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }
                                addtionaltopping = OrderService.Gettopping(choice);
                                if (addtionaltopping != null)
                                {
                                    Console.WriteLine("you have selected " + addtionaltopping.ToppingName);
                                    VerifySelection = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }
                            }
                            Console.WriteLine("\nPlease Enter the Quantity");
                            while (!Int32.TryParse(Console.ReadLine(), out choice))
                            {
                                Console.WriteLine("Invalid entry. Try again...");
                            }

                            double pizzaprice = 0.0;
                            pizzaprice = (selecteditem.Pizzaprice + selectedsize.Sizeprice + selectedcrust.Crustprice + selectedtopping.Toppingprice + addtionaltopping.Toppingprice) * choice * 1.07;
                            Console.WriteLine("Your Order Details are ");
                            Console.WriteLine("Pizza    " + selecteditem.PizzaName);
                            Console.WriteLine("Size     " + selectedsize.Size);
                            Console.WriteLine("crust    " + selectedcrust.CrustName);
                            Console.WriteLine("Topping1 " + selectedtopping.ToppingName);
                            Console.WriteLine("Topping2 " + addtionaltopping.ToppingName);
                            Console.WriteLine("Total cost of pizza is $" + pizzaprice);
                            Console.WriteLine("Confirm Yes/No");
                            bool confirmselection = false;
                            string ch;
                            while (!confirmselection)
                            {
                                ch = Console.ReadLine().ToLower();
                                if (ch == "yes")
                                {
                                    Order order = new Order();
                                    order.UserId = myUser.UserId;
                                    order.OrderDate = DateTime.Now;
                                    OrderService.AddOrder(order);
                                    OrderDetail orderdetail = new OrderDetail();
                                    orderdetail.OrderId = order.OrderId;
                                    orderdetail.PizzaId = selecteditem.PizzaId;
                                    orderdetail.SizeId = selectedsize.SizeId;
                                    orderdetail.CrustId = selectedcrust.CrustId;
                                    orderdetail.ToppingId = selectedtopping.ToppingId;
                                    orderdetail.ToppingId1 = addtionaltopping.ToppingId;
                                    orderdetail.Quantity = choice;
                                    orderdetail.price = (float)pizzaprice;
                                    OrderService.AddOrderDetails(orderdetail);
                                    Console.WriteLine("your order is saved ..Order will be delivered to  ." + myUser.Address);
                                    Console.WriteLine("Please have exact amount as Cash");
                                    confirmselection = true;
                                }
                                if (ch == "no")
                                {
                                    Console.WriteLine("Order not saved ... Good Bye");
                                    confirmselection = true;
                                }
                                if (!confirmselection)
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }

                            }
                            break;
                        case 2:
                            Console.WriteLine("You selected View Existing Order");
                            var myData = context1.Orders
                                .Include(t => t.OrdDetails)
                                .ThenInclude (x => x.Item)
                                .Where(order => order.UserId == myUser.UserId)
                                .ToList();

                            Console.WriteLine("ID  \t  Pizza Name \t\t  Quantity \t\t price \t\t Time");

                            //var myData = context1.OrderDetails.Include(t => t.Items).ToList();
                            foreach (var item in myData)
                            {
                                Console.WriteLine(item.OrderId + "\t" +  item.OrdDetails.Item.PizzaName + "\t\t\t" + item.OrdDetails.Quantity + "\t\t" + item.OrdDetails.price + "\t\t" + item.OrderDate );
                            }
                            break;
                        case 3:
                            Console.WriteLine("You selected to  Cancel Order");
                     
                            var myData1 = context1.Orders
                                .Include(t => t.OrdDetails)
                                .ThenInclude(x => x.Item)
                                .Where(order => order.UserId == myUser.UserId)
                                .ToList();

                            Console.WriteLine("ID  \t  Pizza Name \t\t  Quantity \t price \t Time");

                            //var myData = context1.OrderDetails.Include(t => t.Items).ToList();
                            foreach (var item in myData1)
                            {
                                Console.WriteLine(item.OrderId + "\t" + item.OrdDetails.Item.PizzaName + "\t\t\t" + item.OrdDetails.Quantity + "\t" + item.OrdDetails.price + "\t" + item.OrderDate);
                            }

                            Console.WriteLine("Please enter the order id to cancel");
                            VerifySelection = false;
                            while (!VerifySelection)
                            {
                                while (!Int32.TryParse(Console.ReadLine(), out choice))
                                {
                                    Console.WriteLine("Invalid entry. Try again...");
                                }

                                if (OrderService.RemoveOrderDetails(choice))
                                {
                                    Console.WriteLine("Data Removed Sucessfully");
                                }
                                VerifySelection = true;
                            }
                                break;
                        case 4:
                            Console.WriteLine("You selected to Quit");
                            mainloop = true;
                            break;
                        default:
                            Console.WriteLine("Wrong Selection");
                            break;
                    }
                }
            }

            else
                Console.WriteLine("Invalid username or password");
        }

        private User TakeUserDetails()
        {
            User user = new User();
            Console.WriteLine("Are you a New User?");
            Console.WriteLine("Confirm Yes/No");
            bool confirmselection = false;
            string ch;
            while (!confirmselection)
            {
                ch = Console.ReadLine().ToLower();
                if (ch == "yes")
                {
                    Console.WriteLine("Please enter your username");
                    user.UserName = Console.ReadLine();
                    Console.WriteLine("Please enter your password");
                    user.Password = Console.ReadLine();
                    Console.WriteLine("Please enter your Address");
                    user.Address = Console.ReadLine();
                    userService.AddUser(user);
                    confirmselection = true;
                }
                if (ch == "no")
                {

                    Console.WriteLine("Please enter your username");
                    user.UserName = Console.ReadLine();
                    Console.WriteLine("Please enter your password");
                    user.Password = Console.ReadLine();
                    confirmselection = true;

                }

                if (!confirmselection)
                {
                    Console.WriteLine("Invalid entry. Try again...");
                }
            }
            return user;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.UserCheck();
            Console.ReadKey();
        }
    }
}