using HPWUHexingTrainer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPWUHexingTrainer
{
    public class LobbyReader
    {
        static UserSettings _state;

        public static LobbyResult Read(List<Foe> foes, UserSettings state)
        {
            _state = state;

            LobbyResult br = new LobbyResult();
            br.Advanced = _state.ShowAdvancedRules;

            br.A2Hexes = new List<Hex>();
            br.A1Hexes = new List<Hex>();

            List<Foe> orderedAurorFoes = SetA2Details(foes, br);
            SetA1Details(foes, br);
            AssessProficiencyAndShieldForA2(br, orderedAurorFoes);

            br.Foes = foes;

            return br;
            //return PrepareReturnString(br);
        }



        #region A1
        private static void SetA1Details(List<Foe> foes, LobbyResult br)
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
                    br.P1Foe = _state.FoeFullName(f);
                }
                else
                {
                    br.P2Fights = true;
                    br.P2Foe = _state.FoeFullName(f);
                }

                if (f.Type == FoeType.Pixie)
                {
                    int pixieStars = 3;

                    if (_state.ShowAdvancedRules) // don't weaken 4 star pixies with advanced rules
                        pixieStars = 4;

                    if ((int)f.Stars > pixieStars)
                        AddHex(br, HexType.Weakening, _state.FoeFullName(f), true);
                }
                // it is a wolf
                else
                {
                    AddHex(br, HexType.Weakening, _state.FoeFullName(f), true);

                    if (f.Stars == StarName.Fierce)
                        AddHex(br, HexType.Confusion, _state.FoeFullName(f), true);



                    // if it is a 4 star wolf AND there will be no proficiency, also add a confusion
                    else if (f.Stars == StarName.Dangerous)
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

                            AddHex(br, HexType.Confusion, _state.FoeFullName(f), true);
                    }
                }
            }
            br.A1FocusPassed = 4 - br.A1Hexes.Count() - br.A1FocusKept;
        }
        #endregion

        #region A2
        private static List<Foe> SetA2Details(List<Foe> foes, LobbyResult br)
        {
            br.A2FocusPassed = 1; // A2 ALWAYS passes a focus regardless of the lobby

            AssessMagiFoes(foes, br);
            List<Foe> orderedAurorFoes = AssessAurorFoes(foes, br);

            br.A2FocusPassed = 4 - br.A2Hexes.Count - br.A2FocusKept;
            return orderedAurorFoes;
        }

        private static void AssessMagiFoes(List<Foe> foes, LobbyResult br)
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
                .OrderBy(m => m.Type == FoeType.Erkling && m.Stars == StarName.Imposing)
                .OrderBy(m => m.Type == FoeType.Acromantula && m.Stars == StarName.Imposing)
                .OrderBy(m => m.Type == FoeType.Acromantula && m.Stars == StarName.Dangerous)
                .OrderBy(m => m.Type == FoeType.Acromantula && m.Stars == StarName.Fierce)
                .OrderBy(m => m.Type == FoeType.Erkling && m.Stars == StarName.Dangerous)
                .OrderBy(m => m.Type == FoeType.Erkling && m.Stars == StarName.Fierce)
                .Take(1)
                .ToList();

            // if no magi mon, keep a focus for when one shows up
            if (orderedMagiFoes.Count() == 0)
                br.A2FocusKept += 1;
            else
            {
                if (orderedMagiFoes[0].Type == FoeType.Erkling && (int)orderedMagiFoes[0].Stars > 3)
                    AddHex(br, HexType.Confusion, _state.FoeFullName(orderedMagiFoes[0]), false);
                //AddHex(br, HexType.Confusion, orderedMagiFoes[0].ToString(), false);


                br.MagiFights = true;
                br.MagiFoe = _state.FoeFullName(orderedMagiFoes[0]);
            }
        }

        private static List<Foe> AssessAurorFoes(List<Foe> foes, LobbyResult br)
        {
            //    Imposing Dark Wizard->
            //    Imposing Death Eater -> 
            //    Dangerous Dark Wizard->
            //    Dangerous Death Eater -> 
            //    Fierce Death Eater -> 
            //    Fierce Dark Wizard

            List<Foe> orderedAurorFoes = orderedAurorFoes = foes
                 .Where(m => m.Elite == false && (m.Type == FoeType.DeathEater || m.Type == FoeType.DarkWizard))
                 .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Imposing)
                 .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Imposing)
                 .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Dangerous)
                 .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Dangerous)
                 .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Fierce)
                 .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Fierce)
                 .Take(2)
                 .ToList();



            //List<Foe> orderedAurorFoes = foes
            //    .Where(a => a.Elite == false && (a.Type == FoeType.DeathEater || a.Type == FoeType.DarkWizard))
            //    .OrderBy(a => a.Stars)
            //    .ThenBy(a => a.Type.ToString())
            //    .Take(2)
            //    .ToList();

            // if no auror mons, keep 2 focus for when they show up
            if (orderedAurorFoes.Count == 0)
                br.A2FocusKept += 2;

            else if (orderedAurorFoes.Count == 1)
                br.A2FocusKept += 1; // keep 1 for the 2nd auror that has nothing to fight straight away

            else
            {
                // standard rule - we have 2 auror foes, reverse the order as A1 has a shield so gets the harder foe
                if (!_state.ShowAdvancedRules)
                    orderedAurorFoes.Reverse();
                else
                    // advanced rule - don't reverse if easier mon could be taken by A1 without a hex and next mon is dangerous dark wizard
                    if (!(orderedAurorFoes[0].Stars == StarName.Imposing &&
                            orderedAurorFoes[1].Stars == StarName.Dangerous && orderedAurorFoes[1].Type == FoeType.DarkWizard))
                    orderedAurorFoes.Reverse();
            }

            for (int cnt = 0; cnt < orderedAurorFoes.Count(); cnt++)
            {
                Foe f = orderedAurorFoes[cnt];

                if (cnt == 0)
                {
                    br.A1Fights = true;
                    br.A1Foe = _state.FoeFullName(f);

                    // This is the foe that Auror 1 will take, this Auror will always have a shield so don't hex 3 star
                    if ((int)f.Stars == 3)
                        continue;
                }
                else
                {
                    br.A2Fights = true;
                    br.A2Foe = _state.FoeFullName(f);
                }

                if (f.Stars == StarName.Fierce && f.Type == FoeType.DarkWizard)
                {
                    AddHex(br, HexType.Confusion, _state.FoeFullName(orderedAurorFoes[cnt]), false);

                    // Double hex the 5 star dark wizard for A1 as it always has a shield 
                    // & A2 as it will also need a shield due to 2 x 5 star Auror foes

                    // Don't double weaken in the initial lobby to get proficiency up quicker.
                    //if (br.A2Hexes.Count <= 3) // if we've hexed the magi + double hexed A1, we can only add 1 hex for A2
                    //    AddHex(br, HexType.Weakening, orderedAurorFoes[cnt].ToString(), false);
                }
                else
                {
                    if (!_state.ShowAdvancedRules)
                        AddHex(br, HexType.Weakening, _state.FoeFullName(orderedAurorFoes[cnt]), false);
                    else
                    {
                        // Advance rules, hold off on weakening 4* DE at this stage. Wait until the proficiency stage to determine that.
                        if (!(orderedAurorFoes[cnt].Stars == StarName.Dangerous && orderedAurorFoes[cnt].Type == FoeType.DeathEater))
                        {
                            AddHex(br, HexType.Weakening, _state.FoeFullName(orderedAurorFoes[cnt]), false);
                        }
                    }


                }
            }

            //// we need to shield A2 due to hard Auror foes
            //var num5StarAurorFoes = orderedAurorFoes.Where(a => a.Stars == StarName.Fierce).Count();
            //br.P2ShieldsA2 = num5StarAurorFoes == 2 ? true : false;



            return orderedAurorFoes;
        }

        #endregion


        private static void AssessProficiencyAndShieldForA2(LobbyResult br, List<Foe> orderedAurorFoes)
        {
            var focusAvailableToProfs = br.A1FocusPassed + br.A2FocusPassed;
            var num5StarAurorFoes = orderedAurorFoes.Where(a => a.Stars == StarName.Fierce).Count();

            if (_state.ShowAdvancedRules)
                // advanced rules
                FocusAdvancedRules(br, focusAvailableToProfs, num5StarAurorFoes, orderedAurorFoes);
            else
            {
                /* determine if we need 2 shields 
                            *  - P2 has 7 focus but both Aurors will fight 5 stars
                            *  - P2 doesn't have 7 focus and lobby has 5 star mon or 4 star DE
                            */
                // we've got enough focus for proficiency
                if (focusAvailableToProfs >= 3)
                {
                    // how many hard auror foes?


                    if (!_state.ShowAdvancedRules)
                    {
                        // if we have 2 hard auror foes, proficiency is false. Either way P2 shield A2 is opposite value to proficiency
                        br.Proficiency = num5StarAurorFoes != 2;
                        br.P2ShieldsA2 = !br.Proficiency;
                    }

                }
                else
                {
                    // we don't have enough for proficiency, give all we've got to P2
                    //focusForP2 = focusAvailableToProfs;

                    // we didn't get proficiency and have hard auror foes??
                    br.Proficiency = false; // we didn't get passed enough focus

                    // if we have 2 auror foes and not enough focus, see if A2 needs a shield
                    if (orderedAurorFoes.Count == 2)
                    {
                        var a2Shield = orderedAurorFoes[1].Stars == StarName.Fierce ||
                                (orderedAurorFoes[1].Stars == StarName.Dangerous && orderedAurorFoes[1].Type == FoeType.DeathEater);
                        br.P2ShieldsA2 = a2Shield;
                    }
                }
            }


        }

        private static void FocusAdvancedRules(LobbyResult br, int focusAvailableToProfs, int num5StarAurorFoes, List<Foe> orderedAurorFoes)
        {
            br.Proficiency = true; // we'll work out the real answer below, default to true for now.

            // get the count of 4* DEs, these haven't been hexed yet,
            int DangerousDeathEaters = orderedAurorFoes.Where(a => a.Stars == StarName.Dangerous && a.Type == FoeType.DeathEater).Count();


            // if we have 5 focus passed, we have enough to shield both aurors AND cast proficiency
            if (focusAvailableToProfs >= 5)
            {
                br.P1ShieldsA2 = true;
                // don't add a weakening hex to any 4* Death Eater, don't need to change hexes
            }
            else if (num5StarAurorFoes == 2) // we don't have enough focus for P1 to shield A2 so P2 needs to do so as we have 2 x 5* auror foes
            {
                br.Proficiency = false;
                br.P2ShieldsA2 = !br.Proficiency;

                //// as P2 has used focus to Shield A2, A1 & A2 pass all focus to P2 to work towards proficiency
                //br.A1FocusPassedToP2 = br.A1FocusPassed;
                //br.A2FocusPassedToP2 = br.A2FocusPassed;

                // we don't have any 4* as we have 2 x 5*, don't need to change hexes
            }
            else
            // we don't have 5 focus passed and we don't have 2 5* auror foes, these are the hard cases
            {
                if (DangerousDeathEaters == 0)
                {
                    // easy peasy, nothing to do
                }
                else if (focusAvailableToProfs < 3)
                {
                    // we are NOT getting proficency, add a weakening hex to each dangerous death eater
                    foreach (Foe f in orderedAurorFoes)
                    {
                        if (f.Stars == StarName.Dangerous && f.Type == FoeType.DeathEater)
                        {
                            AddHex(br, HexType.Weakening, _state.FoeFullName(f), false);
                            br.A2FocusPassed -= 1;
                        }
                    }
                }
                else // we potentially have enough for proficiency - hardest case
                {
                    // if we have only 1 4* DE & Auror 1 is fighting it, he will have a shield so long as focus passed >= 3
                    if (DangerousDeathEaters == 1 && orderedAurorFoes[0].Stars == StarName.Dangerous && orderedAurorFoes[0].Type == FoeType.DeathEater)
                    {
                        // do nothing, proficiency is up and A1 always gets a shield
                    }
                    else
                    {
                        // if A2 is fighting a 4* DE he needs a hex 
                        if (orderedAurorFoes[1].Stars == StarName.Dangerous && orderedAurorFoes[1].Type == FoeType.DeathEater)
                        {
                            AddHex(br, HexType.Weakening, _state.FoeFullName(orderedAurorFoes[1]), false);
                            br.A2FocusPassed -= 1;
                        }

                        // if A1 is also fighting a 4* DE we need to check if we still have enough for proficiency? If not, A1 also needs a hex
                        if (br.A1FocusPassed + br.A2FocusPassed < 3 &&
                                orderedAurorFoes[0].Stars == StarName.Dangerous && orderedAurorFoes[0].Type == FoeType.DeathEater)
                        {
                            AddHex(br, HexType.Weakening, _state.FoeFullName(orderedAurorFoes[0]), false);
                            br.A2FocusPassed -= 1;
                        }
                    }
                }
            }


            // do we still have enough focus for proficiency?
            br.Proficiency = br.A1FocusPassed + br.A2FocusPassed >= 3;

            if (br.Proficiency)
            {
                // if A2 has 4 focus, send 3 to P2 and 1 to P1, otherwise send it all to P2
                if (br.A2FocusPassed == 4)
                {
                    br.A2FocusPassedToP2 = 3;
                    br.A2FocusPassedToP1 = 1;
                }
                else
                {
                    br.A2FocusPassedToP2 = br.A2FocusPassed;
                    br.A2FocusPassedToP1 = 0;
                }

                // A1 needs to pass enough so that P2 gets 3 total and P1 gets the rest
                br.A1FocusPassedToP2 = 3 - br.A2FocusPassedToP2;
                br.A1FocusPassedToP1 = br.A1FocusPassed - br.A1FocusPassedToP2;
            }
            else
            {
                // no proficiency, send it all to P2
                br.A2FocusPassedToP2 = br.A2FocusPassed;
                br.A1FocusPassedToP2 = br.A1FocusPassed;

            }
        }




        private static void AddHex(LobbyResult br, HexType type, string foeName, bool isAuror1)
        {
            Hex h = new Hex();
            h.HexType = type;
            h.FoeName = foeName;

            if (isAuror1)
                br.A1Hexes.Add(h);
            else
                br.A2Hexes.Add(h);
        }


        public static void CompareLobbyResults(LobbyResult b1, LobbyResult b2)
        {
            // Magi response. Fight if at least 1 magi foe, else wait
            //bool IsMagiCorrect = CheckMagi(foes, userResult);
        }
    }
}



