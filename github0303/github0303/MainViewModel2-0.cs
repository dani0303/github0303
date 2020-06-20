using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace github0303
{
    class MainViewModel2_0 : INotifyPropertyChanged
    {
        string email = string.Empty;

        public string Email
        {
            get => email;

            set
            {
                if (email == value)
                    return;

                email = value;

                OnPropertyChanged(nameof(Email));

            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string email)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(email));
        }
    }
}
