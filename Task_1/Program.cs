// Найти кубы чисел от 1 до N.
Console.WriteLine("Введите число N>1: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Кубы чисел от 1 до N равны: " );
for (int a = 1; a <= N; a++)
{
Console.WriteLine(a*a*a );
}