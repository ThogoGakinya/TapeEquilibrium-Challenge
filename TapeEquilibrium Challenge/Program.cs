namespace TapeEquilibrium_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 1, 2, 4, 3 };
            solution(myArray);
        }
        public static int solution(int[] A) 
        {
            int N = A.Length;
            int totalSum = 0;
            int firstSum = 0;
            int secondSum = 0;
            int diffence = 0;
            int smallest = int.MaxValue;

            foreach (int i in A) 
            {
                totalSum += i;
            }
            for (int s = 0; s < N - 1; s++) 
            {
                firstSum += A[s];
                secondSum = Math.Abs(totalSum - firstSum);
                diffence = Math.Abs(firstSum - secondSum);
                smallest = Math.Min(smallest, diffence);
            }

            Console.WriteLine("The smallest value is {0}", smallest);
            return smallest;
        }
    }
}
