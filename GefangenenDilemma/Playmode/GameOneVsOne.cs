using System;

namespace GefangenenDilemma
{
    class GameOneVsOne
    {
        public int rounds { get; set; }
        public Crime crime { get; set; }
        public int punishmentP1 { get; set; }
        public int punishmentP2 { get; set; }
        public ICrimeMode punsiment { get; set; }

        public GameOneVsOne(int rounds, Crime crime)
        {
            this.rounds = rounds;
            this.crime = crime;
            punsiment = CrimeMode.Set(crime);
        }

        public void Play()
        {
            IPrisonersDilemma player1 = new PrisonerTacticOnlyConfess();
            IPrisonersDilemma player2 = new PrisonerTacticOnlyDeny();

            var ReactionPlayer1 = Reaction.FirstRound;
            var ReactionPlayer2 = Reaction.FirstRound;
            Reaction temp;

            for (int i = 0; i < rounds; i++)
            {
                player1.Start(crime, rounds);
                temp = ReactionPlayer1;
                ReactionPlayer1 = player1.NextRound(ReactionPlayer2);
                player1.End();

                player2.Start(crime, rounds);
                ReactionPlayer2 = player2.NextRound(temp);
                player2.End();

                DoPunishment(ReactionPlayer1, ReactionPlayer2);
            }
            Console.WriteLine($"Spieler 1 hat {punishmentP1} Jahre Haft");
            Console.WriteLine($"Spieler 2 hat {punishmentP2} Jahre Haft");
            Console.ReadLine();
            
        }

        public void DoPunishment(Reaction reactionP1, Reaction reactionP2)
        {
            if (reactionP1 == Reaction.Confess && reactionP2 == Reaction.Confess)
            {
                punishmentP1 += punsiment.punishment;
                punishmentP2 += punsiment.punishment;
            }
            if (reactionP1 == Reaction.Deny && reactionP2 == Reaction.Deny)
            {
                punishmentP1 += punsiment.reward;
                punishmentP2 += punsiment.reward;
            }
            if (reactionP1 == Reaction.Deny && reactionP2 == Reaction.Confess)
            {
                punishmentP1 += punsiment.suckersPayoff;
                punishmentP2 += punsiment.Temptation;
            }
            if (reactionP1 == Reaction.Confess && reactionP2 == Reaction.Deny)
            {
                punishmentP1 += punsiment.Temptation;
                punishmentP2 += punsiment.suckersPayoff;
            }
        }
    }
}
