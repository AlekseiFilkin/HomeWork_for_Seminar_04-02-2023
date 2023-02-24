//Написать программу, которая обменивает элементы первой строки и последней строки
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ChangeRows(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = array[0, j];
        array[0, j] = temp;
    }
}
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeRows(array);
PrintArray(array);