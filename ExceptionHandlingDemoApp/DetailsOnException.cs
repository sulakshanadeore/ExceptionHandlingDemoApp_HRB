using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemoApp
{
    internal class DetailsOnException
    {
        static void Main(string[] args)
        {
			int i;
			try
			{
				i = 0;
				Operations o=new Operations();
				o.Check(i);

			}
			catch (Exception ex)
			{
                Console.WriteLine("Stack trace= " + ex.StackTrace);
                Console.WriteLine("Source= " + ex.Source);
                
			}
			Console.ReadLine();
        }
    }

}
