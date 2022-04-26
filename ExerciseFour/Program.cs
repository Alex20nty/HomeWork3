int GetValue(string num)
{
    System.Console.WriteLine($"{num}: ");
    string getValueStr = Console.ReadLine()!;
    int value = Convert.ToInt32(getValueStr);
    return value;
}

int ReverseNumber(int numA)
{
    int a = 0;
    while(numA > 0)
    {
        a = a * 10 + numA % 10;
        numA = numA / 10;
    }  
    return a;      
}

int Num = GetValue("Номерочек");
int result = ReverseNumber(Num);
System.Console.WriteLine(result);

if(result == Num)
    {
        Console.WriteLine("Это полиндром");
    }
        else
            {
                System.Console.WriteLine("Это не полиндром");
            }