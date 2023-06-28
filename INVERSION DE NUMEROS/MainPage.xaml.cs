using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace INVERSION_DE_NUMEROS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (num1.Text != null && num2.Text != null && num3.Text != null)
                {

                    string numeroInicio = num1.Text;
                    num1.Text = num3.Text;
                    num2.Text = num2.Text;
                    num3.Text = numeroInicio;

                }
                else
                {
                    await DisplayAlert("Alerta", "Revise que los campos esten completos", "Aceptar");
                }
            }catch (Exception ex)
            {
                await DisplayAlert("Alerta", "Ocurrio un error" + ex.Message, "Aceptar");
            }
        }
    }
}
