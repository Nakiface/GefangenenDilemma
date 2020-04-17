namespace GefangenenDilemma
{
    interface IPrisonorsProperties
    {
        Crime crimetype { get; set; }
        int rounds { get; set; }
        Reaction myPreviousReaction { get; set; }
    }
}
