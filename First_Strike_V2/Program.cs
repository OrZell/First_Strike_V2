using First_Strike_V2.Models;

namespace First_Strike_V2
{
    public class Program
    {
        public void Main(string[] args)
        {
            string key = Console.ReadLine()!;
            GeminiAPI gym = new GeminiAPI(key);
            Console.WriteLine(gym.Request("Give me 5 items like {{name: string name of arab man}, {rank: integer between 1 to 5}, {weapons: {randon many items from this array [AK47, M16, Gun, Knife]}}}"));
        }
    }
}