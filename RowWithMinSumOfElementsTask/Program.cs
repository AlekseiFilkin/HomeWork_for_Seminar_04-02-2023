//В прямоугольной матрице найти строку с наименьшей суммой элементов.
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
int[] SumArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumArray[i] = sum;
    }
    return sumArray;
}
void PrintSum(int[] sumArray)
{
    for (int i = 0; i < sumArray.GetLength(0); i++)
    {
        Console.WriteLine($"Сумма {i} строки: {sumArray[i]}");
    }
}
int[] SearchMin(int[] sumArray)
{
    int[] arrayMin = new int[sumArray.Length];
    for (int i = 0; i < arrayMin.Length; i++)
    {
        arrayMin[i] = -1;
    }
    int min = sumArray[0];
    int indexMin = 0;
    for (int i = 1; i < sumArray.Length; i++)
    {
        if (sumArray[i] < min)
        {
            min = sumArray[i];
            indexMin = i;
        }
    }
        for (int i = 0; i < sumArray.Length; i++)
    {
        if (sumArray[i] == min)
        {
            arrayMin[i] = i;
        }
    }
    return arrayMin;
}
void PrintMin(int[] arrayMin)
{
    for (int i = 0; i < arrayMin.Length; i++)
    {
        if (arrayMin[i] != -1) Console.Write($"{i} ");
    }
}
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[m, n];
if (m != n) Console.WriteLine("Матрица не прямоугольная.");
else {
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[] sumArray = SumArray(array);
PrintSum(sumArray);
Console.WriteLine();
int[] arrayMin = SearchMin(sumArray);
Console.WriteLine($"Строки с наименьшей суммой элементов:");
PrintMin(arrayMin);
}