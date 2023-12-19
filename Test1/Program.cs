while(true)
{
Console.WriteLine("Введите букву q или число с четной суммоу для прекращения работы программы");
string input = Console.ReadLine();
if (input.ToLower() == "q")
{
Console.WriteLine("STOP");
break;
}
int number = Convert.ToInt32(input);
int sum = 0;
while(number>0)
{
sum = sum + number%10;
number = number/10;
}
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