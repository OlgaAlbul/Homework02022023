Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine() ??"0");
int cube;
for (int count = 1; count <= numb; count++)
{
    cube = count*count*count;
    Console.WriteLine($"Число {count} \t куб {cube}");
}

