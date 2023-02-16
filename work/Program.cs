string[] array1 = new string[5] {"hello", "bay", "smile", "12", "365"};
string[] array2 = new string[array1.Length];

void SecondArrayWithIF(string[] array1, string[] array2, int num)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= num)
        {
        array2[count] = array1[i];
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

const int NUMBER = 3;
PrintArray(array1);
Console.WriteLine();
SecondArrayWithIF(array1, array2, NUMBER);
PrintArray(array2);