using System.Text.Json.Serialization;

class singleinh
{
    public void jk()
    {

        Console.WriteLine("im kiran jedhe.");
    
    }


}
class kiran :singleinh
{
    public  void ak()
    {
        Console.WriteLine("this is single inheritance example.");
    
    }

}




class program
{
    static void Main(string[] args)
    {

        kiran kj = new kiran();
        kj.jk();
        kj.ak();
        
    
    }


}