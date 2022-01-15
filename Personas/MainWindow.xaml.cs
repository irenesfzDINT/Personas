
using Personas.ViewModel;
using System.Windows;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM vm;
        public MainWindow()
        {
            vm = new MainWindowVM();
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
