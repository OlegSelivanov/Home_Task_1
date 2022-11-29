/* Задача 2: Напишите программу, которая на вход принимает 
 два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.Clear();

Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

while (n == m)
{
   Console.WriteLine("Числа равны! Введите первое число: ");
   n = Convert.ToInt32(Console.ReadLine());

   Console.WriteLine("Введите второе число: ");
   m = Convert.ToInt32(Console.ReadLine()); 
}

if (n > m)
{
   Console.WriteLine($"Большее = {n}");
   Console.WriteLine($"Меньшее = {m}");
}
else
{
   Console.WriteLine($"Большее = {m}");
   Console.WriteLine($"Меньшее = {n}");
}