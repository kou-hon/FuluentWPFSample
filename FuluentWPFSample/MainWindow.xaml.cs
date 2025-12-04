using System.Windows;
using System.Windows.Controls;

namespace FuluentWPFSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var theme = ((ComboBox)sender).SelectedItem switch
            {
                ComboBoxItem { Content: "Light" } => ThemeMode.Light,
                ComboBoxItem { Content: "Dark" } => ThemeMode.Dark,
                ComboBoxItem { Content: "System" } => ThemeMode.System,
                _ => ThemeMode.None,
            };
            Application.Current.ThemeMode = theme;
            ThemeMode = theme;
        }
    }
}