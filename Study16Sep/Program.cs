namespace Study16Sep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            string userName = GreetUser("Vad heter du?");
            Console.WriteLine($"Hej {userName} Du är {age}");
        }

        public static string GreetUser(string name)
        {
            Console.WriteLine($"Hej {name}");
            return name;
        }
   }
}
