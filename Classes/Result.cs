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

        public int OtherAnswer { get; set; }
        public bool ProficiencyAnswer { get; set; }



        public Result()
        {
        }

        public Result(int lobbyNumber, List<Foe> foesList, LobbyResult lobbyResult, bool proficiencyAnswer, int otherAnswer, bool correctAnswer)
        {
            LobbyNumber = lobbyNumber;
            FoesList = foesList;
            LobbyResult = lobbyResult;
            ProficiencyAnswer = proficiencyAnswer;
            OtherAnswer = otherAnswer;
            CorrectAnswer = correctAnswer;
        }
    }


}
