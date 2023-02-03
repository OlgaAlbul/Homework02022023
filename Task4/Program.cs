Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine() ??"0");
int cube;
int count = 1;
while (count <= numb)
{
    cube = count*count*count;
    if (cube%2==0)
    {
        Console.WriteLine($"Число {count} \t куб {cube}");
        count++;
    }
    else
    count++;
}
