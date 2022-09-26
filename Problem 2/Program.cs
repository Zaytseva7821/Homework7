// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
int RequeredM  = DataEntry("В какой строке находится ваше число?");
int RequeredN  = DataEntry("В каком столбце находится ваше число?");
// if (RequeredM < Array.GetLength(0) && RequeredN < Array.GetLength(1))
// {
System.Console.WriteLine(Array[RequeredM-1,RequeredN-1]);
// }
// else
// {
//     System.Console.WriteLine("В массиве нет числа с таким индексом");
// }
// Закомментировала опциональную часть: Программа сама ведь начинает ругаться, 
// если ищем элемент, вне пределов массива. Но, если принципиально, я написала.  