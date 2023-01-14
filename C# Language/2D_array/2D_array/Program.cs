class program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[3, 3];
        int i, j;
        Console.WriteLine("accept array no:");
        for (i = 0; i < 3; i++)
        {
            for (j=0;j<3;j++)

            arr[i, j] = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine(arr[i,j]);
        }
       
    }

}