//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите числа через пробел: ");
string numstring = Console.ReadLine();
string[] numbers = numstring.Split();

foreach (var num in numbers)
{
    Console.WriteLine($"{num}");
}

int[] MassInt = Array.ConvertAll(numbers, int.Parse);

void PrintArray(int[] MassInt)
{
    for (int i = 0; i < MassInt.Length; i++)
    {
        Console.Write($" {MassInt[i]} ");
    }
    Console.WriteLine();
}

int FindPositiveNum(int[] MassInt)
{
    int count = 0;
    for (int i = 0; i < MassInt.Length; i++)
    {
        
        if (MassInt[i] > 0)
        {
            count++;
        }
    }
    return count;
} 

PrintArray(MassInt);
Console.WriteLine(FindPositiveNum(MassInt));

