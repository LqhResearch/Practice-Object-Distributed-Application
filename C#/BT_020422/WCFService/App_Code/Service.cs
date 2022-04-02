public class Service : IService
{
    public double Calculate(int n1, char op, int n2)
    {
        switch (op)
        {
            case '+':
                return n1 + n2;
            case '-':
                return n1 - n2;
            case '*':
                return n1 * n2;
            case '/':
                return 1.0 * n1 / n2;
            case '%':
                return n1 % n2;
            default:
                return 0;
        }
    }
}
