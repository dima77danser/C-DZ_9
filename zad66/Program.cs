// Задача 66: Задайте значения M и N.
 //Напишите программу, которая найдёт сумму натуральных элементов
 // в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNum(number1,number2));
int PrintNum(int num1,int num2)
{
  if (num1>num2)
  {
    Console.WriteLine("net reweniq");
    return 0;
  }
   if (num1==num2)
   {
    return num1;
   }
    return (num1+PrintNum(num1+1,num2));
}




