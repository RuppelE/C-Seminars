// Задача 10.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите трехзначное число: ");
// int num_A = Convert.ToInt32(Console.ReadLine());

// if (num_A > 99 && num_A <= 999)
// {
//     Console.WriteLine("Вторая цифра данного числа " + (num_A / 10) % 10);
// }
// else
// {
//     Console.WriteLine("Введенное число не удовлетворяет условию");
// }

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// while (num > 999)
// {
//     int result = num / 10;
//     num = result;
// }

// if (num < 1000 && num >= 100)
// {
//     int result2 = num % 10;
//     Console.WriteLine($"Третья цифра числа: {result2}");
// }

// else if (num < 100)
// {
//     Console.WriteLine("Третьей цифры нет");

// }

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите число обозначающее день недели: ");
int Day = Convert.ToInt32(Console.ReadLine());

if (Day==6 || Day==7)
{
    System.Console.WriteLine("сегодня выходной, ура ура");
}
else if (Day>7 || Day<1)
{
    System.Console.WriteLine("такого дня недели не существует");
}
else 
{
    System.Console.WriteLine("все еще будни");
}
