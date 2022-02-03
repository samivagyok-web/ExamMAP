using System;
using System.IO;
using System.Linq;

namespace _2022__ExMAP_Fazekas_Sandor_Imre_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader file = new StreamReader(@"data.in");
            double[] firstVector = file.ReadLine().Split(' ').Select(p => double.Parse(p)).ToArray();
            double[] secondVector = file.ReadLine().Split(' ').Select(p => double.Parse(p)).ToArray();
            Coliniaritate(firstVector[0], firstVector[1], secondVector[0], secondVector[1]);
            ProdusVectorial(firstVector[0], firstVector[1], firstVector[2], secondVector[0], secondVector[1], secondVector[2]);
            VolumulParalelopipedonului(firstVector[0], firstVector[1], firstVector[2], secondVector[0], secondVector[1], secondVector[2]);
        }

        private static void ProdusVectorial(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double det1, det2, det3;
            det1 = (y1 * z2 - y2 * z1);
            det2 = (x2 * z1 - x1 * z2);
            det3 = (x1 * y2 - x2 * y1);
            
            Console.WriteLine($"Produs vectorial = {Math.Sqrt(Math.Pow(det1, 2) + Math.Pow(det2, 2) + Math.Pow(det3, 2))}");
        }

        private static void Coliniaritate(double xA, double yA, double xB, double yB)
        {
            double Det = xA * yB - xB * yA;
            
            if (Det == 0)
            {
                Console.WriteLine("Punctele sunt coliniare");
            }
            else
            {
                Console.WriteLine("Punctele nu sunt coliniare");
            }
        }

        private static void VolumulParalelopipedonului(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double prodmixt = (x1 * y2) + (x2 * z1) + (y1 * z2) - (y2 * z1) - (x1 * z2) - (x2 * y1);

            Console.WriteLine($"Volumul paralelipipedului este:{Math.Sqrt(Math.Pow(prodmixt, 2))}");
        }
    }
}
