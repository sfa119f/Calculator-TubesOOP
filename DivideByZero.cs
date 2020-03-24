using System;

namespace Tubes_1
{
    public class DivideByZero : Error
    {
        public DivideByZero(){}

        public override string printMessage(){
          return "Can't divide by 0!";
        }
    }
}