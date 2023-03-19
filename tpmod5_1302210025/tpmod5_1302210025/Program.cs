// See https://aka.ms/new-console-template for more information

DataGeneric dataGeneric = new DataGeneric("1302210025");
dataGeneric.printData();
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