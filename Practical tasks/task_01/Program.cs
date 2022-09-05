// 1. Найти произведение двух матриц

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    var rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            matrix[i,j] = rnd.Next(min, max);
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            Console.Write("{0,4}", matrix[i,j]);
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i=0; i<matrix1.GetLength(0); i++)
    {
        for(int j=0; j<matrix2.GetLength(1); j++)
        {
            int sum = 0;
            for(int k=0; k<matrix1.GetLength(1); k++)
            {
                sum = sum + matrix1[i,k] * matrix2[k,j];
            }
            newMatrix[i,j] = sum;
        }
    }
    return newMatrix;
}

Console.Clear();
int[,] matrix1 = CreateMatrix(2,3,0,5);
int[,] matrix2 = CreateMatrix(3,4,0,5);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
if(matrix1.GetLength(1)==matrix2.GetLength(0))
{
    int[,] newMatrix = MultiMatrix(matrix1, matrix2);
    PrintMatrix(newMatrix);
}
else Console.WriteLine("Матрицы нельзя перемножить");
