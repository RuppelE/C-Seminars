//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// void SumNaturalNumbers(int m, int n, int sum)
// {
//     if (m > n)
//     {
//         Console.WriteLine($"Сумма натуральных элементов от M до N: {sum}");
//         return;
//     }
//     sum = sum + (m++);
//     SumNaturalNumbers(m, n, sum);
// }

// System.Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// SumNaturalNumbers(m, n, sum);

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akerman(int n, int m)
{
    if (n == 0) return m + 1;
    else
        if ((n != 0) && (m == 0)) return Akerman(n - 1, 1);
        else return Akerman(n - 1, Akerman(n, m - 1));
}

System.Console.Write("Введите неотрицательно число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Функция Аккермана: "+ Akerman(n,m));