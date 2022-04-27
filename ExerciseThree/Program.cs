// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.


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
