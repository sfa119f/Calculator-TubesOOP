using System;

namespace Tubes_1
{
    public abstract class BinaryExpression : Expression<double>
    {
        public Expression<double> x;
        public Expression<double> y;

        public BinaryExpression(Expression<double> x, Expression<double> y)
        {
            this.x = x;
            this.y = y;
        }
    }
}