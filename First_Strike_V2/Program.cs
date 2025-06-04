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

            string key = Console.ReadLine()!;
            GeminiAPI gym = new GeminiAPI(key);
            Console.WriteLine( await gym.Request("Give me 5 items like {{name: string name of arab man without any charters in it}, {rank: integer between 1 to 5}, {weapons: {randon many items from this array [AK47, M16, Gun, Knife]}}} and dont say anything else"));
        }
    }
}