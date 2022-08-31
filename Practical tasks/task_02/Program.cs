// 2. В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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
void FindMinIndex(int[,] matrix, out int ymin, out int xmin)
{
    int min = matrix[0,0];
    xmin = 0;
    ymin = 0;
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            if(matrix[i,j]<min) 
            {
                min = matrix[i,j];
                xmin = j;
                ymin = i;
            }
    }
}
int[,] DeleteMatrix(int[,] matrix, int ymin, int xmin)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int countY = 0;
    int countX = 0;
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        if(i==ymin) 
        {
            countY=1;
            continue;
        }
        for(int j=0; j<matrix.GetLength(1); j++)
        {    
            if(j==xmin) 
            {                
                countX=1;
                continue;
            }
            newMatrix[i-countY,j-countX] = matrix[i,j];
        }
        countX=0;
    }
    return newMatrix;
}

Console.Clear();
int[,] matrix = CreateMatrix(4,4,0,20);
PrintMatrix(matrix);
int ymin;
int xmin;
FindMinIndex(matrix, out ymin, out xmin);
int[,] newMatrix = DeleteMatrix(matrix, ymin, xmin);
PrintMatrix(newMatrix);
