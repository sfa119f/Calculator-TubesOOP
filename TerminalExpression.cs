using System;

namespace Tubes_1
{
    public class TerminalExpression : Expression<double>
    {
        public double x;

        public TerminalExpression(double x)
        {
            this.x = x;
        }

        public TerminalExpression()
        {
            this.x = 0;
        }

        public void setX(double x)
        {
            this.x = x;
        }
        public override double solve()
        {
            return this.x;
        }
    }
}