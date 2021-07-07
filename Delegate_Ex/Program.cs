using System;

namespace Delegate_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().TestCode();
        }
        void TestCode()
        {
            var addOp = new CalcDelegate(Add);

            Calc(6, 3, addOp);

            // 간소화
            Calc(6, 3, Substract);
            Calc(6, 3, Power);
        }
        // 델리게이트 정의
        delegate int CalcDelegate(int a, int b);
        void Calc(int a, int b, CalcDelegate calc)
        {
            // 두 개의 방식으로 선언 가능
            //int res = calc.Invoke(a, b);
            int res = calc(a, b);

            // 출력
            Console.WriteLine("사용함수 : {0}", calc.Method);
            Console.WriteLine($"f({a}, {b}) = {res}");

        }
        int Add(int a, int b)
        {
            return a + b;
        }

        int Substract(int a, int b)
        {
            return a - b;
        }
        int Multiply(int a, int b)
        {
            return a * b;
        }

        int Divide(int a, int b)
        {
            return a / b;
        }

        int Mod(int a, int b)
        {
            return a % b;
        }
        int Power(int a, int b)
        {
            int r = 1;
            for (int i = 0; i < b; i++)
            {
                r *= a;
            }
            return r;
        }
    }
}
