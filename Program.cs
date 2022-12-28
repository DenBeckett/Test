string[] array = {"hello","2","world",":)"};

//Console.WriteLine("Введите строки через пробел");
//string rows = Console.ReadLine();
//array = rows.Split(" ");

string[] resultArray = new string[array.Length];
int size = 0;
foreach (string row in array)
{
    if (row.Length <= 3)
    {
        resultArray[size] = row;
        size += 1;
    }
}

PrintArray(resultArray);

void PrintArray(string[] array)
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write($"{array[index]} ");
        index++;
    }
    Console.WriteLine();
}