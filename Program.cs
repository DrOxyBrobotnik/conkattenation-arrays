namespace concatenation_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new[] { 0, 1, 2, 3, 4 };
            var y = new[] { 4, 5 };

            var joinedArray = Conkatt(x, y);
            PrintArray(joinedArray);
        }

        private static void PrintArray(int[] array, [System.Runtime.CompilerServices.CallerArgumentExpression("array")] string arrayName = "")
        {
            Console.WriteLine($"{arrayName} = [{string.Join(", ", array)}]");
        }

        private static int[] Conkatt(int[] x, int[] y)
        {
            var z = new int[x.Length + y.Length];
            
            for (var i = 0; i < x.Length; i++)
                z[i] = x[i];

            for (var i = 0; i < y.Length; i++)
                z[i + x.Length] = y[i];

            return z;
        }
    }
}