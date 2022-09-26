// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int DataEntry(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] Matrix)
{
    for(int i = 0; i < Matrix.GetLength(0); i++)
    {
        for(int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = new Random().Next(-999,999);
            System.Console.Write($"{Matrix[i, j]} ");
        }
    System.Console.WriteLine();
    }

}
int m = DataEntry("Сколько строк будет в вашем массиве?");
int n = DataEntry("Сколько столбцов будет в вашем массиве?");
int [,] Array = new int [m, n];
System.Console.WriteLine("Ваш массив:");
FillMatrix(Array);
System.Console.Write("Среднее арифметическое каждого столбца: ");
for(int i = 0; i < Array.GetLength(0); i++)
    {
        double Sum = 0;
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Sum += Array[i,j];
        }
        System.Console.Write($"{Sum/n} ");
    }