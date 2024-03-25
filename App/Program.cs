class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("hello");
        }
        //modyfikacja 3
    }

    public static double featureAverage(int[] tab)
    {
        double avg = 0;
        return avg;
    }

    public static int featureMax(int[] tab)
    {
        int maxi = tab[0];
        for (int i = 1; i < tab.Length; i++)
        {
            if (tab[i] > maxi)
            {
                maxi = tab[i];
            }
        }

        return maxi;
    }
}