// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Ack(number1,number2));
int Ack(int num1,int num2)
{
  if (num1==0)
  {
    return (num2+1);
  }
   if (num2==0)
   {
    return Ack(num1-1,1);
   }
    return (Ack(num1-1,Ack (num1,num2-1)));
}

