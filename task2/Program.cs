// В двумерном массиве n×k заменить четные элементы на противоположные
//распечатывание масива:
void PrintArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();    
    }
} 
//заполнение массива:
void FillArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); 
        }  
    }
} 
// проверка элемента на нечетность
void EvenToOposite(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j] % 2 == 0) matr[i,j] = - matr[i,j];
        }  
    }
}
Console.Clear();
Console.WriteLine("Введите кол-во строк: ");
int n = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите кол-во столбцов: ");
int k = int.Parse(Console.ReadLine()??"0");

int[,] matrix = new int [n,k];

FillArray(matrix);
Console.WriteLine("Начальный массив: ");
PrintArray(matrix);
EvenToOposite(matrix);
Console.WriteLine("Массив после замены нечетных элементов на противоположные: ");
PrintArray(matrix);
