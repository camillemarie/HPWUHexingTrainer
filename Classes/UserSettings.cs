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
        private bool showTimer = true;
        private bool showProficiency = true;
        private bool showResults = true;
        private string foeDisplayType = "Imposing Pixie";
        private bool showAdvancedRules = false;

        public string FoeDisplayType
        {
            get => foeDisplayType; set
            {
                foeDisplayType = value;
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

        public bool ShowAdvancedRules
        {
            get => showAdvancedRules; set
            {
                showAdvancedRules = value;
                RaisePropertyChanged();
            }
        }

        public string FoeFullName(Foe foe)
        {
            string r;

            if (foeDisplayType.Equals("3* Pixie"))
                r = foe.StarFoeName;

            else if (foeDisplayType.Equals("Imposing (3*) Pixie"))
                r = foe.FoeNameStarAndName;

            else
                r = foe.DefaultFoeName;
            return r;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
