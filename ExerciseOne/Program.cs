// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка



Console.WriteLine("Введите х: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите у: ");
double y = Convert.ToDouble(Console.ReadLine());

if((x > 0) && (y > 0))
Console.WriteLine("1-я четверть ");
else
{
    if((x < 0) && (y > 0))
    Console.WriteLine("2-я четверть ");
    else
    {
        if((x < 0) && (y < 0))
        Console.WriteLine("3-я четверть ");
        else
        {
            if((x > 0) && (y < 0))
            Console.WriteLine("4-я четверть ");
            else
            {
                if((x==0) || (y==0))
                Console.WriteLine("x ≠ 0 и y ≠ 0");
            }
        }
    }
}

            
        
    

        
