// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// int n = InputNumbers("Введите значение N: ");
// int count = 2;
// PrintNumber(n, count);
// Console.Write(1);

// void PrintNumber(int n, int count)
// {
//     if (count > n) return;
//     PrintNumber(n, count + 1);
//     Console.Write(count + ", ");
// }

// int InputNumbers(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m = InputNumbers("Введите значение M: ");
// int n = InputNumbers("Введите значение N: ");
// int temp = m;

// if (m > n) 
// {
//   m = n; 
//   n = temp;
// }
// PrintSum(m, n, temp=0);

// void PrintSum(int m, int n, int sum)
// {
//   sum = sum + n;
//   if (n <= m)
//   {
//     Console.Write($"Сумма элементов = {sum} ");
//     return;
//   }
//   PrintSum(m, n - 1, sum);
// }
// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.WriteLine("Введите любое число M:");
int  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое число N:");
int  = Convert.ToInt32(Console.ReadLine());

int FindNOD(int maxValue, int minValue) 
{
     if(maxValue%minValue==0) return minValue;
     else return FindNOD(minValue,maxValue%minValue);   
  
}

Console.WriteLine((m >= n) ? $"Наибольшим общим делителем чисел {m} и {n} является {FindNOD(m, n)} " : $" Наибольшим общим делителем чисел {m} и {n} является {FindNOD(n, m)}");