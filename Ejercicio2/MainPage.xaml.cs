using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static SQLite.SQLite3;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // FUNCION ENVIAR
        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var datos = new Modelos.Datos
                {
                    rNombre = nombre.Text,
                    rApellidos = apellidos.Text,
                    rEdad = edad.Text,
                    rCorreo = correo.Text
                };

                //await DisplayAlert("Datos", "Nombre " + nombre.Text, "LISTO");

                var pagina = new Paginas.Page2();
                pagina.BindingContext = datos;
                await Navigation.PushAsync(pagina);

                ClearControls();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        // LIMPIAR
        private void ClearControls()
        {
            nombre.Text = "";
            apellidos.Text = "";
            edad.Text = "";
            correo.Text = "";

        }

    }
}
