// 4. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

int InputNumber (string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void PrintMatrix (int[,] matrix)
{
    int step = 3;
    int position = 0;
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        position = position + step;
        Console.SetCursorPosition(Console.WindowWidth/2-position,2+i);

        for(int j=0; j<matrix.GetLength(1); j++)
        {
            if(matrix[i,j]!=0) Console.Write("{0,6}", matrix[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
int n = InputNumber("Введите количество строк: ");
int[,] matrix = new int[n,n];
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        if(i==0)
        {
            matrix[i,j] = 1;
            break;
        }
        else if(j==0)
        {
            matrix[i,j] = 1;
        }
        else if(matrix[i-1, j-1]==1 && matrix[i-1, j]==0)
        {
            matrix[i,j] = 1;
            break;
        }
        else
        {
            matrix[i,j] = matrix[i-1, j-1] + matrix[i-1, j];
        }
    }
}
PrintMatrix(matrix);