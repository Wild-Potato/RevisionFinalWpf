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
using System.Windows.Navigation;
using System.Windows.Shapes;
using HomeMadeTextFileReader.Commands;
using HomeMadeTextFileReader.ViewModels;

namespace HomeMadeTextFileReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel currentViewmodel;
        App app;
        public MainWindow(App app)
        {
            InitializeComponent();
            currentViewmodel = new MainViewModel();
            DataContext = currentViewmodel;
            this.app = app;

            currentViewmodel.RestartCommand = new DelegateCommand<string>(Restart);
        }
        private void Restart(string obj)
        {
            var result = MessageBox.Show(Properties.Resources.MessageBox, "Message", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                app.Restart();
            }
        }
    }
}
