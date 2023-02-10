  /*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
double[,] getArray(int m, int n, int min, int max)//Вещественные числа между min и max находит.Но вот min и max Формата double не получилось отправить в метод,только int
{
    double [,] array = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(rand.Next(min, max+1)*0.1, 1);
        }
    }
    return array;
}

void print(double[,] inArray)
{   
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ") ;
        }
    Console.WriteLine(" ");
    }   
}
int min = 0;
int max = 100;
Console.WriteLine("Введите кол-во строк ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов");
int n = int.Parse(Console.ReadLine()!);

double[,] array = getArray(m, n, min, max);
print(array);
