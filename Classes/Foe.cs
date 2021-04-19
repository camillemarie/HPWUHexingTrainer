using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPWUHexingInitialBoard
{
    public class Foe
    {
        public int Stars { get; set; }
        public FoeType Type { get; set; }
        public bool Elite { get; set; }

        public override string ToString() 
            => $"{ (Elite ? "Elite " : "")}{ Stars} star { Type.ToString().Humanize(LetterCasing.Title) }";

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
}
