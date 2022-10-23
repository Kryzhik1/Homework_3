// Показать кубы чисел, заканчивающихся на четную цифру.
Console.WriteLine("Введите число N >1: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Кубы числел, заканчивающихся на четную цифру: " );
int a = 1;
int b = 1;
while (a<=N)
{
    if (a%2 == 0)
    {
    b = a*a*a;
    Console.WriteLine(b);
    }
    a++;
}
