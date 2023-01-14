using System.Security.Cryptography.X509Certificates;

class access_modifier
{
    public void get()
    {
        Console.WriteLine("this is a 'public' access modifier");
    }
    private void get1()
    {
        
       Console.WriteLine("this is a private access modifier.");
        
    }
  
}

// new class

class access
{
    private string name;
    public access()
    {
        name = "kiran";
     }
}
class jk : access
{
   
  Console.WriteLine(name);
    
}



class program
{ 
static void Main(string[] args)
    {
        access_modifier a1 = new access_modifier();
            a1.get();
            a1.get1();

    }

}