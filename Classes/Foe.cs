using Humanizer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPWUHexingTrainer
{
    public class Foe
    {
        //public int Stars { get; set; }
        public StarName Stars { get; set; }

        public FoeType Type { get; set; }
        public bool Elite { get; set; }




        public string ImagePath => $"images/foes/{ToString()}.png";
        public string Top { get; set; }
        public string Left { get; set; }

        public override string ToString()
        {
            return $"{(Elite ? "Elite " : "")}{ Stars.ToString() } { FoeTypePretty(Type) }";
        }

        public static string FoeTypePretty(FoeType type)
        {
            return type.ToString().Humanize(LetterCasing.Title);
        }

        public Foe()
        {
        }

        public Foe(StarName stars, FoeType type, bool elite = false)
        {
            Stars = stars;
            Type = type;
            Elite = elite;
        }
    }

    public enum FoeType
    {
        Erkling = 1,
        Acromantula = 2,
        Werewolf = 3,
        Pixie = 4,
        DarkWizard = 5,
        DeathEater = 6
    }

    public enum StarName
    {
        Imposing = 3,
        Dangerous = 4,
        Fierce = 5
    }
}
