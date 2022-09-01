using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustTest
{
    internal class FinalTes
    {
        //Nomor1
        public static int KatakLompat(int x, int y)
        {
            int jumpCount = 0;
            int k = 30;
            while (x + k <= y)
            {
                x = x + k;
                jumpCount++;
            }

            Console.Write(jumpCount);

            return jumpCount;
        }
        //Nomor2
        public static int Factorial(int n)
        {

            int fact = n;
            for (int i = n - 1; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.Write(fact);
            return fact;
        }

        //Nomor3
        public static int SumAll(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.Write(sum);
            return sum;
        }

        //Nomor4 & 5
        public static int Fibbonanci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            Console.Write(n2);
            for (int i = 1; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write($" {n3}");
                n1 = n2;
                n2 = n3;
            }
            return 0;
        }
        //Nomor 6
        public static bool CheckKurawal(string input)
        {
            bool output = false;
            char[] charInput = input.ToCharArray();
            int buka = 0, tutup = 0;

            for (int i = 0; i < charInput.Length; i++)
            {
                if (charInput[i] == '{')
                {
                    buka++;
                }
                else if (charInput[i] == '}')
                {
                    tutup++;
                }
            }

            if (buka == tutup)
            {
                output = true;
            }
            else
            {
                output = false;
            }

            Console.WriteLine(output);

            return output;
        }

        //Nomor 7
        public static bool IsAnagram(string input1, string input2)
        {
            bool output = false;
            input1 = input1.ToLower();
            input2 = input2.ToLower();
            char[] char1 = input1.ToCharArray();
            char[] char2 = input2.ToCharArray();
            var hs1 = new HashSet<char>(char1);
            var hs2 = new HashSet<char>(char2);

            return output;
        }

        //Nomor 8

    }
}
