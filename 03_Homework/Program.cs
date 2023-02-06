// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел  
// от 1 до N.  System.Console.Write("Введите число N: "); 
System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Таблица кубов чисел от 1 до " + (n));
if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
              System.Console.WriteLine($"{Math.Pow(i, 3)} ");
    }

    System.Console.WriteLine();
}
else { System.Console.WriteLine("Число N меньше единицы!"); }