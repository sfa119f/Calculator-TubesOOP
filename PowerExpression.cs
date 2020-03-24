using System;

namespace Tubes_1
{
    class PowerExpression : BinaryExpression
    {
        public PowerExpression (Expression<double> E1, Expression<double> E2) : base(E1, E2){}

        public override double solve()
        {
            double i;
            double num = this.x.solve();
            double hsl = this.x.solve();
            for(i=this.y.solve();i>1;i--)
            {
                hsl *= num;
            }
            return hsl;
        }
    }
}