using System;

namespace Tubes_1
{
    class driver_multiplyExpression
    {
        static void Main(string[] args)
        {
            TerminalExpression a = new TerminalExpression(4);
            NegativeExpression b = new NegativeExpression(a);
            TerminalExpression c = new TerminalExpression(5);
            MultiplyExpression d = new MultiplyExpression(a,b);
            MultiplyExpression e = new MultiplyExpression(a,c);
            Console.WriteLine(d.solve());
            Console.WriteLine(e.solve());
        }
    }
}