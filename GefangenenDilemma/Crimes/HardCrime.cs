namespace GefangenenDilemma
{
    class HardCrime : ICrimeMode
    {
        public int Temptation { get; } = 0;
        public int reward { get; } = 4;
        public int punishment { get; } = 8;
        public int suckersPayoff { get; } = 10;
    }
}
