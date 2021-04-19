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
            boards.Add(new TestBoard("Board 3", "./Images/Board3.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(4, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.DarkWizard),
                new Foe(5, FoeType.Pixie, true)
            });
            boards.Add(new TestBoard("Board 4", "./Images/Board4.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.Acromantula),
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.DarkWizard, true)
            });
            boards.Add(new TestBoard("Board 5", "./Images/Board5.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Pixie),
                new Foe(5, FoeType.DarkWizard),
                new Foe(5, FoeType.DeathEater),
                new Foe(5, FoeType.Erkling, true),
                new Foe(4, FoeType.Werewolf)
            });
            boards.Add(new TestBoard("Board 6", "./Images/Board6.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Werewolf),
                new Foe(4, FoeType.Werewolf, true),
                new Foe(5, FoeType.Acromantula)
            });
            boards.Add(new TestBoard("Board 29", "./Images/Board29.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Werewolf),
                new Foe(3, FoeType.Pixie),
                new Foe(5, FoeType.Acromantula, true),
                new Foe(4, FoeType.Erkling),
                new Foe(5, FoeType.DeathEater)
            });
            boards.Add(new TestBoard("Board 31", "./Images/Board31.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Pixie),
                new Foe(3, FoeType.Werewolf),
                new Foe(3, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.Werewolf, true)
            });
            boards.Add(new TestBoard("Board 84", "./Images/Board84.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Erkling),
                new Foe(5, FoeType.DarkWizard),
                new Foe(5, FoeType.Erkling, true),
                new Foe(5, FoeType.DarkWizard, true),
                new Foe(5, FoeType.Erkling, true)
            });
            boards.Add(new TestBoard("Board 85", "./Images/Board85.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.DarkWizard),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling)
            });
            boards.Add(new TestBoard("Board 86", "./Images/Board86.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.DeathEater, true),
                new Foe(5, FoeType.Acromantula)
            });
            boards.Add(new TestBoard("Board 87", "./Images/Board87.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Erkling),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Werewolf),
                new Foe(4, FoeType.Erkling),
                new Foe(4, FoeType.DarkWizard)
            });
            boards.Add(new TestBoard("Board 88", "./Images/Board88.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Pixie, true),
                new Foe(5, FoeType.DeathEater),
                new Foe(4, FoeType.Erkling, true),
                new Foe(5, FoeType.Pixie),
                new Foe(3, FoeType.Werewolf)
            });
            boards.Add(new TestBoard("Board 89", "./Images/Board89.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.DarkWizard),
                new Foe(4, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(3, FoeType.Werewolf),
                new Foe(4, FoeType.Werewolf)
            });
            boards.Add(new TestBoard("Board 90", "./Images/Board90.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Acromantula)
            });
            boards.Add(new TestBoard("Board 91", "./Images/Board91.png", foes.ToList()));

            boards.Add(new TestBoard("Board 92", "./Images/Board92.png", new List<Foe>{
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
            boards.Add(new TestBoard("Board 93", "./Images/Board93.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.Werewolf),
                new Foe(4, FoeType.Acromantula, true),
                new Foe(3, FoeType.Pixie)
            });
            boards.Add(new TestBoard("Board 94", "./Images/Board94.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.DeathEater, true),
                new Foe(4, FoeType.DeathEater, true),
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.DarkWizard)
            });
            boards.Add(new TestBoard("Board 95", "./Images/Board95.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Acromantula, true),
                new Foe(5, FoeType.Werewolf, true),
                new Foe(4, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Acromantula)
            });
            boards.Add(new TestBoard("Board 96", "./Images/Board96.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(4, FoeType.Acromantula),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Acromantula),
                new Foe(4, FoeType.Pixie)
            });
            boards.Add(new TestBoard("Board 97", "./Images/Board97.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.DarkWizard, true),
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.Erkling)
            });
            boards.Add(new TestBoard("Board 98", "./Images/Board98.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.DeathEater),
                new Foe(5, FoeType.Erkling, true),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Acromantula),
                new Foe(5, FoeType.DeathEater)
            });
            boards.Add(new TestBoard("Board 99", "./Images/Board99.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Acromantula, true),
                new Foe(5, FoeType.Acromantula, true),
                new Foe(5, FoeType.Werewolf),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.DeathEater)
            });
            boards.Add(new TestBoard("Board 100", "./Images/Board100.png", foes.ToList()));


            return boards;
        }
    }
}
