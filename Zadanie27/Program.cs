Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

int S(int a)
{
    int r = 0;
    while (a > 0)
    {
        int b = a % 10;
        a = a / 10;
        r = r + b;
    }
    return r;
}
Console.WriteLine(S(a));