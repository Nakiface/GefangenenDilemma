using System;
using System.Collections.Generic;

namespace GefangenenDilemma
{
    class EasyCrime : ICrimeMode
    {
        public int Temptation { get; } = 0;
        public int reward { get; } = 2;
        public int punishment { get; } = 1;
        public int suckersPayoff { get; } = 3;
    }
}
