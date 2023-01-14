class program
{
    static void Main(string[] args)

    {
        try
        {
            int jk;
            jk = @"D:\file handling\w_line";

            StreamReader s1 = new StreamReader(jk);

            int jedhe;
            while ((jedhe = s1.Read()) != null) ;
            {
                Console.WriteLine(jedhe);
            }

        }
        

        Catched(Exception)

            {
            Console.WriteLine("error occured");

        }
    }
}
