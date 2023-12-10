using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Interpreter
{
    public class NumberExpression : IExpression
    {
        private int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public int Interpret()
        {
            return number;
        }
    }

    public class AddExpression : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret()
        {
            return leftExpression.Interpret() + rightExpression.Interpret();
        }
    }

    public class SubtractExpression : IExpression
    {
        private IExpression leftExpression;
        private IExpression rightExpression;

        public SubtractExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret()
        {
            return leftExpression.Interpret() - rightExpression.Interpret();
        }
    }

}
