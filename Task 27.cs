//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void sum(int num)
{
var numbers = num.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
int result = numbers.Sum();
Console.WriteLine( "Сумма равна "+ result);

}



Console.WriteLine("Введите Число");
int number = Convert.ToInt32(Console.ReadLine());
sum(number);
