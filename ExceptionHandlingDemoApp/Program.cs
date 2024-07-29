﻿internal class Program
{
    private static void Main(string[] args)
    {
        //       Console.WriteLine("Hello, World!");

        int sno, fno,ans;

        try
        {
            Console.WriteLine("Etner a number");
            fno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            sno = Convert.ToInt32(Console.ReadLine());
            if (sno == 0)
            {

                throw new DivideByZeroException("Denominator cannot be zero.. pls enter non zero input...");

            }
            else
            {
                ans = fno / sno;
                Console.WriteLine(ans);
            }
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
        catch (Exception ex)
        {
            Console.WriteLine("Again... a wrong input.....");
            Console.WriteLine(ex.Message);

        }
        finally {
            Console.WriteLine("Hope u got the output... Pls confirm...");

        }



        Console.Read();



    }
}