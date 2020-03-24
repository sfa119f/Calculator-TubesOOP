using System;

namespace Tubes_1
{
  public class NegativeRoot : Error
  {
    public NegativeRoot(){}

    public override string printMessage()
    {
        return "Akar tidak bisa negatif!";
    }
  }
}