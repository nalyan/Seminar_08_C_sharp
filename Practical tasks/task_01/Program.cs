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
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for(int i=0; i<matrix1.GetLength(0); i++)
    {
        for(int j=0; j<matrix1.GetLength(1); j++)
        {
            newMatrix[i,j] = matrix1[i,j] * matrix2[i,j];
        }
    }
    return newMatrix;
}
Console.Clear();
int[,] matrix1 = CreateMatrix(4,4,0,10);
int[,] matrix2 = CreateMatrix(4,4,10,20);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
if(matrix1.GetLength(0)==matrix2.GetLongLength(0) && matrix1.GetLength(1)==matrix2.GetLongLength(1))
{
    int[,] newMatrix = MultiMatrix(matrix1, matrix2);
    PrintMatrix(newMatrix);
}
else Console.WriteLine("Размеры массивов не совпадают");
