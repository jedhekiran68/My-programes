class practice
{
    public void get()
    {
        int a; int b;int c;

    

        Console.WriteLine("enter a");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter b");
        b = Convert.ToInt32(Console.ReadLine());

        c = a + b;
       
        Console.WriteLine("Addition is"+"  "+ c);
    
    }

}
class program
{ 
static void Main(string[] args)
    {
        
        
        practice p1 = new practice();
        p1.get();

    }

}