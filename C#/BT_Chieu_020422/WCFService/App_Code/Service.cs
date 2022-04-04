using System;

public class Service : IService
{
    /// <summary>
    /// Đề 1
    /// </summary>
    public string SingleEquation(int a, int b)
    {
        if (a == 0)
            return (b == 0) ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
        else
            return "Nghiệm x = " + (-1.0 * b / a);
    }

    public bool IsPrime(int n)
    {
        if (n < 2)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }

    /// <summary>
    /// Đề 2
    /// </summary>

    public string QuadraticEquation(int a, int b, int c)
    {
        if (a == 0)
        {
            if (b == 0)
                return (c == 0) ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
            else
                return "Nghiệm x = " + (-1.0 * c / b);
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta > 0)
                return "Nghiệm x1 = " + (-b + Math.Sqrt(delta)) / (2 * a) + "; x2 = " + (-b - Math.Sqrt(delta)) / (2 * a);
            else if (delta == 0)
                return "Nghiệm kép x1 = x2 = " + (-1.0 * b) / (2 * a);
            else
                return "Phương trình vô nghiệm";
        }
    }

    public int Factorial(int n)
    {
        int f = 1;
        for (int i = 2; i <= n; i++)
            f *= i;
        return f;
    }

    public string CheckOddEvenNumber(int n)
    {
        return (n % 2 == 0) ? n + " là số chẫn" : n + " là số lẻ";
    }

    /// <summary>
    /// Đề 3
    /// </summary>
    public bool IsTriangle(double a, double b, double c)
    {
        return a < b + c && b < a + c && c < a + b;
    }

    public string TriangleName(double a, double b, double c)
    {
        if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
            return "tam giác vuông";
        else if (a == b && b == c)
            return "tam giác đều";
        else if (a == b || a == c || b == c)
            return "tam giác cân";
        else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
            return "tam giác tù";
        else
            return "tam giác nhọn";
    }

    public double AverageTriangle(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }
}
