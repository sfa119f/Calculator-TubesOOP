using System;

namespace Tubes_1
{
    class driver_addExpression
    {
        static void Main(string[] args)
        {
            TerminalExpression a = new TerminalExpression(4);
            TerminalExpression b = new TerminalExpression(5);
            AddExpression c = new AddExpression(a,b);
            Console.WriteLine(c.solve());
        }
    }
}