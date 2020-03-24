using System;

namespace Tubes_1
{
    class driver_rootExpression
    {
        static void Main(string[] args)
        {
            TerminalExpression a = new TerminalExpression(4);
            RootExpression b = new RootExpression(a);
            Console.WriteLine(b.solve());
        }
    }
}