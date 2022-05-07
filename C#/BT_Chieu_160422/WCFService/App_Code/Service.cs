using System;

public class Service : IService
{
    string ConvertString(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public string DecToBin(int n)
    {
        string str = "";
        while (n != 0)
        {
            str += (n % 2);
            n /= 2;
        }
        return ConvertString(str);
    }

    public double Sum1ToN(int n)
    {
        double sum = 1.0;
        int init = (n % 2 == 0) ? 2 : 3;
        for (int i = init; i <= n; i+=2)
            sum += 1.0 / i;
        return sum;
    }

    public int Factorial(int n)
    {
        int sum = 1;
        for (int i = 2; i <= n; i++)
            sum *= i;
        return sum;
    }

    bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }

    public string PrintPrimeAToB(int a, int b)
    {
        string str = "";
        for (int i = a; i <= b; i++)
            if (IsPrime(i))
                str += i + "   ";
        return str;
    }
}
