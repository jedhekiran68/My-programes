class program
{ 
static void Main(string[] args)
    {
        try 
        {
            string jedhe;
            jedhe = @"D:\file handling\w_line";

            StreamWriter s1=new StreamWriter(jedhe);
            s1.Write("this is a write Line method practice example");

            s1.Close();

            Console.WriteLine("successfully run");
        }
        catch (Exception ) 
        {
            Console.WriteLine("error occured");
        }
    }

}