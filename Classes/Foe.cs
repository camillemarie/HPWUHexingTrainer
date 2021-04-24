using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPWUHexingTrainer
{
    public class Foe
    {
        public int Stars { get; set; }
        public FoeType Type { get; set; }
        public bool Elite { get; set; }
        public string StarName()
        {
            StarName s = (StarName)Stars;
            return s.ToString();
        }

        public override string ToString()
          => $"{ (Elite ? "Elite " : "")} {((StarName)Stars).ToString()}  { Type.ToString().Humanize(LetterCasing.Title) }";
        //=> $"{ (Elite ? "Elite " : "")}{ Stars} star {((StarName)Stars).ToString()}  { Type.ToString().Humanize(LetterCasing.Title) }";

        public Foe()
        {
        }

        public Foe(int stars, FoeType type, bool elite = false)
        {
            Stars = stars;
            Type = type;
            Elite = elite;
        }
    }

    public enum FoeType
    {
        Erkling,
        Acromantula,
        Werewolf,
        Pixie,
        DarkWizard,
        DeathEater
    }

    public enum StarName
    {
        Imposing = 3,
        Dangerous = 4,
        Fierce = 5
    }
}
