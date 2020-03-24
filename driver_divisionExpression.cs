using System;

namespace Tubes_1
{
    class driver_divisionExpression
    {
        static void Main(string[] args)
        {
            TerminalExpression a = new TerminalExpression(4);
            NegativeExpression b = new NegativeExpression(a);
            TerminalExpression c = new TerminalExpression(5);
            TerminalExpression nol = new TerminalExpression(0);
            DivisionExpression d = new DivisionExpression(a,b);
            DivisionExpression e = new DivisionExpression(a,c);
            DivisionExpression f = new DivisionExpression(c,nol);
            String text;
            try{
                Console.WriteLine(f.solve());
            } catch(Error err){
                text = err.printMessage();
                Console.WriteLine(text);
            }
            Console.WriteLine(d.solve());
            Console.WriteLine(e.solve());
        }
    }
}