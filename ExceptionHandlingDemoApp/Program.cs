using ShoppingLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        //       Console.WriteLine("Hello, World!");

        int sno, fno,ans;
        Operations op=new Operations(); 
        CustomerOperations c=new CustomerOperations();

        try
        {
            Console.WriteLine("Etner a number");
            int id = Convert.ToInt32(Console.ReadLine());
            c.FindCustomer(id);
            //Console.WriteLine("Enter a number");
            //sno = Convert.ToInt32(Console.ReadLine());
            //// op.Check(sno);
            //op.DoCalculation(fno, sno);

            //if (sno == 0)
            //{

            //    throw new DivideByZeroException("Denominator cannot be zero.. pls enter non zero input...");

            //}
            //else
            //{
            //    ans = fno / sno;
            //    Console.WriteLine(ans);
            //}
        }
        catch (FormatException ex)
        {

            //Console.WriteLine(ex.Message);
            Console.WriteLine("Enter a numeric value not a string.....");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Wrong input....");

        }
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        catch (InvalidCustomerIDException ex) 
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Again... a wrong input.....");
            Console.WriteLine(ex.Message);

        }
        finally
        {
            Console.WriteLine("Hope u got the output... Pls confirm...");

        }



        Console.Read();



    }
}