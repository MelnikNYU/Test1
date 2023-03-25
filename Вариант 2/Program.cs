// Написать программу, которая из имеющегося массива формирует массив 
//из элементов менее 3 символов.
// "hello", "world", "2", ":-)"
// "1234", "1567", "-2", "computer science"
// "aaaa", "bbbb", "cccc"

var elements = new string[] { "hello", "world", "-2", ":-)" };
 
string[] group = Array.FindAll(elements, element => element.Length < 4);

foreach (var element in group) Console.WriteLine(element);

