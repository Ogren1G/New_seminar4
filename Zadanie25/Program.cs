Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(S(a,b));
int S(int a, int b)
{
int r = a;
for (int i = 1; i < b; i++)

r = r * a;
return r;
}