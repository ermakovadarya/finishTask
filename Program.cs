/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не реком-зндуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
["'hello", "2", "world", " -)"] -> ["2", ":-)"]
['1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] stringArray={"hello", "2", "world", "-)", "qwe"};
Console.WriteLine($"{String.Join(", ",stringArray)}"); 
string[] resultArray=NewArray(stringArray);
Console.WriteLine($"[{String.Join(", ",resultArray)}]");

string[] NewArray(string[] arr)
{
    string[] result=new string[]{};
    int j=0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i].Length<=3)
        {
            Array.Resize(ref result,result.Length+1);
            result[j]=arr[i];
            j++;
        }
    }
    return result;
}