using System.Windows.Input;
using Xamarin.Forms;

namespace testBindable
{
    public partial class testBindablePage : ContentPage
    {
        public testBindablePage ()
        {
            var vm = new MainPageViewModel ();

            InitializeComponent ();

            BindingContext = vm;

        }

    }
}
