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

Console.WriteLine($"Max {n}");

else

Console.WriteLine($"Max {m}");
