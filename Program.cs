internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Full Name:");
        string fullName = Console.ReadLine();

        Console.WriteLine("Enter Your Birthday");
        string DOB = Console.ReadLine();

        Console.WriteLine("Enter Your Email");
        string Email = Console.ReadLine();

        Console.WriteLine("Enter Your GitHup Name");
        string gName = Console.ReadLine();

        Console.WriteLine("Full Name: " + fullName);
        Console.WriteLine("Day of Birth: " + DOB);
        Console.WriteLine("Email" + Email);
        Console.WriteLine("GitHup Name: " + gName);
        Console.WriteLine("Thank you");
        Console.Read();
    }
}