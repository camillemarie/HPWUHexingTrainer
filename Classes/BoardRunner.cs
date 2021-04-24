using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPWUHexingInitialBoard
{
    public class BoardRunner
    {
        public static List<BoardResult> ReadAllBoards()
        {
            List<BoardResult> results = new List<BoardResult>();
            StringBuilder csv = new StringBuilder();

            List<Foe> uniqueFoes = GetUniqueFoes();

            csv.AppendLine(AddCsvColumnHeaders());

            // we now have a list of the 36 different foe types
            // we need to loop through all the combos and get results from each board posibility
            DateTime startTime = DateTime.Now;
            for (int f1 = 0; f1 < 2; f1++)
            {
                for (int f2 = 0; f2 < 2; f2++)
                {
                    for (int f3 = 0; f3 < 2; f3++)
                    {
                        for (int f4 = 0; f4 < 2; f4++)
                        {
                            for (int f5 = 0; f5 < 2; f5++)
                            {
                                List<Foe> foes = new List<Foe>();
                                foes.Add(uniqueFoes[f1]);
                                foes.Add(uniqueFoes[f2]);
                                foes.Add(uniqueFoes[f3]);
                                foes.Add(uniqueFoes[f4]);
                                foes.Add(uniqueFoes[f5]);

                                BoardResult br = BoardReader.Read(foes);

                                results.Add(br);
                                //csv.AppendLine(BuildCsvLine(br));
                            }
                        }
                    }
                }
            }

            BuildCsv(results);
            AnalyseResults(results);

            DateTime endTime = DateTime.Now;
            TimeSpan duration = endTime - startTime;

            return results;
        }


        private static List<Foe> GetUniqueFoes()
        {

            // we have 3,4 or 5 stars
            // we have 6 types of foes
            // we have 2 types of Elite (yes and no)

            // for each combo of star
            List<Foe> uniqueFoes = new List<Foe>();
            for (int star = 3; star <= 5; star++)
            {
                for (int foetype = 0; foetype < 6; foetype++)
                {
                    for (int elite = 0; elite < 2; elite++)
                    {
                        Foe f = new Foe();
                        f.Stars = star;
                        f.Type = (FoeType)foetype;
                        f.Elite = elite == 0 ? false : true;
                        uniqueFoes.Add(f);
                    }
                }
            }
            return uniqueFoes;
        }

        private static string AddCsvColumnHeaders()
        {
            return "Foe 1, Foe 2, Foe 3";
        }

        private static string BuildCsv(List<BoardResult> results)
        {
            string blah;
            using (var writer = new StreamWriter(@".\results.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(results);
                blah = csv.ToString();
            }

            return blah;
        }

        private static void AnalyseResults(List<BoardResult> results)
        {
            List<BoardResult> proficiency = results.Where(r => r.Proficiency == true).ToList();
            List<BoardResult> noProficiency = results.Where(r => r.Proficiency == false).ToList();


            int focusKept = results.Sum(r => r.A1FocusKept + r.A2FocusKept);
            int focusPassed = results.Sum(r => r.A1FocusPassed + r.A2FocusPassed);
            int focusForHexes = results.Sum(r => r.A1Hexes.Count + r.A2Hexes.Count);

            int peopleFighting = results.Count(r => r.A1Fights) +
                results.Count(r => r.A2Fights) +
                results.Count(r => r.MagiFights) +
                results.Count(r => r.P1Fights) +
                results.Count(r => r.P2Fights);

            int peopleWaiting = (results.Count * 5) - peopleFighting;

        }
    }
}
