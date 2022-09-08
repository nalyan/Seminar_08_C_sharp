// 3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

Console.Clear();
int[,,] matrix = {{{10,11,12},{13,14,15}}, {{16,17,18},{19,20,21}}};
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        for(int k=0; k<matrix.GetLength(2); k++)
        {
            Console.Write($"{matrix[i,j,k]} ({i},{j},{k})  ");
        }
        Console.WriteLine();
    }
}
