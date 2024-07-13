using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conversion : ContentPage
    {
        double cm;
        double m;
        public Conversion()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            cm = Convert.ToDouble(Txtcm.Text);
            m = cm / 100;
            LabelResult.Text = m.ToString() + "m";
        }

        private void Validate()
        {
            if(!string.IsNullOrEmpty(Txtcm.Text))
            {
                Calculate();
            } 
            else
            {
                DisplayAlert("Error", "Enter an amount", "OK");
            }
        }

        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void BtnCalculate_Clicked(object sender, EventArgs e)
        {
            Validate();
        }
    }
}