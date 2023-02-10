/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
Console.Clear();
Console.WriteLine("Размер массива строк :");
int str =int.Parse(Console.ReadLine());
Console.WriteLine("Размер массива столбцов :");
int col = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер строки");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = int.Parse(Console.ReadLine());
int [,] numbers = getArray(str, col);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine($"Число  в {n} строке и {m} столбце :  {numbers[n-1, m-1]}");
}

int[,] getArray(int str, int col)
{   
    int[,] array = new int[str, col];
    for (int i = 0; i < str; i++)
        {        
            for (int j = 0; j < col; j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }   
        }
return array;
}

void print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t ");
        }   
        Console.WriteLine(""); 
    }
}

print(numbers);
