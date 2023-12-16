//Бесконечный цикл.
while(true)
{
// Ввод числа
Console.WriteLine("Введите букву q или число с четной суммоу для прекращения работы программы");
//Получение данных с консоли.
string input = Console.ReadLine();
//Проверка является введенное сообщение "q"
if (input.ToLower() == "q")
{
Console.WriteLine("STOP");
break;
}
//Расчет суммы числа
int number = Convert.ToInt32(input);
int sum = 0;
while(number>0)
{
sum = sum + number%10;
number = number/10;
}
//Проверка четности суммы числа
if(sum%2 == 0)
{
Console.WriteLine("STOP")
break;    
}
else
{
Console.WriteLine("Сумма цифр числа нечетная");
}
}