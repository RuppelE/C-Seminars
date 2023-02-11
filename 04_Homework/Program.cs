// //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int GetNumbers(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int GetStepenNumbers(int numbers, int step) 
//  {
//     int result = 1;
//     for(int i=0; i<step; i++) 
//     {
//         result *= numbers;
//     }
//     return result;
//  }

//  int num = GetNumbers ("Введите число которое будете возводить в степень");
//  int stepen = GetNumbers("Введите степень");

// System.Console.WriteLine("Число "+ num +" в степени "+ stepen +" = "+ GetStepenNumbers(num,stepen));


// //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int GetNumber(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

//  int GetSumNumber(int A)
// {
//     int sum = 0;
//     string str = Math.Abs(A).ToString();
//     for(int i = 0; i < str.Length; i++)
//     {
//         int.TryParse(str[i].ToString(), out int num);
//         sum += num;
//     }
//     return sum;
// }

// int number = GetNumber("Введите число: ");
// System.Console.WriteLine("Сумма всех цифр числа = "+ GetSumNumber(number));


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 int GetNumbers(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int Length, int min, int max)
{
   int[] array = new int[Length];
   Random random = new Random ();
   for (int i = 0; i < Length; i++ )
   {
       array[i] = random.Next(min,max + 1);
   }
   return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int Lenght = GetNumbers("Введите длинну массива: ");
int max = GetNumbers("Введите максимальное число: ");
int min = GetNumbers("Введите минимальное число: ");

int [] array = GetArray (Lenght, min, max);
PrintArray(array);
