using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemoApp
{
    internal class NestedTry
    {
        static void Main(string[] args)
        {
            UserLogin login = new UserLogin();
            try
            {
                Console.WriteLine("Enter username");
                login.UserName = Console.ReadLine().Trim();
                Console.WriteLine("Enter Password");
                login.Password = Console.ReadLine().Trim();
                login.Initialize();
                bool ans=login.ValidateUser(login.UserName,login.Password);
                Console.WriteLine("Login Successful");
                Console.ReadLine();
                Console.Clear();
                if (ans) {
                    try
                    {

                        Console.WriteLine("Enter Customer id");
                        int custid = 1;
                        Console.WriteLine("Enter Name");
                        string? name = null;

                        Customer c=new Customer(custid,name);

                        CustomerOperations custop = new CustomerOperations();
                        bool custStatus=custop.AddCustomer(c);
                        if (custStatus)
                        {
                            List<Customer> custs=custop.GetCustomers();
                            foreach (var item in custs)
                            {
                                Console.WriteLine(item.CustID);
                                Console.WriteLine(item.Name);
                            }
                        }

                    }
                    catch (DivideByZeroException zeroEx)
                    {
                        //inner
                        Console.WriteLine(zeroEx.Message);
                    }
                
                
                
                }

            }
            catch (ArgumentNullException arEx)
            {
                //outer
                Console.WriteLine(arEx.Message);
            }
            Console.ReadLine();
        }
    }
}
