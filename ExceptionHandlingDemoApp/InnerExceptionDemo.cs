using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemoApp
{
    internal class InnerExceptionDemo
    {
        static void Main(string[] args)
        {
			string s;
			try
			{
				try
				{
					Console.WriteLine("In the outer try...");
					Console.WriteLine("Outer try executed successfully...");
					try
					{

						Console.WriteLine("Enter  a  string");
						s = Console.ReadLine();
						Customer cnew = new Customer() {CustID=1001,Name=null };
						if (cnew.Name == null)
						{

							throw new NullReferenceException(string.Concat(cnew.CustID.ToString(), cnew.Name));

						}
					}
					catch (ArgumentNullException ex)
					{//inner catch
						if (!File.Exists("demo1.txt"))
						{
							throw new FileNotFoundException("File not found to write the exception", ex);
						}
					}
				}
				catch (NullReferenceException ex)
				{
					Console.WriteLine("Came to outer try NullReferenceException");
					if (!File.Exists("demo1.txt"))
					{
						
						throw new FileNotFoundException("File not found to write the exception",ex);
					}
					
				}

				catch (Exception ex)
				{
					Console.WriteLine("Came to outer try Exception General");
					//outer catch
					if (ex.InnerException != null)
					{
						Console.WriteLine(ex.InnerException);
						Console.WriteLine(ex.InnerException.Message);
					}
				}
			}
			catch (Exception ex)
			{
                Console.WriteLine("Came to most  outer try Exception General");
                //outer catch
                if (ex.InnerException != null)
                {
					Console.WriteLine(ex.InnerException.StackTrace);
				Console.WriteLine(ex.InnerException.Message);
                }
            }
			Console.ReadLine();
        }
		

    }
}
