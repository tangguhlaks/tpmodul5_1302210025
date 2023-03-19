internal class Program
{
    private static void Main(string[] args)
    {
        HelloGeneric helloGeneric = new HelloGeneric();
        helloGeneric.SapaUser("Tangguh Laksana");
    }
}

class HelloGeneric
{
    public void SapaUser(string username)
    {
        Console.WriteLine("Halo User " + username);
    }
}