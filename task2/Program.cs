/*   Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{
int number2 = number % 10;
number = number / 10;
sum = sum + number2;
}
Console.WriteLine($"сумма чисел равна:{sum}");