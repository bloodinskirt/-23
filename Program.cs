string[] newArray1 = new string[6] {"tfhj", "yyeuqui", "str", "uueuio", "qwe", "was"};
string[] newArray2 = new string[newArray1.Length];

void SizeCheck(string[] newArray1, string[] newArray2)
{
    int count = 0;
    for (int i = 0; i < newArray1.Length; i++)
    {
        if(newArray1[i].Length <= 3)
        {
            newArray2[count] = newArray1[i];
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

SizeCheck(newArray1, newArray2);
PrintArray(newArray2);