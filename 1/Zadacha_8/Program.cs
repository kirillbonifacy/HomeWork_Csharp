// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.



Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine()!);

int i = 1;
bool no = true;

Console.Write($"Чётные числа от 1 до {N}: ");
while (i <= N)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        no = false;
    }
i = i + 1;
}

if (no == true)
{
    Console.WriteLine("Нет чётных чисел!");
}
