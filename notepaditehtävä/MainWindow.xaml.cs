using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace notepaditehtävä
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Microsoft.Win32.OpenFileDialog OpenDialog { get; set; } = new();
        private Microsoft.Win32.SaveFileDialog SaveDialog { get; set; } = new();
        private System.Windows.Controls.PrintDialog PrintDialog { get; set; } = new();
        public MainWindow()
        {
            InitializeComponent();
            // TODO:
            // - File/Open- lukee tiedoston tekstit ja näyttää ne boxissa ✓
            // - File/Save toimii ✓
            // - File/Print toimii ✓
            // - Edit copy paste toimii ✓
            // - Format/Font mainwindowin fontin muuttaminen uudessa ikkunassa
            // - Kyseisessä ikkunassa toimivat OK ja Cancel toiminnot

            Title = "Notepad";
        }

        public void ChangeFont(int scale)
        {
            textBox.FontSize = scale;
        }

        private void exitmenu_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {

            SetDialogWindow("Open");

            // (https://docs.microsoft.com/en-us/dotnet/desktop/wpf/windows/how-to-open-common-system-dialog-box?view=netdesktop-6.0#open-file-dialog-box)

            // Näytä ikkuna ja tallenna bool tieto siitä että avautuiko
            bool? result = OpenDialog.ShowDialog();

            // Jos ikkuna avautui niin jatka
            if (result == true)
            {
                // Haetaan dokumentin directory ja tallennetaan siihen
                string filename = OpenDialog.FileName;
                textBox.Text = File.ReadAllText(filename);

                // Ilmoitetaan että Avaaminen onnistui
                Title = "Avaaminen onnistui";
                Thread.Sleep(2000);
                Title = "Notepad";
            }

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            SetDialogWindow("Save");

            bool? result = SaveDialog.ShowDialog();

            if (result == true)
            {
                // Sama homma kuin aikaisemmin mutta save toiminnolla
                string filename = SaveDialog.FileName;
                File.WriteAllText(filename, textBox.Text);

                // Ilmoitetaan että tallennus onnistui
                Title = "Tallennus onnistui";
                Thread.Sleep(2000);
                Title = "Notepad";
            }
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            // Set upataan sivujen määärä jotka otetaan printtiin
            PrintDialog.PageRangeSelection = System.Windows.Controls.PageRangeSelection.AllPages;
            PrintDialog.UserPageRangeEnabled = true;

            bool? result = PrintDialog.ShowDialog();

            if (result == true)
            {
                // Ilmoitetaan että printtaus onnistui
                Title = "Printtaus onnistui";
                Thread.Sleep(3000);
                Title = "Notepad";
            }
        }

        private void SetDialogWindow(string choice)
        {
            if (choice == "Open")
            {
                // voit lukea ikkunan tietoja
                OpenDialog.FileName = "Document"; // Default file name
                OpenDialog.DefaultExt = ".txt"; // Default file extension
                OpenDialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            }
            else
            {
                SaveDialog.FileName = "Document"; // Default file name
                SaveDialog.DefaultExt = ".txt"; // Default file extension
                SaveDialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            }
        }

        private void TokaSivu_Click(object sender, RoutedEventArgs e)
        {
            Window1 newwindow = new Window1();
            newwindow.Show();
        }

        private void FontPage_Click(object sender, RoutedEventArgs e)
        {
            FontWindow fontWindow = new FontWindow();
            fontWindow.Show();
        }
    }
}
