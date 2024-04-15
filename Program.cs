Console.WriteLine("Введите элементы массива через запятую:");
string[] Array = Console.ReadLine().Split(',');

string[] newArray = new string[Array.Length];
int newArrayIndex = 0;

foreach (string str in Array)
{
    if (str.Length <= 3)
    {
        newArray[newArrayIndex] = str;
        newArrayIndex++;
    }
}

if (newArrayIndex > 0)
{
    Console.WriteLine("Результат:");
    for (int i = 0; i < newArrayIndex; i++)
    {
        Console.WriteLine(newArray[i]);
    }
}
else
{
    Console.WriteLine("Вы что-то ввели не так.");
}