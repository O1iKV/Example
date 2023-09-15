//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int rows = ReadInt("Введите количество строк/столбцов: ");
int[,] array = new int[rows, rows];
int[,] secondArray = new int[rows, rows];
int[,] resultArray = new int[rows, rows];

Random(array);
PrintAr(array);

Console.WriteLine();

Random(secondArray);
PrintAr(secondArray);

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

void Random(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

PrintAr(resultArray);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintAr(int[,] array)
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