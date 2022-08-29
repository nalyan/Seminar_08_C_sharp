// В матрице чисел найти сумму элементов главной диагонали

void FillMatrix(int[,] matrix, int min, int max)
{
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(min, max);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0}\t", matrix[i,j]);
            }
    Console.WriteLine();
    }
    
}

Console.Clear();
int[,] matrix = new int[4,4];
FillMatrix(matrix, 1, 20);
PrintMatrix(matrix);

int sum = 0;
for(int i = 0; i < matrix.GetLength(0); i++)
{
    sum = sum + matrix[i,i];
}
Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
