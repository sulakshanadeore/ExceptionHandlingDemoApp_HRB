using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class UserLogin 
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public static List<UserLogin> list = new List<UserLogin>();


        public void Initialize()
        {
            list.Add(new UserLogin {UserName="Jack",Password="Jack@123" });
            list.Add(new UserLogin { UserName = "Jim", Password = "Jim@123" });
            list.Add(new UserLogin { UserName = "Jill", Password = "Jill@123" });

        }

        public bool ValidateUser(string username,string password)
        {
            bool LoginStatus = false;
            UserLogin user=list.Find(u => u.UserName == username);
            if (user != null)
            {
                if (user.Password == password)
                { 
                LoginStatus = true; 
                
                }


            }
            return LoginStatus; 
        }
    
    }



    public class Customer {
        public int CustID{ get;  set; }
        public string Name { get;  set; }

        public Customer()
        {
                
        }

        public Customer( int cid,string cname)
        {
            CustID = cid;
            Name = cname;   
        }

    }
    public class CustomerOperations
    {

        static List<Customer> custList = new List<Customer>();

        public CustomerOperations()
        {
            custList.Add(new Customer {CustID=2,Name="Ajinkya" });
        }


        public List<Customer> GetCustomers() {
        return custList;
        
        }

        public bool AddCustomer(Customer customer)
        {
            bool status = false;
            if (customer.Name != null)
            {
                custList.Add(customer);
                status = true;
            }
            else
            {
                throw new ArgumentNullException("Customer data not found");
            }
        return status;
        }

         public void FindCustomer(int id)
        {
            if (id <= 0)
            {
                throw new InvalidCustomerIDException("This customer id is not valid, couldn't find it...");
            }
            else {
                Console.WriteLine("Found customer");

            }
        
        }
    }
}
