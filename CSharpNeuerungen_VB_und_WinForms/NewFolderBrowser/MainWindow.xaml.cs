using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewFolderBrowser
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

        private void SelectFolder(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFolderDialog();

            if (dlg.ShowDialog().Value == true)
            {
                foldersListBox.Items.Add(dlg.FolderName);
            }
        }
    }
}