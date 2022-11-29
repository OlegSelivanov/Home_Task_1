/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/

Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 != 1)
Console.WriteLine("Чётное!");

else 
Console.WriteLine("Не чётное!");