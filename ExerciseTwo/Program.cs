int GetValue(string text)
{
    System.Console.WriteLine($"{text}: ");
    string getValueStr = Console.ReadLine();
    int value = Convert.ToInt32(getValueStr);
    return value;   
}

double Pifagor(int ax, int ay, int bx, int by)
{
    return Math.Sqrt((bx - ax)*(bx - ax) + (by - ay)*(by - ay));
}

int Ax = GetValue("Ax");
int Ay = GetValue("Ay");
int Bx = GetValue("Bx");
int By = GetValue("By");
double result = Pifagor(Ax, Ay, Bx, By);
System.Console.WriteLine(result);
