using System;

namespace Tubes_1
{
    public abstract class Error : Exception
    {
        public abstract string printMessage();
    }
}