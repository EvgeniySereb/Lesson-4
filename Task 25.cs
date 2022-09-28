//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void result(Double a , Double b)
{
Double Stepen = Math.Pow(a , b);
Console.WriteLine(Stepen);
}


Console.WriteLine("ВВедите чило A");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ВВедите чило B");
double b = Convert.ToDouble(Console.ReadLine());
result(a , b);