// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[5, 5];
FillMatrixArray(array);
PrintMatrixArray(array);
Console.WriteLine(FindNumberInArray(array));



void FillMatrixArray(int[,] array)
{
    for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			array[i, j] = new Random().Next(0, 100);
		}
	}
}

void PrintMatrixArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
	{
        Console.Write("[");
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
        Console.Write("]");
		Console.WriteLine();
	}
}

string FindNumberInArray(int[,] array)
{
    if (n > array.GetLength(0) || m > array.GetLength(1))
    {
        return $"{m},{n} -> такого элемента нет";
    }
    else
    {
        return $"значение элемента {m} строки и {n} столбца равно {array[m-1,n-1]}";
    }
}
