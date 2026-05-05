namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Testing the methods right here
            Console.WriteLine(Add(2, 3));    // it spits out 5            
            Console.WriteLine(Add(2.5m, 3.5m));  // it spits out 6        
            Console.WriteLine(Add(2, 3, true));  // when it runs 5 dollars        
            Console.WriteLine(Add(1, 0, true));   // one dollar       
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isDollar)
        {
            int sum = num1 + num2;

            if (isDollar)
            {
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }

            return sum.ToString();
        }
    }
}
