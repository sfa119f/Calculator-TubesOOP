using System;

namespace Tubes_1
{
    class driver_addExpression
    {
        static void Main(string[] args)
        {
            TerminalExpression a = new TerminalExpression(4);
            TerminalExpression b = new TerminalExpression(5);
            TerminalExpression c = new TerminalExpression(-2);
            TerminalExpression d = new TerminalExpression(-1);
            SubstractExpression e = new SubstractExpression(a,b);
            SubstractExpression f = new SubstractExpression(a,c);
            SubstractExpression g = new SubstractExpression(c,d);
            SubstractExpression h = new SubstractExpression(c,b);
            Console.WriteLine(e.solve());
            Console.WriteLine(f.solve());
            Console.WriteLine(g.solve());
            Console.WriteLine(h.solve());
        }
    }
}