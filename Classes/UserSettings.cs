using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HPWUHexingTrainer.Classes
{

    // The class that stores the user settings
    public class UserSettings : INotifyPropertyChanged
    {
        private string username;
        private bool showTimer = true;
        private bool showProficiency = true;
        private bool showResults = true;

        public string Username
        {
            get => username; set
            {
                username = value;
                RaisePropertyChanged();
            }
        }
        public bool ShowTimer
        {
            get => showTimer; set
            {
                showTimer = value;
                RaisePropertyChanged();
            }
        }
        public bool ShowProficiency
        {
            get => showProficiency; set
            {
                showProficiency = value;
                RaisePropertyChanged();
            }
        }
        public bool ShowResults
        {
            get => showResults; set
            {
                showResults = value;
                RaisePropertyChanged();
            }
        }

        public string FoeFullName(Foe foe)
        {
            string r;

            if (showTimer)
                r = foe.DefaultFoeName;
            else
                r = foe.StarFoeName;

            return r;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
