namespace ShoppingLibrary
{
    public class Operations
    {
        public void Check(int i)
        {
            if (i <= 0) 
            {
                throw new ArgumentException("This value is not accepted......");
            
            }
        
        }

        public void DoCalculation(int i, int j) 
        {
            try
            {
                int ans = i / j;
                Console.WriteLine(ans);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        
        }



    }
}
