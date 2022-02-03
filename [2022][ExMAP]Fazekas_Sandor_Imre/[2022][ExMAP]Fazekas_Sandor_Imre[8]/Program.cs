using System;
using System.IO;

namespace _2022__ExMAP_Fazekas_Sandor_Imre_8_
{
    class Program
    {
        public static int[] array = new int[9];
        public static string output = "";

        static void Main(string[] args)
        {
            TextReader file = new StreamReader(@"data.in");
            string[] dimensions = file.ReadLine().Split(' ');
            int n = int.Parse(dimensions[0]);
            int k = int.Parse(dimensions[1]);
            array = new int[k];
            Backtracking(n, k);
            CreateAndWriteFile(output);
        }

        public static void Backtracking(int n, int k, int position = 0)
        {
            for (int i = 0; i < n; i++)
            {
                array[position] = i;
                if (Verify(position, array))
                {
                    if (position == k - 1)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            output += array[j] + 1 + " ";
                        }
                        output += Environment.NewLine;
                    }
                    else
                    {
                        Backtracking(n, k, position + 1);
                    }
                }
            }
        }
        
        public static bool Verify(int position, int[] arr)
        {
            for (int i = 0; i < position; i++)
            {
                if (arr[position] == arr[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void CreateAndWriteFile(string content)
        {
            File.WriteAllText(@"C:\Users\Sami\source\repos\[2022][ExMAP]Fazekas_Sandor_Imre[8]\dataOut.out", content);
        }
    }
}
