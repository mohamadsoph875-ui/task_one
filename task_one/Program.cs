using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("islam carpetcleaning service");
            Console.WriteLine("sallery of large and small carpet");
            Console.WriteLine("small carpet 25 $");
            Console.WriteLine("large carpet 35 $");
            //sales tax rate is 6%
            //Estimates arevalid for 30 days

            //estimate for carpet cleaning service
            int s_number = Convert.ToInt32 (Console.ReadLine());
            int l_number = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine($"s_number :{s_number * 25} $");
            Console.WriteLine($"l_number :{l_number * 35} $");
            Console.WriteLine("cost=(3*25)+(1*35)= 110$" );
            // TAX: 6.6$
            Console.WriteLine("110+6.6 = 116.6$");

        }
    }
}
