using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class CustomerOperations
    {

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
