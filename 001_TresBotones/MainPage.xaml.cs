using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _001_TresBotones
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Metodo que se inicia al cargar la pagina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            var btn3 = new Button();

            //Propiedades
            btn3.Content = "Boton 3";
            btn3.Width = 200;
            btn3.Height = 70;
            btn3.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Yellow);
            btn3.FontSize = 16;
            btn3.HorizontalContentAlignment = HorizontalAlignment.Center;
            btn3.VerticalContentAlignment = VerticalAlignment.Center;
            btn3.HorizontalAlignment = HorizontalAlignment.Center;
            btn3.FontFamily = new FontFamily("Verdana");
            btn3.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            btn3.FontWeight = FontWeights.Bold;

            //Se añade al stackpanel
            stp1.Children.Add(btn3);

            //var EventHandler myEventHandler = new EventHandler;
            //btn3.Click += new System.EventHandler(this.myEventHandler);

            btn3.Click += btn3_Click;

        }

        /// <summary>
        /// Onclick del boton generado en tiempo de ejecucion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn3_Click(object sender, RoutedEventArgs e)
        {

            MessageDialog showDialog = new MessageDialog("Viva er beti");
            var result = await showDialog.ShowAsync();

        }
    }
}
