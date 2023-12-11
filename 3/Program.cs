
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}
int MinS(int[,] matrix)

{
    int sum = 0;
    int a = 0;
    
    for (int j = 0; j < matrix.GetLength(1); j++) 
    sum = sum + matrix[0,j];
    int min = sum;
    Console.WriteLine(sum);
    
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        Console.WriteLine(sum);
        if (min > sum)
        {
            min = sum;
            a = i;
        }
    }
    return a;
}
Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
int min1 = MinS(matrix);
Console.Write ("Минимальная сумма на строке с индексом "+ min1);
