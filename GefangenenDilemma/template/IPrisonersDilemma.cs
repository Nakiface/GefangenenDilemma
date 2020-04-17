
public interface IPrisonersDilemma
    {
        /// <summary>
        /// Start a new round. You will get the information about the next game.
        /// </summary>
        /// <param name="type">What kind of crime will be played</param>
        /// <param name="rounds">How many rounds will be played</param>
        void Start(Crime type, int rounds);

        /// <summary>
        /// End the actual round
        /// </summary>
        void End();

        /// <summary>
        /// After victory and for results will the name used.
        /// </summary>
        /// <returns></returns>
        string Name();
        
        /// <summary>
        /// What will be your reaction for the next round?
        /// </summary>
        /// <param name="opponentLastRound">The reaction from your opponent from the last round.</param>
        /// <returns></returns>
        Reaction NextRound(Reaction opponentLastRound);
    }
