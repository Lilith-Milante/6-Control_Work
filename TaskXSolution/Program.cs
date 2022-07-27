string[] firstStringMassive = { "num", "345", "34", "3435", "35", "third", "-35", "nums" };
string[] secondStringMassive = new string[firstStringMassive.Length];

SelectWithThreeSym(firstStringMassive, secondStringMassive);
PrintArray(secondStringMassive);

void SelectWithThreeSym(string[] firstStringMassive, string[] secondStringMassive)
{
    int count = 0;
    for (int i = 0; i < firstStringMassive.Length; i++)
    {
        if (firstStringMassive[i].Length <= 3)
        {
            secondStringMassive[count] = firstStringMassive[i];
            count++;
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