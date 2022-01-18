using Personas.ViewModel;
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

namespace Personas.UserControls
{
    /// <summary>
    /// Lógica de interacción para DatosPersona.xaml
    /// </summary>
    public partial class DatosPersona : UserControl
    {
        DatosPersonaVM vm;
        public DatosPersona()
        {
            vm = new DatosPersonaVM();
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
