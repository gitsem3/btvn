using System;

namespace DemoT2009M
{
    internal class Program
    {
        public static void demSo(int[] A, int[] B, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i] == B[j])
                    {
                        Console.WriteLine(A[i] + " ");
                    }
                }
            }
        }

        public static void Main(String[] args){
            int[] A ={1, 3, 4, 7, 13};
            int[] B ={1, 2, 4, 13, 15};
            demSo(A,B, A.Length, B.Length);
        }
    }
}