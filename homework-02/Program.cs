using System;

namespace homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Please input first number==========");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==========Please input second number=========");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==============Input operation================");
            string operation = Console.ReadLine();
            if (operation == "add")
            {
                Calc(a, b, Operation.Add);
            } else if (operation == "sub")
            {
                Calc(a, b, Operation.Sub);
             } else if (operation == "mul") {
                Calc(a, b, Operation.Mul);
            }else if(operation == "div")
            {
                Calc(a, b, Operation.Div);
            }else
            {
                Console.WriteLine("=========The program performs four simple activities=========");
            }
        }
        static void Calc(double a, double b, Operation op)
        {
            double result = 0;

            switch (op)
            {
                case Operation.Add:
                    result = a + b;
                    break;
                case Operation.Sub:
                    result = a - b;
                    break;
                case Operation.Mul:
                    result = a * b;
                    break;
                case Operation.Div:
                    result = a / b;
                    break;

            }

            Console.WriteLine(result);
        }
    }
}
