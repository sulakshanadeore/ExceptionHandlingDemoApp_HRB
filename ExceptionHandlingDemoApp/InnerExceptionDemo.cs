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
                Console.WriteLine("In the outer try...");
                Console.WriteLine("Outer try executed successfully...");
				try
				{
                    Console.WriteLine("Enter  a  string");
					s=Console.ReadLine();
					if (s == null) 
					{
						throw new NullReferenceException("string is null");
					
					}
	            }
				catch (NullReferenceException ex)
				{//inner catch
					if (!File.Exists("demo1.txt"))
					{
						throw new FileNotFoundException("File not found to write the exception",ex);
					}
				}
            }
			catch (Exception ex)
			{

				//outer catch
				if (ex.InnerException!=null)
				{
                    Console.WriteLine(string.Concat(ex.InnerException.StackTrace, ex.InnerException.Message));
                }
			}
			Console.ReadLine();
        }
		

    }
}
