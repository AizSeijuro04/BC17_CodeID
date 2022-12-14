using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class LatihanDay3
    {
        public static void ShowList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
        //Nomor 1
        public static List<T> Nomor1<T>(ref List<T> list1, ref List<T> list2)
        {
            var myList = list1;
            var yourList = list2;
            var result = new HashSet<T>(myList);
            result.IntersectWith(yourList);
            Console.WriteLine("Intersect : ");
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            var result2 = new HashSet<T>(myList);
            result2.UnionWith(yourList);
            Console.WriteLine("Union : ");
            foreach (var item in result2)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            var result3 = new HashSet<T>(myList);
            result3.ExceptWith(yourList);
            Console.WriteLine("Except : ");
            foreach (var item in result3)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            var result4 = new HashSet<T>(myList);
            result4.SymmetricExceptWith(yourList);
            Console.WriteLine("Symetric Except : ");
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            return myList;
        }

        //Nomor 2
        public static List<T> Reverse<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }

            Console.WriteLine("Element");
            foreach (var item in myList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            myList.Reverse();
            Console.WriteLine("Reverse : ");
            foreach (var item in myList)
            {
                Console.Write($"{item} ");
            }
            return myList;
        }

        //Nomor 3
        public static List<T> RemoveDuplicate<T>(ref List<T> list)
        {
            var myList = new List<T>();
            foreach (var item in list)
            {
                myList.Add(item);
            }

            Console.WriteLine("Element");
            foreach (var item in myList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            myList.Sort();
            var temp = myList.Distinct().ToList();
            Console.WriteLine("Distinct Element : ");
            foreach (var item in temp)
            {
                Console.Write($"{item} ");
            }
            return myList;
        }
        //Nomor 4


        //Nomor 5
        public static List<string> ListSameDifferent<T>(ref List<string> buah1, ref List<string> buah2)
        {
            var list1 = buah1;
            var list2 = buah2;
            var result = new HashSet<string>((IEnumerable<string>)list1);
            result.IntersectWith((IEnumerable<string>)list2);
            Console.Write("Same fruits: ");
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            var result2 = new HashSet<string>(list1);
            result2.ExceptWith(list2);
            Console.Write("Different Fruits: ");
            foreach (var item in result2)
            {
                Console.Write(item + " ");
            }
            var result3 = new HashSet<string>(list2);
            result3.ExceptWith(list1);
            foreach (var item in result3)
            {
                Console.Write(item + " ");
            }
            return list1;
        }

        //Nomor 6

    }
}
