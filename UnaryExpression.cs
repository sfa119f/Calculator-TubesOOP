using System;

namespace Tubes_1
{
    public abstract class UnaryExpression<T> : Expression<double>
    {
        public Expression<double> x;

        public UnaryExpression(Expression<double> x)
        {
            this.x = x;
        }
    }
}