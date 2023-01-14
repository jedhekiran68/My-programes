class program
{
    static void Main(string[] args)
    {
        int[,] a = new int[3, 3];
        int[,] b= new int[3, 3];

        int[,] c = new int[3, 3];
        int i, j;
        for (i = 0; i < 3; i++) ;
        {
            for (j = 0; j < 3; j++)
            {
                c[i, j] = a[i, j] + b[i, j];
            }
        }
    
    }
    }