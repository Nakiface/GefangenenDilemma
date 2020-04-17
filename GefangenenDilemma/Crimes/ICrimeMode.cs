namespace GefangenenDilemma
{
    interface ICrimeMode
    {
        int Temptation { get; }
        int reward { get; } 
        int punishment { get; } 
        int suckersPayoff { get; } 
    }
}
