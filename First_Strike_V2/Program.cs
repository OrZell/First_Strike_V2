using First_Strike_V2.Models;

namespace First_Strike_V2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Initialization.Init();
            Console.WriteLine(Initialization.aman.PrintReports());
            Console.WriteLine(Initialization.Hamas.PrintMembers());
        }
    }
}