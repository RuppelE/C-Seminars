//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 10);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void SummLine(int[,] matrix)

// {
//     int minLine = 0;
//     int sumMinLine = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         sumMinLine += matrix[0, j];
//     }
//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
        
//         int sumLine = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sumLine += matrix[i, j];
//         }
        
//         if (sumMinLine > sumLine)
//         {
//             minLine = i;
//             sumMinLine = sumLine;
//         }
//     }
//     System.Console.WriteLine($"Строка с минимальной суммой элементов : {minLine + 1}");
// }

// int rows = ReadInt("Введите количество строк матрицы: ");
// int cols = ReadInt("Введите количество столбцов матрицы: ");
// System.Console.WriteLine();
// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);
// System.Console.WriteLine();
// SummLine(myMatrix);

//Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 10);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void SortMatrixMaxToMin(int [,] matrix) 
// {
// int temp = 0;
// int step = 0;
// while (step<matrix.GetLength(1)+1)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1)-1; j++) 
//         {
//             if (matrix[i,j]<matrix[i,j+1] )
//             {
//                 temp = matrix[i,j];
//                 matrix[i,j] = matrix[i,j+1];
//                 matrix[i,j+1] = temp;
//             }
//         }
//     }
// step++;   
// }

// }

// int rows = ReadInt("Введите количество строк матрицы: ");
// int cols = ReadInt("Введите количество столбцов матрицы: ");
// System.Console.WriteLine("Полученная матрица:");
// var myMatrix = GenerateMatrix(rows, cols);
// PrintMatrix(myMatrix);
// System.Console.WriteLine("Отсортированная матрица по убыванию элементов строк:");
// SortMatrixMaxToMin(myMatrix);
// PrintMatrix(myMatrix);


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void FillArraySpiral(int[,] array, int n)     
{
    int i = 0, j = 0;
    int value = 1;
    for (int m = 0; m < n * n; m++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)      
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int size = 4;
int[,] array = new int[size, size];
System.Console.WriteLine("Красивенький массив 4 на 4 заполненный по спирали: ");
FillArraySpiral(array, size);
PrintArray(array);