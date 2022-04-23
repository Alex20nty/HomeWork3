Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int i = 0;

while(i < N)
{
    i++;
    count = i*i;
    Console.WriteLine(count);
}
