using System;

namespace BelieveOrNotBelieve
{
    public class GameResultEventArgs : EventArgs
    {
        public int QuestionTotal { get; }
        public int QuestionsPassed { get; }
        public int MistakesMade { get; }
        public bool IsWin { get; }

        public GameResultEventArgs(int questionsPassed, int mistakesMade, bool isWin)
        {
            QuestionTotal = questionsPassed + mistakesMade;
            QuestionsPassed = questionsPassed;
            MistakesMade = mistakesMade;
            IsWin = isWin;
        }
    }
}
