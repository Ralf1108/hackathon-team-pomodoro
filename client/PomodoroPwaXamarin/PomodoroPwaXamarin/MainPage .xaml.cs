using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PomodoroPwaXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new ListModel();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            label2.Text = "clicked!!!";
        }
    }
}