using System;
using System.IO;

namespace _2022__ExMAP_Fazekas_Sandor_Imre_15
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader file = new StreamReader(@"data.in");
            string[] dimensions = file.ReadLine().Split(' ');
            int n = int.Parse(dimensions[0]);
            int m = int.Parse(dimensions[1]);
            var matrix = new int[n, m];

            string buffer;
            int index = 0;
            int x = -1;

            while ((buffer = file.ReadLine()) != null)
            {
                var values = buffer.Split(' ');

                if (values.Length == 1)
                {
                    x = int.Parse(values[0]);
                    break;
                }

                for (int i = 0; i < values.Length; i++)
                {
                    matrix[index, i] = int.Parse(values[i]);
                }
                index++;
            }

            bool found = false;

            for (int i = 0; i < n; i++)
            {
                if (matrix[i, 0] == x || matrix[i, m - 1] == x)
                    found = true;
            }

            for (int j = 0; j < m; j++)
            {
                if (matrix[0, j] == x || matrix[n - 1, j] == x)
                    found = true;
            }

            CreateAndWriteFile(found ? "True" : "False");
        }

        public static void CreateAndWriteFile(string content)
        {
            File.WriteAllText(@"C:\Users\Sami\source\repos\[2022][ExMAP]Fazekas_Sandor_Imre[17]\dataOut.out", content);
        }
    }
}
