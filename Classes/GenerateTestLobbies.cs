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
            lobbies.Add(new TestLobby("Lobby 3", "images/Lobby3.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(4, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.DarkWizard),
                new Foe(5, FoeType.Pixie, true)
            });
            lobbies.Add(new TestLobby("Lobby 4", "images/Lobby4.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.Acromantula),
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.DarkWizard, true)
            });
            lobbies.Add(new TestLobby("Lobby 5", "images/Lobby5.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Pixie),
                new Foe(5, FoeType.DarkWizard),
                new Foe(5, FoeType.DeathEater),
                new Foe(5, FoeType.Erkling, true),
                new Foe(4, FoeType.Werewolf)
            });
            lobbies.Add(new TestLobby("Lobby 6", "images/Lobby6.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Werewolf),
                new Foe(4, FoeType.Werewolf, true),
                new Foe(5, FoeType.Acromantula)
            });
            lobbies.Add(new TestLobby("Lobby 29", "images/Lobby29.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Werewolf),
                new Foe(3, FoeType.Pixie),
                new Foe(5, FoeType.Acromantula, true),
                new Foe(4, FoeType.Erkling),
                new Foe(5, FoeType.DeathEater)
            });
            lobbies.Add(new TestLobby("Lobby 31", "images/Lobby31.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Pixie),
                new Foe(3, FoeType.Werewolf),
                new Foe(3, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.Werewolf, true)
            });
            lobbies.Add(new TestLobby("Lobby 84", "images/Lobby84.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Erkling),
                new Foe(5, FoeType.DarkWizard),
                new Foe(5, FoeType.Erkling, true),
                new Foe(5, FoeType.DarkWizard, true),
                new Foe(5, FoeType.Erkling, true)
            });
            lobbies.Add(new TestLobby("Lobby 85", "images/Lobby85.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.DarkWizard),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling)
            });
            lobbies.Add(new TestLobby("Lobby 86", "images/Lobby86.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.DeathEater),
                new Foe(5, FoeType.DeathEater, true),
                new Foe(5, FoeType.Acromantula)
            });
            lobbies.Add(new TestLobby("Lobby 87", "images/Lobby87.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Erkling),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Werewolf),
                new Foe(4, FoeType.Erkling),
                new Foe(4, FoeType.DarkWizard)
            });
            lobbies.Add(new TestLobby("Lobby 88", "images/Lobby88.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Pixie, true),
                new Foe(5, FoeType.DeathEater),
                new Foe(4, FoeType.Erkling, true),
                new Foe(5, FoeType.Pixie),
                new Foe(3, FoeType.Werewolf)
            });
            lobbies.Add(new TestLobby("Lobby 89", "images/Lobby89.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.DarkWizard),
                new Foe(4, FoeType.DarkWizard),
                new Foe(4, FoeType.DeathEater),
                new Foe(3, FoeType.Werewolf),
                new Foe(4, FoeType.Werewolf)
            });
            lobbies.Add(new TestLobby("Lobby 90", "images/Lobby90.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(4, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Acromantula)
            });
            lobbies.Add(new TestLobby("Lobby 91", "images/Lobby91.png", foes.ToList()));

            lobbies.Add(new TestLobby("Lobby 92", "images/Lobby92.png", new List<Foe>{
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
            lobbies.Add(new TestLobby("Lobby 93", "images/Lobby93.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.Acromantula),
                new Foe(3, FoeType.Werewolf),
                new Foe(4, FoeType.Acromantula, true),
                new Foe(3, FoeType.Pixie)
            });
            lobbies.Add(new TestLobby("Lobby 94", "images/Lobby94.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.DeathEater, true),
                new Foe(4, FoeType.DeathEater, true),
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.DarkWizard)
            });
            lobbies.Add(new TestLobby("Lobby 95", "images/Lobby95.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(4, FoeType.Acromantula, true),
                new Foe(5, FoeType.Werewolf, true),
                new Foe(4, FoeType.Pixie),
                new Foe(5, FoeType.Pixie),
                new Foe(4, FoeType.Acromantula)
            });
            lobbies.Add(new TestLobby("Lobby 96", "images/Lobby96.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Erkling),
                new Foe(4, FoeType.Acromantula),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Acromantula),
                new Foe(4, FoeType.Pixie)
            });
            lobbies.Add(new TestLobby("Lobby 97", "images/Lobby97.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.DarkWizard, true),
                new Foe(3, FoeType.Acromantula),
                new Foe(5, FoeType.Erkling),
                new Foe(5, FoeType.Erkling)
            });
            lobbies.Add(new TestLobby("Lobby 98", "images/Lobby98.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.DeathEater),
                new Foe(5, FoeType.Erkling, true),
                new Foe(4, FoeType.Acromantula),
                new Foe(5, FoeType.Acromantula),
                new Foe(5, FoeType.DeathEater)
            });
            lobbies.Add(new TestLobby("Lobby 99", "images/Lobby99.png", foes.ToList()));

            foes.Clear();
            foes.AddRange(new Foe[] {
                new Foe(5, FoeType.Acromantula, true),
                new Foe(5, FoeType.Acromantula, true),
                new Foe(5, FoeType.Werewolf),
                new Foe(4, FoeType.DeathEater),
                new Foe(4, FoeType.DeathEater)
            });
            lobbies.Add(new TestLobby("Lobby 100", "images/Lobby100.png", foes.ToList()));


            return lobbies;
        }
    }
}
