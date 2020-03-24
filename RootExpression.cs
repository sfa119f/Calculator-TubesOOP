using System;

namespace Tubes_1
{
    public class RootExpression<T> : UnaryExpression<T>
    {
        public RootExpression(Expression<double> E) : base(E){}

        public override double solve()
        {
            return Math.Sqrt(this.x.solve());
        }
    }
}