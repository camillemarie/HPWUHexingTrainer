using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPWUHexingTrainer.Classes
{
    public class Result
    {
        public int LobbyNumber { get; set; }
        public List<Foe> FoesList { get; set; }
        public LobbyResult LobbyResult { get; set; }
        public bool CorrectAnswer { get; set; }

        public int FocusAnswer { get; set; }
        public bool ProficiencyAnswer { get; set; }


        public Result()
        {
        }

        public Result(int lobbyNumber, List<Foe> foesList, LobbyResult lobbyResult, bool proficiencyAnswer, int focusAnswer, bool correctAnswer)
        {
            LobbyNumber = lobbyNumber;
            FoesList = foesList;
            LobbyResult = lobbyResult;
            ProficiencyAnswer = proficiencyAnswer;
            FocusAnswer = focusAnswer;
            CorrectAnswer = correctAnswer;
        }
    }


}
