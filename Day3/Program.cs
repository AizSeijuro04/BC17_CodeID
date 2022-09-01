using static System.Console;
using Day3;
using System.Collections.Generic;

//MyCollections.InitList();
//MyCollections.InitStack();
//MyCollections.InitDictionary();
//MyCollections.InitHashSet();
//MyCollections.InitQueue();

/*
 * Declare Method List
 */

/*var list = new List<string>() {"Asep", "Budi", "Charlie" };
var students = MyCollections.GetStudent(ref list);

foreach (var item in students)
{
    Console.WriteLine($"{item}");
}*/

/*
 * LATIHAN
 */

//Nomor 1
/*var list = new List<int>() {1, 2, 5, 6, 9};
var list2 = new List<int>() { 1, 2, 3, 4 };
QuizLogicDay3.Nomor1(ref list, ref list2);*/

//Nomor 2
/*var list = new List<string>() { "A", "BB", "CCC", "DDDD" };
QuizLogicDay3.Reverse(ref list);*/

//Nomor 3
/*var list = new List<int>() {1, 1, 2, 3, 4, 1, 2, 3};
QuizLogicDay3.RemoveDuplicate(ref list);*/

//Nomor 4


//Nomor 5
var list1 = new List<string>() { "Mangga", "Apel", "Melon", "Pisang", "Sirsak", "Tomat", "Nanas", "Nangka", "Timun", "Mangga" };
var list2 = new List<string>() { "Bayam", "Wortel", "Kangkung", "Mangga", "Tomat", "Kembang Kol", "Nangka", "Timun" };
List<string> sameDifferent = LatihanDay3.ListSameDifferent<string>(ref list1, ref list2);


// no 7
/*var list = new List<int>() { 1, 2, 5, 6, 9 };
var list2 = new List<int>() { 1, 2, 3, 4 };
QuizLogicDay3.ListAddition(ref list, ref list2);*/



Console.ReadLine();
