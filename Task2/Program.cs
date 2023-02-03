Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine() ??"0");
int remainder = 0;
while (numb >0)
{
    remainder=remainder+numb%10;
    numb = numb/10;
}
Console.WriteLine($"Сумма цифр числа равна {remainder}");
