// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] GetArray(int Length, int min, int max)
// {
//     int[] array = new int[Length];
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// int GetResult(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             result++;
//         }
//     }
//     return result;
// }
// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }
// int[] arr = GetArray(4, 100, 999);
// PrintArray(arr);
// System.Console.WriteLine("Количество четных элементов в массиве = " + GetResult(arr));


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] GetArray(int Length, int min, int max)
// {
//     int[] array = new int[Length];
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }
//     return array;
// }

// int GetResult(int[] array)
// {
//     int result = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         result += array[i];
//     }
//     return result;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }
// int[] arr = GetArray(4, -100, 100);
// PrintArray(arr);
// System.Console.WriteLine("Сумма элементов стоящих на нечетных пазициях в массиве = " + GetResult(arr));


//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


double[] GetArray(int Length, int min, int max)
 {
     double[] array = new double[Length];
     Random random = new Random();
     for (int i = 0; i < Length; i++)
     {
         array[i] = random.Next(min, max + 1);
     }
     return array;
 }

 double MaxNumberArray (double[]array)
{
    double max = array[0];
	for (int i = 0; i < array.Length; i++)
	{
		if (max < array[i])
		{
			max = array[i];
		}
	}
	return max;
}

double MinNumberArray (double[]array)
{
    double min = array[0];
	for (int i = 0; i < array.Length; i++)
	{
		if (min > array[i])
		{
			min = array[i];
		}
	}
	return min;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double [] arr = GetArray(4, 1, 100);
PrintArray(arr);
double max = MaxNumberArray(arr);
double min = MinNumberArray(arr);
double result = max-min;
Console.WriteLine("Разность между максимальным и минимальным элементом массива равна = " + result);	
