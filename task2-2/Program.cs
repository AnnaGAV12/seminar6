//В двумерном массиве n×k заменить четные элементы на противоположные
// Заполнение массива
void FillArray(int[,] array)
{
    Random rnd = new Random();
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i=0; i<rowsLength; i++)
    {
        for (int j=0; j<columnsLength; j++)
        {
            array[i,j]=rnd.Next(-100,100);
        }
    }
}
// Изменение массива
void ChangeEvenElements(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i=0; i<rowsLength; i++)
    {
        for (int j=0; j<columnsLength; j++)
        {
            if(array[i,j]%2==0) array[i,j]= - array[i,j];
        }
    }
}
// Печать массива
void PrintArray(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i=0; i<rowsLength; i++)
    {
        for (int j=0; j<columnsLength; j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()??"0");

int[,] array = new int [rows,columns];

FillArray(array);
Console.WriteLine("Начальный массив: ");
PrintArray(array);
ChangeEvenElements(array);
Console.WriteLine("Массив после замены нечетных элементов на противоположные: ");
PrintArray(array);
