class arrayFreq
{
    public static void countFreq(int[] arr, int n)
    {
        bool[] visited = new bool[3];

        for (int i = 0; i < n; i++)
        {
            if (visited[i] == true)
                continue;

            int count = 1;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    visited[j] = true;
                    count++;
                }
            }
            Console.WriteLine(arr[i] + " " + count);
        }
    }
    public static void Main(String[] args)
    {
        int[] arr = new int[] { 1, 1, 0 };
        int n = arr.Length;
        countFreq(arr, n);
    }
}