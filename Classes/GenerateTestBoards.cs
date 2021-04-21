using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPWUHexingInitialBoard
{
    class GenerateTestBoards
    {

        public static List<TestBoard> Create()
        {
            List<TestBoard> boards = new List<TestBoard>();

            List<Foe> foes = new List<Foe>();

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Pixie, true),
                new Foe(5, FoeType.Acromantula),
                new Foe(4, FoeType.Acromantula),
                new Foe(4, FoeType.Werewolf),
                new Foe(3, FoeType.Erkling)
            });
            boards.Add(new TestBoard("Board 3", "images/Board3.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(4, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.DarkWizard),
                new Foe(5, FoeType.Pixie, true)
            });
            boards.Add(new TestBoard("Board 4", "images/Board4.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.Acromantula),
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.DarkWizard, true)
            });
            boards.Add(new TestBoard("Board 5", "images/Board5.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Pixie),
                new Foe(5, FoeType.DarkWizard),
                new Foe(5, FoeType.DeathEater),
                new Foe(5, FoeType.Erkling, true),
                new Foe(4, FoeType.Werewolf)
            });
            boards.Add(new TestBoard("Board 6", "images/Board6.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Werewolf),
                new Foe(4, FoeType.Werewolf, true),
                new Foe(5, FoeType.Acromantula)
            });
            boards.Add(new TestBoard("Board 29", "images/Board29.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Werewolf),
                new Foe(3, FoeType.Pixie),
                new Foe(5, FoeType.Acromantula, true),
                new Foe(4, FoeType.Erkling),
                new Foe(5, FoeType.DeathEater)
            });
            boards.Add(new TestBoard("Board 31", "images/Board31.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Pixie),
                new Foe(3, FoeType.Werewolf),
                new Foe(3, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.Werewolf, true)
            });
            boards.Add(new TestBoard("Board 84", "images/Board84.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Erkling),
                new Foe(5, FoeType.DarkWizard),
                new Foe(5, FoeType.Erkling, true),
                new Foe(5, FoeType.DarkWizard, true),
                new Foe(5, FoeType.Erkling, true)
            });
            boards.Add(new TestBoard("Board 85", "images/Board85.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.DarkWizard),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling)
            });
            boards.Add(new TestBoard("Board 86", "images/Board86.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.DeathEater, true),
                new Foe(5, FoeType.Acromantula)
            });
            boards.Add(new TestBoard("Board 87", "images/Board87.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Erkling),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Werewolf),
                new Foe(4, FoeType.Erkling),
                new Foe(4, FoeType.DarkWizard)
            });
            boards.Add(new TestBoard("Board 88", "images/Board88.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Pixie, true),
                new Foe(5, FoeType.DeathEater),
                new Foe(4, FoeType.Erkling, true),
                new Foe(5, FoeType.Pixie),
                new Foe(3, FoeType.Werewolf)
            });
            boards.Add(new TestBoard("Board 89", "images/Board89.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.DarkWizard),
                new Foe(4, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(3, FoeType.Werewolf),
                new Foe(4, FoeType.Werewolf)
            });
            boards.Add(new TestBoard("Board 90", "images/Board90.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Acromantula)
            });
            boards.Add(new TestBoard("Board 91", "images/Board91.png", foes.ToList()));

            boards.Add(new TestBoard("Board 92", "images/Board92.png", new List<Foe>{
                new Foe(5, FoeType.Acromantula),
                new Foe(5, FoeType.DarkWizard),
                new Foe(3, FoeType.DeathEater),
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.Erkling)
            }));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Pixie),
                new Foe(3, FoeType.Pixie),
                new Foe(4, FoeType.Erkling),
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.Acromantula)
            });
            boards.Add(new TestBoard("Board 93", "images/Board93.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.Werewolf),
                new Foe(4, FoeType.Acromantula, true),
                new Foe(3, FoeType.Pixie)
            });
            boards.Add(new TestBoard("Board 94", "images/Board94.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.DeathEater, true),
                new Foe(4, FoeType.DeathEater, true),
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.DarkWizard)
            });
            boards.Add(new TestBoard("Board 95", "images/Board95.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Acromantula, true),
                new Foe(5, FoeType.Werewolf, true),
                new Foe(4, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Acromantula)
            });
            boards.Add(new TestBoard("Board 96", "images/Board96.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(4, FoeType.Acromantula),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Acromantula),
                new Foe(4, FoeType.Pixie)
            });
            boards.Add(new TestBoard("Board 97", "images/Board97.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.DarkWizard, true),
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.Erkling)
            });
            boards.Add(new TestBoard("Board 98", "images/Board98.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.DeathEater),
                new Foe(5, FoeType.Erkling, true),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Acromantula),
                new Foe(5, FoeType.DeathEater)
            });
            boards.Add(new TestBoard("Board 99", "images/Board99.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Acromantula, true),
                new Foe(5, FoeType.Acromantula, true),
                new Foe(5, FoeType.Werewolf),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.DeathEater)
            });
            boards.Add(new TestBoard("Board 100", "images/Board100.png", foes.ToList()));


            return boards;
        }
    }
}
