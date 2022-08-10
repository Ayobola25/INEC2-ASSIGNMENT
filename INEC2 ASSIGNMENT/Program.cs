namespace INEC2_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> votersName = new SortedSet<string>();

            votersName.Add("joy");
            votersName.Add("victor");
            votersName.Add("joy");
            votersName.Add("victor");
            votersName.Add("peace");
            votersName.Add("yinka");
            votersName.Add("joy");
            votersName.Add("tola");
            votersName.Add("femi");
            votersName.Add("precious");
            votersName.Add("joy");
            votersName.Add("tosin");
            
            
            
            
            
            
            Console.WriteLine("enter voter name");
            string newName = Console.ReadLine();


            if (votersName.Contains(newName))
            {
                Console.WriteLine("Voter already exists");
            }
            else
            {
                votersName.Add(newName);
                Console.WriteLine("User successfully added");

            }
        }
    }
}