//  using System;

// namespace NonSystemProgram
// {
//     class Program
//     {
//         // Основной метод программы.
//         static void Main()
//         {
//             Console.WriteLine("Введите целые числа. Введите 'q' для завершения или введите число с четной суммой цифр.");
//             // Начало бесконечного цикла.
//             while (true)
//             {
//                 // Выводим приглашение для ввода целого числа и считываем введенное значение в строку.
//                 Console.Write("Введите целое число: ");
//                 string input = Console.ReadLine();
//                 // Проверка, является ли введенное значение 'q', чтобы завершить программу.
//                 if (input.ToLower() == "q")
//                 {
//                     // Выводим сообщение "STOP" и выходим из цикла.
//                     Console.WriteLine("STOP");
//                     break;
//                 }
//                 // Проверка, является ли сумма цифр введенного числа четной, чтобы завершить программу.
//                 int number;
//                 if (int.TryParse(input, out number))
//                 {
//                     int sumOfDigits = CalculateSumOfDigits(number);
//                     if (sumOfDigits % 2 == 0)
//                     {
//                         // Выводим сообщение о четной сумме цифр и "STOP", затем выходим из цикла.
//                         Console.WriteLine($"Сумма цифр числа {number} четна. STOP");
//                         break;
//                     }
//                 }
//                 else
//                 {
//                     // Выводим сообщение об ошибке при вводе некорректного значения.
//                     Console.WriteLine("Некорректный ввод. Пожалуйста, введите корректное целое число или 'q' для завершения.");
//                 }
//             }
//         }
//         // Метод для вычисления суммы цифр числа.
//         static int CalculateSumOfDigits(int n)
//         {
//             int sum = 0;
//             // Получаем абсолютное значение числа, чтобы учесть отрицательные числа.
//             n = Math.Abs(n);
//             // Цикл для вычисления суммы цифр числа путем последовательного деления на 10 и суммирования остатков.
//             while (n > 0)
//             {
//                 sum += n % 10;
//                 n /= 10;
//             }
//             return sum;
//         }
//     }
// }

// Задача 2: Задайте массив заполненный случайными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в 
// массив

// Console.WriteLine("Введите размер массива");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];
// int result = 0;
// for(int i = 0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     Console.Write(array[i] + " ");
//     if(array[i]%2 == 0)
//     {
//         result = result + 1;
//     }
// }
// Console.WriteLine("");
// Console.WriteLine(result);

// Задача 3: Напишите программу, которая перевернёт 
// одномерный массив (первый элемент станет 
// последним, второй – предпоследним и т.д.)

Console.WriteLine("Введите размер массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int[] array1 = new int[num];
for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(10,100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for(int i = 0; i<array.Length; i++)
{
    array1[i] = array[array.Length - i - 1];
    Console.Write(array1[i] + " ");
}