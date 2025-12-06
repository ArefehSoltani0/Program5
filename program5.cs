using System;

class Program
{
    // متد بازگشتی برای محاسبه عدد فیبوناچی در جایگاه n (با شروع از 1: F(1)=1, F(2)=1)
    static int Fibonacci(int n)
    {
        if (n <= 0)
            return 0;
        if (n == 1 || n == 2)
            return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("تعداد اعداد فیبوناچی را وارد کنید (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("لطفاً یک عدد صحیح مثبت وارد کنید.");
            return;
        }

        Console.Write("دنباله فیبوناچی تا عدد " + n + "ام: ");

        // چاپ از nامین عدد به اولین عدد (معکوس)
        for (int i = n; i >= 1; i--)
        {
            Console.Write(Fibonacci(i));
            if (i > 1) Console.Write(" ");
        }
        Console.WriteLine();
    }
}