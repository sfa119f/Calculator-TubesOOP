using System;

namespace Tubes_1
{
    public class NegativeExpression<T> : UnaryExpression<T>
    {
        public NegativeExpression(Expression<double> E) : base(E){}

        public override double solve()
        {
            return this.x.solve()*(-1);
        }
    }
}