class program
{
    static void Main(string[] args)
    {
        try
        {
            string jk;
            jk = @"D:\file handling\text_wriiter";
            TextWriter w1 = File.CreateText(jk);
            w1.WriteLine("this is a textWriter example");
            w1.Close();

            Console.WriteLine("successfully run text writer");


        }
        catch (Exception)
        {
            Console.WriteLine("error occured");
        }

    }


}