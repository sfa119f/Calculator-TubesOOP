using System;

namespace Tubes_1
{
    public class MultiplyExpression : BinaryExpression
    {
        public MultiplyExpression(Expression<double> E1, Expression<double> E2) : base(E1, E2){}

        public override double solve()
        {
            return this.x.solve() * this.y.solve();
        }
    }
}