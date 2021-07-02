using PizzaOrderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderApp.Services
{
    public class UserService
    {
        readonly StoreContext _context;
        public UserService()
        {
            _context = new StoreContext();
        }


        public bool AddUser(User user)
        {
            //adds it to the local dbset
            _context.Users.Add(user);
            //makes the insert in to the database
            _context.SaveChanges();
            return true;
        }

        public bool UserLogin(User user)
        {
            try
            {
                User myUser = _context.Users.Single(u => u.UserName == user.UserName && u.Password == user.Password);
                if (myUser != null)
                {
                    user.UserId = myUser.UserId;
                    user.Address = myUser.Address;
                    return true;
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Null argument");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Could not find the user");//Always use a user friendly message
                Console.WriteLine(e.Message);//It might not be a user undertandable message
                Console.WriteLine(e.StackTrace);//Not for teh user only for teh developer
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops something went wrong...." + e.Message);
            }
            finally
            {
                Console.WriteLine("Always");
            }
            return false;
        }
    }
}
    

