using System;

public class Service : IService
{
    /// <summary>
    /// Đề số 1
    /// </summary>
    public string Count_Div2_NotDiv4(int[] arr)
    {
        int count = 0;
        string str = "";
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 0 && arr[i] % 4 != 0)
            {
                str += arr[i] + "   ";
                count++;
            }
        return "Có " + count + " kết quả là " + str;
    }

    public int[] SortOddNumberDescending(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] % 2 == 1)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] % 2 == 1 && arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        return arr;
    }

    public string PrintArray(int[] arr)
    {
        string str = "";
        for (int i = 0; i < arr.Length; i++)
            str += arr[i] + "  ";
        return str;
    }

    public int SumOddNumber(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 1)
                sum += arr[i];
        return sum;
    }

    /// <summary>
    /// Đề số 2
    /// </summary>
    public string Count_Div4_Div5(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 4 == 0 && arr[i] % 5 == 0)
                count++;
        string str = "Có " + count + " số chia hết cho 4 và 5. ";
        str += (count % 2 == 0) ? count + " là số chẫn." : count + " là số lẻ.";
        return str;
    }

    public int[] SortEvenNumberAscending(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] % 2 == 0 && arr[j] % 2 == 0 && arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return arr;
    }

    public double Average(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];
        return sum / arr.Length;
    }

    /// <summary>
    /// Đề số 3
    /// </summary>
    public string Count_PrintOddNumber(int[] arr)
    {
        int count = 0;
        string str = "";
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 1)
            {
                str += arr[i] + "  ";
                count++;
            }
        return "Có " + count + " số lẻ là " + str;
    }

    public string Count_PrintEvenNumber(int[] arr)
    {
        int count = 0;
        string str = "";
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 0)
            {
                str += arr[i] + "  ";
                count++;
            }
        return "Có " + count + " số chẫn là " + str;
    }

    public int[] Sort_OddNumberDescending_EvenNumberAscending(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] % 2 == 1)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] % 2 == 1 && arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            else
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] % 2 == 0 && arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        int[] ans = new int[7];
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 1)
                ans[count++] = arr[i];

        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 0)
                ans[count++] = arr[i];

        return ans;
    }

    public int SumArray(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];
        return sum;
    }

    /// <summary>
    /// Đề số 4
    /// </summary>
    public bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }

    public string Count_Sum_Prime(int[] arr)
    {
        int count = 0, sum = 0;
        for (int i = 0; i < arr.Length; i++)
            if (IsPrime(arr[i]))
            {
                count++;
                sum += arr[i];
            }
        string str = "Có " + count + " số nguyên tố. Tổng các số nguyên tố là " + sum + ". ";
        str += (sum % 2 == 0) ? sum + " là số chẫn." : sum + " là số lẻ.";
        return str;
    }

    public int[] Sort_EvenNumberAscending_OddNumberDescending(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] % 2 == 1)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] % 2 == 1 && arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            else
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] % 2 == 0 && arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        int[] ans = new int[7];
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 0)
                ans[count++] = arr[i];

        for (int i = 0; i < arr.Length; i++)
            if (arr[i] % 2 == 1)
                ans[count++] = arr[i];
        return ans;
    }
}
