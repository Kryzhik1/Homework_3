// Написать программу вычисления произведения чисел от 1 до N.
Console.WriteLine("Введите число N >1: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Произведение чисел от 1 до N равно: " );
int i = 1;
int comp = 1;
while (i <= N)
{
    comp = comp*i;
    i++;
}
Console.WriteLine(comp);