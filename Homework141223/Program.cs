// Задача 1: Задайте одномерный массив из 10 целых
//чисел от 1 до 100. Найдите количество элементов
//массива, значения которых лежат в отрезке [20,90]. 

int[] array = new int[10];
int num = 0;
Console.WriteLine("Массив");
for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(1,100);
    Console.Write(array[i] + " ");
    if(array[i] > 19  && array[i] < 91)
    {
num = num + 1;
    }
}
Console.WriteLine();
Console.WriteLine("Количество эелентов массива, значения которых лежат в отрезке [20,90]");
Console.Write(num);

//Задача 2: Задайте массив на 10 целых чисел.
//Напишите программу, которая определяет
//количество чётных чисел в массиве.

int[] array = new int[10];
int num = 0;
Console.WriteLine("Массив");
for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(1,100);
    Console.Write(array[i] + " ");
if(array[i]%2 == 0)
{
    num = num + 1;
}
}
Console.WriteLine();
Console.WriteLine("Число четных чисел в массиве");
Console.WriteLine(num);

//Задача 3: Задайте массив из вещественных чисел с
//ненулевой дробной частью. Найдите разницу между
//максимальным и минимальным элементов массива.

double[] array = new double[5];
Console.WriteLine("Массив");
double num1 = 0;
double num2 = 1;
for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write(array[i] + " ");
    if(array[i]>num1)
    {
num1 = array[i];
    }
    if(array[i]<num2)
    {
num2 = array[i];
    }
}
double result = num1 - num2;
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна");
Console.WriteLine(result);

// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.

Console.WriteLine("Введите число в диапазоне от 1 до 100000");
int num = Convert.ToInt32(Console.ReadLine());
int i = 5;
int[] array = new int[i];
if(num>0)
{
    array[0] = num%10;
    num = num/10;
    i = i + 1;
}
if(num>0)
{
    array[1] = num%10;
    num = num/10;
    i = i + 1;
}
if(num>0)
{
array[2] = num%10;
    num = num/10;
    i = i + 1;
}
if(num>0)
{
   array[3] = num%10;
    num = num/10;
    i = i + 1;
if(num>0)
{
    array[4] = num%10;
    num = num/10;
    i = i + 1;
}
}
Console.WriteLine("Массив");
Console.Write("{");
if(array[4]>0)
{
Console.Write(array[4] + ", ");
}
if(array[3]>0)
{
Console.Write(array[3] + ", ");
}
if(array[2]>0)
{
Console.Write(array[2] + ", ");
}
if(array[1]>0)
{
Console.Write(array[1] + ", " + array[0] + "}");
}
//Решение с помощью string
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string newnum = "";
while(num>0)
{
    newnum = newnum + (num%10).ToString();
    num = num/10;
}
int i = newnum[newnum.Length-1];
Console.Write("{");
Console.Write(newnum[newnum.Length-1] + ", ");
for(i = 1; i<newnum.Length-1; i++)
{
    Console.Write(newnum[newnum.Length-i-1] + ", ");
}
    Console.Write(newnum[newnum.Length-i-1]);
    Console.Write("}");    
    