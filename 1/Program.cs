void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = new Random().Next(1,10);
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

void RMatrix(int[,] matrix)
{
Console.Write("Введите индекс элемента: ");
int[] i = Console.ReadLine().Split(" ").Select(y => int.Parse(y)).ToArray();
        if (i[0] > matrix.GetLength(0) || i[1] > matrix.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
        else
    {
        Console.WriteLine(matrix[i[0], i[1]]);
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
RMatrix(matrix);

