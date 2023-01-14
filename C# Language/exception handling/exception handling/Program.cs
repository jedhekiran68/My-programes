class exception
{
  public  void get()
    {
        try
        {
            int a = 100, b = 10, c;
            c = a / b;
            if(c==0)
                { Console.WriteLine("this is a correct no");}
            else { Console.WriteLine("this is incorrect no:"); }

        }
        catch(Exception )
        {

            Console.WriteLine("this is a catched called");
        }
        Console.WriteLine("this is a exception handling program ");
}

}
class program
{
    static void main(string[] args)
    { 
    exception e1=new exception();
        e1.get();
    
    }
}