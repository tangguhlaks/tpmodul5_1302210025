
﻿internal class Program
{
    private static void Main(string[] args)
    {
        HelloGeneric helloGeneric = new HelloGeneric();
        helloGeneric.SapaUser("Tangguh Laksana");
        DataGeneric dataGeneric = new DataGeneric("1302210025");
        dataGeneric.printData();
    }
}

class HelloGeneric
{
    public void SapaUser(string username)
    {
        Console.WriteLine("Halo User " + username);
    }

}
class DataGeneric
{
    String t;
    public DataGeneric(String t)
    {
        this.t = t;
    }
    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah : " + t);
    }
    
}