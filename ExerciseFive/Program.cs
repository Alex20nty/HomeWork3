int GetValue(string text)
{
    System.Console.WriteLine($"{text}: ");
    string getValueStr = Console.ReadLine();
    int value = Convert.ToInt32(getValueStr);
    return value;
}

double Pifagor(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    return Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2));
}

int ax = GetValue("Ax");
int ay = GetValue("Ay");
int az = GetValue("Az");
int bx = GetValue("Bx");
int by = GetValue("By");
int bz = GetValue("Bz");
double result = Pifagor(ax, ay, az, bx, by, bz);
System.Console.WriteLine(result);