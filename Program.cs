string? yesNo = "";
while (yesNo != null && yesNo.ToLower() != "yes" && yesNo.ToLower() != "no")
{
    Console.Write("Желаете вводить строки вручную? (yes/no): ");
    yesNo = Console.ReadLine();
}

string[] array = new string[] { };

if (yesNo != null && yesNo.ToLower() == "yes")
{
    int n = InputNumbers("Введите количество элементов массива: ");
    array = new string[n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" Введите {i + 1} строку: ");
        array[i] = Console.ReadLine() ?? "";
    }
}
else
{
    array = new string[] { "hello", "2", "world", ":-)" };
}

int lengthLimit = 3;

int numbersItems = CheckArray(array, lengthLimit);

string[] newarray = new string[numbersItems];

FillNewArray(array, newarray, lengthLimit);

Console.WriteLine($"{PrintArray(newarray)}");


void FillNewArray(string[] oldarray, string[] newarray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldarray.Length; i++)
    {
        if (oldarray[i].Length <= lengthLimit)
        {
            newarray[temp] = oldarray[i];
            temp++;
        }
    }
}

int CheckArray(string[] array, int lengthLimit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit) result++;
    }
    return result;
}

string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += " ]";
    return result;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}