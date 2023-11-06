using LiskovSubstitutionPrinciple.Infrastructure;
using LiskovSubstitutionPrinciple.Core;

internal class Program
{
    private static void Main(string[] args)
    {
        LiskovSubstitutionPrinciple.Core.Rectangle rect = new Square();
        TestRectangleArea(rect);

        Console.Read();
    }

    //public static void TestRectangleArea(LiskovSubstitutionPrinciple.Core.Rectangle rect)
    //{
    //    rect.Height = 5;
    //    rect.Width = 10;
    //    if (rect.GetArea() != 50)
    //        throw new Exception("Некорректная площадь!");
    //}

    public static void TestRectangleArea(Rectangle rect)
    {
        if (rect is Square)
        {
            rect.Height = 5;
            if (rect.GetArea() != 25)
                throw new Exception("Неправильная площадь!");
        }
        else if (rect is Rectangle)
        {
            rect.Height = 5;
            rect.Width = 10;
            if (rect.GetArea() != 50)
                throw new Exception("Неправильная площадь!");
        }
    }
}