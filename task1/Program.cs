// Показать двумерный массив размером m×n заполненный целыми числами
Console.Clear();
Console.Write("Введите количество строк двухмерного массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов двухмерного массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] arr = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i,j] = new Random().Next(-10,11);
        Console.Write($"{arr[i,j]} ");
    }
    Console.WriteLine();
}