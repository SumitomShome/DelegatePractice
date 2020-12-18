using System;
delegate int ChangingNumber(int n);
namespace DelegatePracticeProgram
{
        class TestDelegate
        {
            static int num = 10;
            public static int AddNumber(int p)
            {
                num += p;
                return num;
            }
            public static int MultiplyNumber(int q)
            {
                num *= q;
                return num;
            }
            public static int getNum()
            {
                return num;
            }
        static void Main(string[] args)
        {
            ChangingNumber nc1 = new ChangingNumber(AddNumber);
            ChangingNumber nc2 = new ChangingNumber(MultiplyNumber);
            Console.WriteLine("Hello World!");
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
