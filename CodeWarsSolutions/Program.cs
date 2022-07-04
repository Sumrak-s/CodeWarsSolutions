namespace CodeWarsSolutions
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] test1 = new int[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 };

            int[] test2 = new int[] { 0, 1, 1 };

            int[] result = new int[10];

            Array.Copy(test2, result, 3);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}