namespace GefangenenDilemma
{
    class MediumCrime : ICrimeMode
    {
        public int Temptation { get; } = 0;
        public int reward { get; } = 3;
        public int punishment { get; } = 6;
        public int suckersPayoff { get; } = 4;
    }
}
