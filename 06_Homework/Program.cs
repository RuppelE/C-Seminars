//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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
//         if (array[i] > 0)
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
// System.Console.WriteLine("Введите размер массива: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] arr = GetArray(number, -100, 100);
// PrintArray(arr);
// System.Console.WriteLine("Количество элементов в массиве больше 0 = " + GetResult(arr));


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

double ResultX(double b1, double k1, double b2, double k2)
{
    return (b2-b1)/(k1-k2);
}
double ResultY(double b1, double k1, double b2, double k2)
{
    return (k2 * b1 - k1 * b2)/(k2 - k1);
}

double x = ResultX(b1,k1,b2,k2);
double y = ResultY(b1,k1,b2,k2);
x = Math.Round(x, 3);
y = Math.Round(y, 3);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} Точка пересечения заданных прямых-> ({x}; {y})");



