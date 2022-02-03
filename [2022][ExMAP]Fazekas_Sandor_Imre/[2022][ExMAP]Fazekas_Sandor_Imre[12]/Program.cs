using System;
using System.IO;

namespace _2022__ExMAP_Fazekas_Sandor_Imre_12_
{
    class Program
    {
        public static int n, m, x, y, nrCrt;
        public static int[] v;
        public static int[,] a;
        public static string output = "";

        static void Main(string[] args)
        {            
            FileStream fs = new FileStream(@"data.in", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            n = int.Parse(sr.ReadLine().Trim());
            v = new int[n + 1];
            a = new int[n + 1, n + 1];

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine().Trim();
                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                x = int.Parse(parts[0]);
                y = int.Parse(parts[1]);

                a[x, y] = 1;
                a[y, x] = 1;
                m++;
            }

            for (int i = 1; i <= n; i++)
            {
                if (v[i] == 0)
                {
                    Dfs(i, nrCrt + 1);
                    nrCrt++;
                }
            }
                
            output += nrCrt - 1 + Environment.NewLine;
            for (int i = 2; i <= nrCrt; i++)
            {
                int rez = 0;

                for (int j = 1; j <= n && rez == 0; j++)
                {
                    if (i == v[j])
                        rez = j;
                }
                output += 1 + " " + rez + Environment.NewLine;
            }
            output += Environment.NewLine;
            CreateAndWriteFile(output);
        }

        public static void CreateAndWriteFile(string content)
        {
            File.WriteAllText(@"C:\Users\Sami\source\repos\[2022][ExMAP]Fazekas_Sandor_Imre[12]\dataOut.out", content);
        }

        public static void Dfs(int x, int val)
        {
            v[x] = val;

            for (int i = 1; i <= n; i++)
            {
                if (v[i] == 0 && a[x, i] == 1)
                {
                    Dfs(i, val);
                    v[i] = val;
                }
            }                
        }
    }
}
