*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();
Console.WriteLine("введите количество строк");
int str = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int col = int.Parse(Console.ReadLine());
int[,] numbers = new int[str, col];

void findAverageNumber(int[,] inArray)
{
double number = 0;
Console.WriteLine($"Cреднее арифметическое столбцов :");
for (int j = 0; j < numbers.GetLength(0); j++)
{ 
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        number += numbers[i, j];
    }
    number = number / str;
    Console.Write($"{Math.Round(number,2)}\t ");
}
}

void getArray(int[,] inArray)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

void print(int[,] inArray)
{

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]}\t ");
        }
        Console.WriteLine("");
    }
}

getArray(numbers);
print(numbers);
findAverageNumber(numbers);
