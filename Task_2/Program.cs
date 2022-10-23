// Подсчитать сумму цифр в числе.
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Сумма цифр в числе равна: " );
int a = N;
int sum = 0;
for (int i = 1; a != 0; i++)
{
    sum = sum + a%10;
    a = a/10;
}
Console.WriteLine(sum);




