//Написать программу упорядочивания по убыванию элементов каждой строки двумерной массива.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = array[i, j];
            int indexMax = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > max)
                {
                    max = array[i, k];
                    indexMax = k;
                }
            }
            int temp = array[i, j];
            array[i, j] = array[i, indexMax];
            array[i, indexMax] = temp;
        }
    }
}
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);