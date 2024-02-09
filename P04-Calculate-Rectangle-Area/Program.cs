int lenght = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateRectangleArea(lenght, width));

static int CalculateRectangleArea(int l, int w)
{
    int area = l * w;
    return area;
}