using System.Windows;
using WPF_MVVM_BibliJeux.ViewModels;

namespace WPF_MVVM_BibliJeux
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }
    }
}
