using System.Windows.Input;
using Xamarin.Forms;

namespace testBindable
{
    public partial class Control1 : ContentView
    {
        private static readonly BindableProperty Test1Property = BindableProperty.Create (nameof(Test1), typeof (ICommand), typeof (Control1), null);

        private static BindableProperty TextProperty = BindableProperty.Create (
                           propertyName: nameof (Text),
                           returnType: typeof (string), 
                           declaringType: typeof (Control1), 
                           defaultValue: null,
                            propertyChanged:HandleBindingPropertyChangedDelegate);

        public Control1 ()
        {
            InitializeComponent ();

            BindingContext = this;
        }

        public ICommand Test1
        {
            get
            {
                return (ICommand)GetValue (Test1Property);
            }
            set
            {
                SetValue (Test1Property, value);
            }
        }

        public string Text
        { 
            get { return (string)GetValue (TextProperty);}
            set { SetValue (TextProperty, value); }
        }

        static void HandleBindingPropertyChangedDelegate (BindableObject bindable, object oldValue, object newValue)
        {
            var control1 = bindable as Control1;

            if (control1 == null)
                return;

            var value = newValue as string;

            if (value == null)
                return;

            control1.MyButton.Text = value;
        }
    }
}
