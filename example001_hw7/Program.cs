// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
double[,] array = new double[rows, columns];
FillArrayRandomNumbers(array);
PrintArray(array);
void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}