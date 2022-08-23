/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
M = 1; N = 9. -> "3, 6, 9" M = 13; N = 20. -> "15, 18"*/



Console.Write("Введите N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (M>N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");
