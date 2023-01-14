class program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[3, 3];

        int[,] array = new int[3, 3];

       
        int i, j;
        Console.WriteLine("accept array no:");
        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());


            }
        }

        for (i = 0; i < 3; i++)
        {
            for (j = 0; j < 3; j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());


            }
        }

        int[,] c = new int[3, 3];
        
        for (i = 0; i < 3; i++) ;
        {
            for (j = 0; j < 3; j++)
            {
                c[i, j] = arr[i, j] + array[i, j];
            }
        }





    }

}