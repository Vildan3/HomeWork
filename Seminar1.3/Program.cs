int i = 1;
int n;

Console.WriteLine("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + n);
while (i <= n)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
    }
    i++;
}