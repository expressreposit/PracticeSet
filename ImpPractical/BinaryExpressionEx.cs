using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace ImpPractical
{
    class BinaryExpressionEx
    {
        static void Main1(string[] args)
        {
            //  Expression trees    (10+20)-(50+20)
            
            //  10+20
            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Add,Expression.Constant(10),Expression.Constant(20));

            //  5+3
            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(5), Expression.Constant(3));

            // (10+20)-(5+3)
            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract, b1,b2);

            //  Invoke the Expression and save result into variable
            //  this statement will create a delegate by parsing the expression tree
            int result = Expression.Lambda<Func<int>>(b3).Compile()();
            Console.WriteLine("Expression Result: "+result.ToString());
            Console.ReadLine();
        }
    }
}
