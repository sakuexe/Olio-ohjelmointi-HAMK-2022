using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace notepaditehtävä
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            // myWindow.ShowDialog()
        }

        private void ActivityButton_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(Ellipse1, 0);
        }

        bool Piirtää = false;

        private void PiirtoCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Liikutetaan palloa klikillä
            var sijainti = e.GetPosition(this);
            Canvas.SetLeft(Ellipse1, sijainti.X - Ellipse1.Width/2);
            Canvas.SetTop(Ellipse1, sijainti.Y - Ellipse1.Height/2);

            Piirtää = !Piirtää; // toimii togglena
        }

        private void PiirtoCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            //var sijainti = e.GetPosition(this);
            //Canvas.SetLeft(Ellipse1, sijainti.X - Ellipse1.Width / 2);
            //Canvas.SetTop(Ellipse1, sijainti.Y - Ellipse1.Height / 2);

            if (Piirtää)
            {
                // asetetaan elipsit
                Ellipse ellipse = new Ellipse();
                ellipse.Width = ellipse.Height = 20;
                ellipse.Fill = Brushes.Gray;

                // Oma canvas kontrolli (vrt Canvas = Canvas luokka)
                PiirtoCanvas.Children.Add(ellipse);
                Canvas.SetLeft(ellipse, e.GetPosition(PiirtoCanvas).X);
                Canvas.SetTop(ellipse, e.GetPosition(PiirtoCanvas).Y);

                Title = PiirtoCanvas.Children.Count + "Kpl";
            }
            
        }
    }
}
