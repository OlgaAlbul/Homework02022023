Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine() ??"0");
int res = 1;
for (int count = 1; count<=numb; count++)
{
    res = res*count;
}
Console.WriteLine($"Произведение чисел от 1 до {numb} равно {res}");