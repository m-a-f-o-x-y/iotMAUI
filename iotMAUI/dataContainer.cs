using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace iotMAUI
{
    internal class dataContainer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool VaccumState
        {
            get;
            set
            {
                field = value;

                if (field)
                {
                    VacuumMsg = "Odkurzacz włączono";
                    Button2Msg = "Wyłącz";
                }
                else
                {
                    VacuumMsg = "Odkurzacz wyłączono";
                    Button2Msg = "Włącz";

                }

                OnPropertyChanged();
            }
        } = false;

        public bool VacuumIsCharged
        {
            get;
            set
            {
                field = value;

                if (field)
                {
                    VacuumStateMsg = "Status: naładowany";
                }
                else
                {
                    VacuumStateMsg = "Status: rozładowany";
                }

                OnPropertyChanged();
            }
        } = true;
        public int WasherProgram
        {
            get; 
            set
            {
                if (value > 0 || value <= 12)
                {
                    field = value; 
                    WasherMsg = $"Numer prania: {field}";
                }
                else
                {
                    field = 0;
                    WasherMsg = "Numer prania: nie wybrano";

                }


                OnPropertyChanged();
            }
        } = 0;

        public string WasherMsg { get; set; } = "Numer prania: nie podano";
        public string VacuumMsg { get; set { OnPropertyChanged(); } } = "Odkurzacz wyłączony";
        public string VacuumStateMsg { get; set { OnPropertyChanged(); } } = "Status: naładowany";
        public string Button2Msg { get; set { OnPropertyChanged(); } } = "Włącz";


    }
}
