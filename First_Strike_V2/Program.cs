using First_Strike_V2.Models;

namespace First_Strike_V2
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            //Initialization.Init();
            //Console.WriteLine(Initialization.aman.PrintReports());
            //Console.WriteLine(Initialization.Hamas.PrintMembers());

            string s = Console.ReadLine()!;
            GeminiAPI gym = new GeminiAPI(s);
            string t = await gym.requent("Give me 5 Name of arabian men and them ids like this kind {name: id}");
            Console.WriteLine(t);

        }
    }
}