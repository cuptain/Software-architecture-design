using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_Interpreter.Expressions
{
    class NumberExpression : IExpression
    {
        string name; 
        public NumberExpression(string variableName)
        {
            name = variableName;
        }
        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}
