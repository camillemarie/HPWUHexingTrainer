using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPWUHexingInitialBoard
{
    public class BoardReader
    {
        public static string Read(List<Foe> foes)
        {
            BoardResult br = new BoardResult();

            br.A2Hexes = new List<Hex>();
            br.A1Hexes = new List<Hex>();

            List<Foe> orderedAurorFoes = SetA2Details(foes, br);
            SetA1Details(foes, br);
            AssessProficiencyAndShieldForA2(br, orderedAurorFoes);

            //return br;
            return PrepareReturnString(br);
        }


        #region A1
        private static void SetA1Details(List<Foe> foes, BoardResult br)
        {
            List<Foe> orderedProfFoes = foes
                .Where(p => p.Elite == false && (p.Type == FoeType.Pixie || p.Type == FoeType.Werewolf))
                .OrderBy(p => p.Type.ToString())
                .ThenBy(p => p.Stars)
                .Take(2)
                .ToList();

            if (orderedProfFoes.Count == 0)
            {
                br.A1FocusPassed = 1;
                br.A1FocusKept = 3;

            }
            else if (orderedProfFoes.Count == 1)
                br.A1FocusKept = 2; // keep 2 for the 2nd prof that has nothing to fight straight away


            for (int cnt = 0; cnt < orderedProfFoes.Count(); cnt++)
            //foreach (Foe f in orderedProfFoes)
            {
                Foe f = orderedProfFoes[cnt];

                if (cnt == 0)
                {
                    br.P1Fights = true;
                    br.P1Foe = f.ToString();
                }
                else
                {
                    br.P2Fights = true;
                    br.P2Foe = f.ToString();
                }

                if (f.Type == FoeType.Pixie)
                {
                    if (f.Stars > 3)
                        AddHex(br, HexType.Weakening, f.ToString(), true);
                }
                // it is a wolf
                else
                {
                    AddHex(br, HexType.Weakening, f.ToString(), true);

                    if (f.Stars == 5)
                        AddHex(br, HexType.Confusion, f.ToString(), true);



                    // if it is a 4 star wolf AND there will be no proficiency, also add a confusion
                    else if (f.Stars == 4)
                    {
                        // if A2 passed 3 -> Automatic proficiency - no confusion 

                        /* 
                         * 3 star pixie (0 hexes, pass 2) + 1 x 4 star wolf => 3 star Pixie == automatic proficiency unless hard auror foes - no confusion on wolf
                         * 4,5 star pixie (1 hex, pass 1) + 1 x 4 star wolf => if A2 passed 1 & we pass 1 for pixie, we can pass 1 and get prof -> no confusion on wolf 
                         * 1 x 5 star wolf(2 hexes) + 1 x 4 star wolf => we need 2 for wolf. If A2 passed 2 we could pass 1 & get prof -> no confusion. If A2 passed 1, we need to double hex
                         * 2 x 4 star wolves - can single hex both, pass 2 -> proficiency - no confusion on wolf
                         */

                        // we need to double hex the 4 star wolf if P2 has shielded A2 or we need lots of hexes and A2 only passed 1
                        if (br.A2FocusPassed == 1 && br.A1Hexes.Count == 3 || br.P2ShieldsA2)
                            
                            AddHex(br, HexType.Confusion, f.ToString(), true);
                    } 
                }
            }
            br.A1FocusPassed = 4 - br.A1Hexes.Count() - br.A1FocusKept;
        }
        #endregion

        #region A2
        private static List<Foe> SetA2Details(List<Foe> foes, BoardResult br)
        {
            br.A2FocusPassed = 1; // A2 ALWAYS passes a focus regardless of the board

            AssessMagiFoes(foes, br);
            List<Foe> orderedAurorFoes = AssessAurorFoes(foes, br);

            br.A2FocusPassed = 4 - br.A2Hexes.Count - br.A2FocusKept;
            return orderedAurorFoes;
        }

        private static void AssessMagiFoes(List<Foe> foes, BoardResult br)
        {
            //Imposing Erkling -> 
            //Imposing Acromantula -> 
            //Dangerous Acromantula -> 
            //Fierce Acromantula->
            //Dangerous Erkling->
            //Fierce Erkling

            // we just take the top 1 magi foe as we only have 1 magi
            List<Foe> orderedMagiFoes = foes
                .Where(m => m.Elite == false && (m.Type == FoeType.Acromantula || m.Type == FoeType.Erkling))
                .OrderBy(m => m.Type == FoeType.Erkling && m.Stars == 3)
                .OrderBy(m => m.Type == FoeType.Acromantula && m.Stars == 3)
                .OrderBy(m => m.Type == FoeType.Acromantula && m.Stars == 4)
                .OrderBy(m => m.Type == FoeType.Acromantula && m.Stars == 5)
                .OrderBy(m => m.Type == FoeType.Erkling && m.Stars == 4)
                .OrderBy(m => m.Type == FoeType.Erkling && m.Stars == 5)
                .Take(1)
                .ToList();

            // if no magi mon, keep a focus for when one shows up
            if (orderedMagiFoes.Count() == 0)
                br.A2FocusKept += 1;
            else
            {
                if (orderedMagiFoes[0].Type == FoeType.Erkling && orderedMagiFoes[0].Stars > 3)
                    AddHex(br, HexType.Confusion, orderedMagiFoes[0].ToString(), false);

                br.MagiFights = true;
                br.MagiFoe = orderedMagiFoes[0].ToString();
            }
        }

        private static List<Foe> AssessAurorFoes(List<Foe> foes, BoardResult br)
        {
            //    Imposing Dark Wizard->
            //    Imposing Death Eater -> 
            //    Dangerous Dark Wizard->
            //    Dangerous Death Eater -> 
            //    Fierce Dark Wizard->
            //    Fierce Death Eater

            List<Foe> orderedAurorFoes = foes
                .Where(a => a.Elite == false && (a.Type == FoeType.DeathEater || a.Type == FoeType.DarkWizard))
                .OrderBy(a => a.Stars)
                .ThenBy(a => a.Type.ToString())
                .Take(2)
                .ToList();

            // if no auror mons, keep 2 focus for when they show up
            if (orderedAurorFoes.Count == 0)
                br.A2FocusKept += 2;

            else if (orderedAurorFoes.Count == 1)
                br.A2FocusKept = 1; // keep 2 for the 2nd auror that has nothing to fight straight away

            // we have 2 auror foes, reverse the order as A1 has a shield so gets the harder foe
            else
                orderedAurorFoes.Reverse();

            for (int cnt = 0; cnt < orderedAurorFoes.Count(); cnt++)
            {
                Foe f = orderedAurorFoes[cnt];

                if (cnt == 0)
                {
                    br.A1Fights = true;
                    br.A1Foe = f.ToString();

                    // This is the foe that Auror 1 will take, this Auror will always have a shield so don't hex 3 star
                    if (f.Stars == 3)
                        continue;
                }
                else
                {
                    br.A2Fights = true;
                    br.A2Foe = f.ToString();
                }


                if (f.Stars == 5 && f.Type == FoeType.DarkWizard)
                {
                    AddHex(br, HexType.Confusion, orderedAurorFoes[cnt].ToString(), false);

                    // Double hex the 5 star dark wizard for A1 as it always has a shield 
                    // & A2 as it will also need a shield due to 2 x 5 star Auror foes

                    // Don't double weaken in the initial lobby to get proficiency up quicker.
                    //if (br.A2Hexes.Count <= 3) // if we've hexed the magi + double hexed A1, we can only add 1 hex for A2
                    //    AddHex(br, HexType.Weakening, orderedAurorFoes[cnt].ToString(), false);
                }
                else
                    AddHex(br, HexType.Weakening, orderedAurorFoes[cnt].ToString(), false);
            }

            // we need to shield A2 due to hard Auror foes
            var num5StarAurorFoes = orderedAurorFoes.Where(a => a.Stars == 5).Count();
            br.P2ShieldsA2 = num5StarAurorFoes == 2 ? true : false;

            return orderedAurorFoes;
        }

        #endregion


        private static void AssessProficiencyAndShieldForA2(BoardResult br, List<Foe> orderedAurorFoes)
        {
            /* determine if we need 2 shields 
             *  - P2 has 7 focus but both Aurors will fight 5 stars
             *  - P2 doesn't have 7 focus and lobby has 5 star mon or 4 star DE
             */
            var focusPassedToP2 = br.A1FocusPassed + br.A2FocusPassed;

            if (focusPassedToP2 >= 3)
            {
                // we got enough focus but the mons are too hard
                var num5StarAurorFoes = orderedAurorFoes.Where(a => a.Stars == 5).Count();
                br.P2ShieldsA2 = num5StarAurorFoes == 2 ? true : false;
                br.Proficiency = !br.P2ShieldsA2;
            }
            else
            {
                // we didn't get proficiency and have hard auror foes
                br.Proficiency = false; // we didn't get passed enough focus

                // if we have 2 auror foes and not enough focus, see if A2 needs a shield
                if (orderedAurorFoes.Count == 2)
                {
                    var a2Shield = orderedAurorFoes[1].Stars == 5 || (orderedAurorFoes[1].Stars == 4 && orderedAurorFoes[1].Type == FoeType.DeathEater);
                    br.P2ShieldsA2 = a2Shield;
                }
            }
        }

        private static void AddHex(BoardResult br, HexType type, string foeName, bool isAuror1)
        {
            Hex h = new Hex();
            h.HexType = type;
            h.FoeName = foeName;

            if (isAuror1)
                br.A1Hexes.Add(h);
            else
                br.A2Hexes.Add(h);
        }




        private static string PrepareReturnString(BoardResult br)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Magi");
            sb.AppendLine($"{ (br.MagiFights ? "Fights" : "Waits") } { (br.MagiFights ? br.MagiFoe : "") }");

            //////////////////////////
            sb.AppendLine();
            sb.AppendLine("A1");

            // if A1 has 4 focus to be passed, we can shield both Aurors AND get proficiency
            if (br.A1FocusPassed == 4)
                sb.AppendLine($"Passes 2 to P1 and 2 to P2 - Keeps: { br.A1FocusKept }");
            else
                sb.AppendLine($"Passes: { br.A1FocusPassed } to P2 - Keeps: { br.A1FocusKept }");

            foreach (Hex h in br.A1Hexes)
                sb.AppendLine($"Hexes: { h.FoeName } with { h.HexType.ToString() }");

            var a1 = br.A1Fights ? "Fights" : "Waits";

            sb.AppendLine($"{ (br.A1Fights ? "Fights" : "Waits") } { (br.A1Fights ? br.A1Foe : "") }");

            //////////////////////////
            sb.AppendLine();
            sb.AppendLine("A2");
            sb.AppendLine($"Passes: { br.A2FocusPassed } - Keeps: { br.A2FocusKept }");

            foreach (Hex h in br.A2Hexes)
                sb.AppendLine($"Hexes: { h.FoeName } with { h.HexType.ToString() }");

            sb.AppendLine($"{ (br.A2Fights ? "Fights" : "Waits") } { (br.A2Fights ? br.A2Foe : "") }");

            //////////////////////////
            sb.AppendLine();
            sb.AppendLine("P1");
            sb.AppendLine($"{ (br.P1Fights ? "Fights" : "Waits") } { (br.P1Fights ? br.P1Foe : "") }");

            if (br.A1FocusPassed == 4)
                sb.AppendLine($"Shields A1 { ((br.A1FocusPassed == 4) ? " AND Shields A2" : "") }");
            else
                sb.AppendLine("Shields A1");

            //////////////////////////
            sb.AppendLine();
            sb.AppendLine("P2");
            sb.AppendLine($"{ (br.P2Fights ? "Fights" : "Waits") } { (br.P2Fights ? br.P2Foe : "") }");
            if (br.P2ShieldsA2) 
                sb.AppendLine($"{ (br.P2ShieldsA2 ? "Shields A2" : "") }") ;

            sb.AppendLine($"{ (br.Proficiency ? "Casts Proficiency" : "Waits for focus - No proficiency") }");

            return sb.ToString();
        }


        public static void CompareBoardResults(BoardResult b1, BoardResult b2)
        {
            // Magi response. Fight if at least 1 magi foe, else wait
            //bool IsMagiCorrect = CheckMagi(foes, userResult);
        }
    }


}
