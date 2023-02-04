// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int row1 = new Random().Next(2,5);
int col1 = new Random().Next(2,5);
int row2 = new Random().Next(2,5);
int col2 = new Random().Next(2,5);
int[,] matr1 = new int[row1,col1];
int[,] matr2 = new int[row2,col2];
Console.WriteLine("Первая матрица");
NewArray(matr1, row1, col1);
WriteArray(matr1, row1, col1);
Console.WriteLine("Вторая матрица");
NewArray(matr2, row2, col2);
WriteArray(matr2, row2, col2);
if (col1 == row2)
{
    int [,] array1 = new int [row1,col2];
    MultArray(matr1,matr2,array1);
    Console.WriteLine("Произведение матриц");
    WriteArray(array1, row1, col2);
} else if (col2 == row1)
{
    int [,] array2 = new int [row2,col1];
    MultArray(matr2,matr1,array2);
    Console.WriteLine("Произведение матриц");
    WriteArray(array2, row2, col1);
} else Console.WriteLine("Произведения матриц не существует");
void NewArray (int[,] array, int row, int col)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(1,15);
        }   
    }
}
void WriteArray (int[,] array,int row, int col)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void MultArray(int[,] arr1, int[,] arr2, int [,] array)
{   
    int d = array.GetLength(0);
    int c = array.GetLength(1);
    int e = arr1.GetLength(1);
    for (int i = 0; i < d; i++)
    {
        for (int j = 0; j < c; j++)
        {
            int sum = 0;
            for (int k = 0; k < e; k++)
                {
                    sum += (arr1[i,k] * arr2[k,j]); 
                }
            array[i,j]=sum;
        }
    }
}
