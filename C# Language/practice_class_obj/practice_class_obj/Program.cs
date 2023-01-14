class practice                                                                // this is class
{
    public void get()                                                         // this is method 
    {
        Console.WriteLine("this is a class and object practice example");
    }
}
class Program
{
    static void Main(string[] args)
    {

        practice p1 = new practice();                              // this is object 
        p1.get();                                                  // call the method
        Console.WriteLine("succesfully execute");
    }

}