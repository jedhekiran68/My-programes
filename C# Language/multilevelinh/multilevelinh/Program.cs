class multilevelinh
{
    public void hospital()
    {

        Console.WriteLine("this is bharati vidyapeeth hospital");

    }
}
class icu 
{
    public void patient1()
    {
        Console.WriteLine("only emergency patients.");

    }

}

class jk : multilevelinh
{
    public void hospital()
    {
        Console.WriteLine("this is a multi level inheritane example.");
    
    }

}
class kj :icu
{
    public void patient1()
    {
        Console.WriteLine("this is a child class.");

    }

}




class program
{
    static void Main(string[] args)
    {

        jk kiran = new jk();
        kiran.hospital();
       
        kj je = new je();
        je.patient1();
    }


}