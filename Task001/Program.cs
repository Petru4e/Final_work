Console.WriteLine("Hello, World!");
Console.WriteLine("Enter any words separated by a space");
string[] words = Console.ReadLine()!.Split(" ");

PrintArray(ArraySort(words));

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

string[] ArraySort(string[] array)
{
    int lengthResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i].Length!=0) lengthResult++;
    }

    string[] result = new string[lengthResult];
    lengthResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i].Length!=0)
        {
            result[lengthResult] = array[i];
            lengthResult++;
        }
    }
    return result;
}