using System;
using System.Collections.Generic;
using Lab8_Interpreter.Expressions;

namespace Lab8_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            int a = 15;
            int b = 7;
            int c = 2;

            context.SetVariable("a", a);
            context.SetVariable("b", b);
            context.SetVariable("c", c);

            IExpression expression = new SubtractExpression(
                new AddExpression(
                    new NumberExpression("a"), new NumberExpression("b")
                ),
                new NumberExpression("c")
            );

            int result = expression.Interpret(context);
            Console.WriteLine("Результат: " + result);

            Console.ReadKey();

        }
    }
}
