using System;

namespace GefangenenDilemma
{
    class PrisonerTacticOnlyConfess : IPrisonersDilemma, IPrisonorsProperties
    {
        public Crime crimetype { get; set; }
        public int rounds { get; set; }
        public Reaction myPreviousReaction { get; set; }

        public void End()
        {
            Console.WriteLine($"Ich mache immer Confess, Runde Vorbei ich habe {myPreviousReaction}");
        }

        public string Name()
        {
            return "Bernhard";
        }

        public Reaction NextRound(Reaction opponentLastRound)
        {
            var myReaction = Reaction.Confess;
            this.myPreviousReaction = myReaction;
            return myReaction;
        }

        public void Start(Crime type, int rounds)
        {
            this.crimetype = type;
            this.rounds = rounds;
        }
    }
}
