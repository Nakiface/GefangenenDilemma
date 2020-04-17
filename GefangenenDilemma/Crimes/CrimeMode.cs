namespace GefangenenDilemma
{
    static class CrimeMode
    {
        public static ICrimeMode Set(Crime crime)
        {
            switch (crime)
            {
                case Crime.Easy:
                    return new EasyCrime();
                case Crime.Medium:
                    return new MediumCrime();
                case Crime.Hard:
                    return new HardCrime();
                default:
                    return null;
            }
        }
    }
}
