// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел  
// от 1 до N.  System.Console.Write("Введите число N: "); 
System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Таблица кубов чисел от 1 до " + n);
if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
              System.Console.WriteLine(Math.Pow(i, 3));
    }

    System.Console.WriteLine();
}
else { System.Console.WriteLine("Число N меньше единицы!"); }


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