using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void laskeButton_Click(object sender, RoutedEventArgs e)
        {
            //Muutetaan annetut arvot double-muuttujiksi
            string ikkunaLString = ikkunanLeveys.Text;
            double ikkunaL = double.Parse(ikkunaLString);
            string ikkunaKString = ikkunanKorkeus.Text;
            double ikkunaK = double.Parse(ikkunaKString);
            string karminLString = karminLeveys.Text;
            double karminL = double.Parse(karminLString);

            //Ikkunan pinta-ala
            double ikkunanLaskettuPa = (ikkunaL * ikkunaK) / 10;
            ikkunanPa.Text = ikkunanLaskettuPa.ToString("0") + " cm^2";

            //Lasin pinta-ala
            double lasinLaskettuPa = ((ikkunaL - (karminL * 2)) * (ikkunaK - (karminL * 2))) / 10;
            lasinPa.Text = lasinLaskettuPa.ToString("0") + " cm^2";

            //Karmin piiri
            double karminLaskettuPiiri = ((2 * ikkunaL) + (2 * ikkunaK)) / 10;
            karminPiiri.Text = karminLaskettuPiiri.ToString("0") + " cm";
        }
    }
}
