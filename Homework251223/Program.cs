// Задача 1: Задайте двумерный массив символов (тип char 
// [,]). Создать строку из символов этого массива. 

char[,] array = {
    {'a', 'b', 'c'},
    {'d', 'e', 'f'}
};
string GetStringFromArray()
{
    string str = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            str += array[i,j];
        }
    }
    return str;
}
Console.WriteLine(GetStringFromArray());

// Задача 2: Задайте строку, содержащую латинские буквы 
// в обоих регистрах. Сформируйте строку, в которой все 
// заглавные буквы заменены на строчные. 

Console.WriteLine("Введите строку");
string userInput = Console.ReadLine();
userInput = userInput.ToLower();
Console.WriteLine(userInput);

// Задача 3: Задайте произвольную строку. Выясните, 
// является ли она палиндромом.

Console.WriteLine("Введите строку");
string userInput = Console.ReadLine();
bool IsPalindrome(string str)
{
    for (int i = 0, j = userInput.Length - 1; i < j; i++, j--)
    {
        if(userInput[i] != userInput[j])
        {
            return false;
        }
         
    }
return true;
}
if (IsPalindrome(userInput))
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }

// Задача 4*(не обязательная): Задайте строку, состоящую 
// из слов, разделенных пробелами. Сформировать строку, 
// в которой слова расположены в обратном порядке. В 
// полученной строке слова должны быть также разделены 
// пробелами.

Console.Write("Введите строку: ");
string input = Console.ReadLine();
string[] words = input.Split(' ');
Array.Reverse(words);
string reversedString = string.Join(" ", words);
Console.WriteLine("Результат: " + reversedString);
