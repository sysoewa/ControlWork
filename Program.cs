void CreateSecondArray(string[] array)
{
    string[] newarray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[i] = array[i]; ;
            Console.WriteLine(newarray[i]);
        }
    }
    Console.WriteLine();
}

void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
    Console.WriteLine();
}

string[] array = { "hello", "2", "world", ":-)" };

Print(array);
CreateSecondArray(array);