// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int DataEntry(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillDoubleMatrix(double[,] Matrix)
{
    for(int i = 0; i < Matrix.GetLength(0); i++)
    {
        for(int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i, j] = Math.Round(new Random().NextDouble()*200, 2);
            System.Console.Write($"{Matrix[i, j]} ");
        }
    System.Console.WriteLine();
    }

}

int m = DataEntry("Сколько строк будет в вашем массиве?");
int n = DataEntry("Сколько столбцов будет в вашем массиве?");
double [,] Array = new double [m, n];
System.Console.WriteLine("Ваш массив:");
FillDoubleMatrix(Array);