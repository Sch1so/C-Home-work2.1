//  Task 19

/*
bool Polydr(int num)
{
    int a = num;
    int polydr = 0;
    int ostatok;
    while(num % 10 != 0)
    {
        ostatok = num % 10;
        polydr = polydr * 10 + ostatok;
        num = num / 10;
    }
    if(a == polydr) return true;
    else return false;
}

Console.Write("Введите число на проверку полидромности: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Polydr(num));
*/


// Task 21

/*
double RangeCordinat(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double rangeX = x2 - x1;
    double rangeY = y2 - y1;
    double rangeZ = z2 - z1;
    double rangecord = Math.Sqrt(rangeX * rangeX + rangeY * rangeY + rangeZ * rangeZ);
    return rangecord;
}

Console.Write("Введите коордунату X первой точки - ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордунату Y первой точки - ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордунату Z первой точки - ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордунату X второй точки - ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордунату Y второй точки - ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коордунату Z второй точки - ");
double z2 = Convert.ToDouble(Console.ReadLine());

double otvet = Math.Round(RangeCordinat(x1, y1, z1, x2, y2, z2), 2);

Console.Write($"Расстояние между точками равно - {otvet}");
*/


// Task 23


/*
void Qub(int num)
{
    int index = 1;
    while(index <= num)
    {
        Console.WriteLine($"{index} -> {Math.Pow(index, 3)}");
        index++;
    }
}

Console.Write("Введите число для возведения в куб ");
int num = Convert.ToInt32(Console.ReadLine());

Qub(num);

Console.Write($"все числа в кубе от 1 до {num}");
*/