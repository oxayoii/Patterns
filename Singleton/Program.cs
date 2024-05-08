namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = User.GetInstance();
            user1.Username = "Tom";
            Console.WriteLine("Имя 1: " + user1.Username);
            
            User user2 = User.GetInstance();
            user2.Username = "Tim";
            Console.WriteLine("Имя 2: " + user2.Username);
        }
    }
}
