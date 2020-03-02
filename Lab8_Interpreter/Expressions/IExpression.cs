using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_Interpreter.Expressions
{
    interface IExpression
    {
        int Interpret(Context context);
    }
}
