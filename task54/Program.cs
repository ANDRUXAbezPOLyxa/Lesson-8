// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
int[,] GetArray(int m,int n)
{
int [,] fill = new int [m,n];
for (int i = 0; i < m;i++)
{
    for (int j = 0; j < n; j++)
    {
        fill[i,j] = new Random().Next(0,10);
    }
}
return fill;
}
void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0);i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i,j]);
    }
    Console.WriteLine();
}
}
int[,] array = GetArray(3,4);
PrintArray(array);
void NewArray (int [,] newarr)
{
for (int i = 0; i < array.GetLength(0);i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1)-1;k++)
        {
           if (array [i,k] < array [i,k+1])
            {
                int temp = array [i,k];
              array[i,k] = array [i,k+1];
               array[i,k+1] = temp;
            }

        }
    }
}
}
Console.WriteLine();
NewArray(array);
PrintArray(array);

