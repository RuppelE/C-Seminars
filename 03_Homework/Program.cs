// // Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел  
// // от 1 до N.  System.Console.Write("Введите число N: "); 
// System.Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Таблица кубов чисел от 1 до " + n);
// if (n > 0)
// {
//     for (int i = 1; i <= n; i++)
//     {
//               System.Console.WriteLine(Math.Pow(i, 3));
//     }

//     System.Console.WriteLine();
// }
// else { System.Console.WriteLine("Число N меньше единицы!"); }


// //Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// System.Console.WriteLine("Введите пятизначное число: ");
// string num = Console.ReadLine();
// if (num is not null )
// {
//     if (num.Length == 5) 
//     {
//         if ((num[0] == num[4]) && (num[1] == num[3]))
//         {
//             Console.WriteLine(num + " = полиндром");
//         }
//         else
//         {
//             Console.WriteLine(num + " = не полиндром");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Введено некоректное значение");
//     }
// }

//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
System.Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine("Расстояние между точками: "+ d);
