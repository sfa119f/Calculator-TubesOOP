using System;

namespace Tubes_1
{
    public class DivisionExpression : BinaryExpression
    {
        public DivisionExpression(Expression<double> E1, Expression<double> E2) : base(E1, E2){}

        public override double solve()
        {
            if(this.y.solve()==0){
                DivideByZero divideByZero = new DivideByZero();
                throw divideByZero;
            }
            else{
              return this.x.solve() / this.y.solve();
            }
        }
    }
}