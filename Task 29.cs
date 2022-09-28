//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void FillArray(int [] num )
{
 for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(1 , 20);
}

}
    
void PrintArray(int[] num )
{

for (int i = 0; i < num.Length; i++)
{
    Console.Write(num[i] + " ");
    
}

}
int size = 8;
int [] numbers =  new int [size];
 FillArray(numbers);
 PrintArray(numbers);