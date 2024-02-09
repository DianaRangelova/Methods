int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

Console.WriteLine(MathPow(number, power));

static int MathPow(int baseNumber, int powerNumber)
{
    int output = baseNumber;
    for (int i = 2; i <= powerNumber; i++)
    {
        output *= baseNumber;
    }
    return output;
}
