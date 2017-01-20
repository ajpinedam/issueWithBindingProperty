using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace testBindable
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel ()
        {
            this.Test2 = new Command (test);

            Texto = "Clickeame plz";
        }

        public void test ()
        {
            Application.Current.MainPage.DisplayAlert ("it works", "it works", "it works");
        }

        private string _Texto;
        public string Texto
        {
            get { return _Texto; }
            set
            {
                if (_Texto == value)
                    return;

                _Texto = value;
                OnPropertyChanged (nameof(Texto));
            }
        }

        //Text="{Binding Texto}" 

        private string _Color;
        public string Color
        {
            get { return _Color; }
            set
            {
                if (_Color == value)
                    return;

                _Color = value;
                OnPropertyChanged (nameof (Color));
            }
        }

        private bool _IsActive;
        public bool IsActive
        {
            get { return _IsActive; }
            set
            {
                if (_IsActive == value)
                    return;

                _IsActive = value;
                OnPropertyChanged (nameof (IsActive));
            }
        }

        public ICommand Test2 { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged ([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (propertyName));
        }
    }
}
