// Написать программу, которая из имеющегося массива формирует массив 
//из элементов менее 3 символов.
// "hello", "world", "2", ":-)"
// "1234", "1567", "-2", "computer science"
// "aaaa", "bbbb", "cccc"

string[] array1 = new string[5] {":-j", "03", "hello", "world", "aaaa"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[i] = array1[i];
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);
