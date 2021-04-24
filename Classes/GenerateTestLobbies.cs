using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPWUHexingTrainer
{
    class GenerateTestLobbies
    {

        public static List<TestLobby> Create()
        {
            List<TestLobby> lobbies = new List<TestLobby>();

            List<Foe> foes = new List<Foe>();

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Pixie, true),
                new Foe(5, FoeType.Acromantula),
                new Foe(4, FoeType.Acromantula),
                new Foe(4, FoeType.Werewolf),
                new Foe(3, FoeType.Erkling)
            });
            lobbies.Add(new TestLobby("Lobby 3", "images/lobbies/Lobby3.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(4, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.DarkWizard),
                new Foe(5, FoeType.Pixie, true)
            });
            lobbies.Add(new TestLobby("Lobby 4", "images/lobbies/Lobby4.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.Acromantula),
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.DarkWizard, true)
            });
            lobbies.Add(new TestLobby("Lobby 5", "images/lobbies/Lobby5.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Pixie),
                new Foe(5, FoeType.DarkWizard),
                new Foe(5, FoeType.DeathEater),
                new Foe(5, FoeType.Erkling, true),
                new Foe(4, FoeType.Werewolf)
            });
            lobbies.Add(new TestLobby("Lobby 6", "images/lobbies/Lobby6.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Werewolf),
                new Foe(4, FoeType.Werewolf, true),
                new Foe(5, FoeType.Acromantula)
            });
            lobbies.Add(new TestLobby("Lobby 29", "images/lobbies/Lobby29.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Werewolf),
                new Foe(3, FoeType.Pixie),
                new Foe(5, FoeType.Acromantula, true),
                new Foe(4, FoeType.Erkling),
                new Foe(5, FoeType.DeathEater)
            });
            lobbies.Add(new TestLobby("Lobby 31", "images/lobbies/Lobby31.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Pixie),
                new Foe(3, FoeType.Werewolf),
                new Foe(3, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.Werewolf, true)
            });
            lobbies.Add(new TestLobby("Lobby 84", "images/lobbies/Lobby84.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Erkling),
                new Foe(5, FoeType.DarkWizard),
                new Foe(5, FoeType.Erkling, true),
                new Foe(5, FoeType.DarkWizard, true),
                new Foe(5, FoeType.Erkling, true)
            });
            lobbies.Add(new TestLobby("Lobby 85", "images/lobbies/Lobby85.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.DarkWizard),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling)
            });
            lobbies.Add(new TestLobby("Lobby 86", "images/lobbies/Lobby86.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.DeathEater, true),
                new Foe(5, FoeType.Acromantula)
            });
            lobbies.Add(new TestLobby("Lobby 87", "images/lobbies/Lobby87.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Erkling),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Werewolf),
                new Foe(4, FoeType.Erkling),
                new Foe(4, FoeType.DarkWizard)
            });
            lobbies.Add(new TestLobby("Lobby 88", "images/lobbies/Lobby88.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Pixie, true),
                new Foe(5, FoeType.DeathEater),
                new Foe(4, FoeType.Erkling, true),
                new Foe(5, FoeType.Pixie),
                new Foe(3, FoeType.Werewolf)
            });
            lobbies.Add(new TestLobby("Lobby 89", "images/lobbies/Lobby89.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.DarkWizard),
                new Foe(4, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(3, FoeType.Werewolf),
                new Foe(4, FoeType.Werewolf)
            });
            lobbies.Add(new TestLobby("Lobby 90", "images/lobbies/Lobby90.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Acromantula)
            });
            lobbies.Add(new TestLobby("Lobby 91", "images/lobbies/Lobby91.png", foes.ToList()));

            lobbies.Add(new TestLobby("Lobby 92", "images/lobbies/Lobby92.png", new List<Foe>{
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
            lobbies.Add(new TestLobby("Lobby 93", "images/lobbies/Lobby93.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.Werewolf),
                new Foe(4, FoeType.Acromantula, true),
                new Foe(3, FoeType.Pixie)
            });
            lobbies.Add(new TestLobby("Lobby 94", "images/lobbies/Lobby94.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.DeathEater, true),
                new Foe(4, FoeType.DeathEater, true),
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.DarkWizard)
            });
            lobbies.Add(new TestLobby("Lobby 95", "images/lobbies/Lobby95.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Acromantula, true),
                new Foe(5, FoeType.Werewolf, true),
                new Foe(4, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Acromantula)
            });
            lobbies.Add(new TestLobby("Lobby 96", "images/lobbies/Lobby96.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(4, FoeType.Acromantula),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Acromantula),
                new Foe(4, FoeType.Pixie)
            });
            lobbies.Add(new TestLobby("Lobby 97", "images/lobbies/Lobby97.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.DarkWizard, true),
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.Erkling)
            });
            lobbies.Add(new TestLobby("Lobby 98", "images/lobbies/Lobby98.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.DeathEater),
                new Foe(5, FoeType.Erkling, true),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Acromantula),
                new Foe(5, FoeType.DeathEater)
            });
            lobbies.Add(new TestLobby("Lobby 99", "images/lobbies/Lobby99.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Acromantula, true),
                new Foe(5, FoeType.Acromantula, true),
                new Foe(5, FoeType.Werewolf),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.DeathEater)
            });
            lobbies.Add(new TestLobby("Lobby 100", "images/lobbies/Lobby100.png", foes.ToList()));


            return lobbies;
        }
    }
}
