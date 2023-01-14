class program
{
    static void Main(string[] args)
    {
        try
        {
            string jk;
            jk = @"D:\file handling\text_wriiter";
            TextReader w1 = File.OpenText(jk);
            w1.ReadLine;
            w1.Close();

            Console.WriteLine("successfully run text writer");


        }
        catch (Exception)
        {
            Console.WriteLine("error occured");
        }

    }


}