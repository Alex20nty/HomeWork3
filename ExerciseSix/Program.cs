Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int i = 0;

while(i < N)
{
    i++;
    count = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write($" {count} ");
}

