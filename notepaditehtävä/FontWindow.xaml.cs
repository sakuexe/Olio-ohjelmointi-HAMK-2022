using System;
using System.Windows;

namespace notepaditehtävä
{
    /// <summary>
    /// Interaction logic for FontWindow.xaml
    /// </summary>
    public partial class FontWindow : Window
    {
        private string? SelectedFont { get; set; }
        public FontWindow()
        {
            InitializeComponent();
            Title = "Font formatting";

            int[] ArrayItems =
            {
                12, 14, 16, 18, 20, 24, 28, 32, 36, 40, 45, 50, 60  
            };

            SampleList.ItemsSource = ArrayItems;
        }

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            // haetaan access pääikkunaan
            MainWindow win = (MainWindow)Application.Current.MainWindow;

            if (SampleList.SelectedValue != null)
            {
                SelectedFont = SampleList.SelectedValue.ToString();
                FontBox.Text = SelectedFont;
                SampleList.UnselectAll();
            }

            try
            {
                win.textBox.FontSize = Convert.ToDouble(FontBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n\n-Give the size in numbers");
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
