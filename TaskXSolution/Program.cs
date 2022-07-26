string[] firstStringMassive = { "num", "345", "34", "3435", "35", "third", "-35", "nums" };
string[] secondStringMassive = new string[firstStringMassive.Length];


PrintArray(secondStringMassive);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}