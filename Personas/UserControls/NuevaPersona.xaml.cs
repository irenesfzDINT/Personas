using Personas.ViewModel;
using System;
using System.Windows.Controls;

namespace Personas.UserControls
{
    /// <summary>
    /// Lógica de interacción para NuevaPersona.xaml
    /// </summary>
    public partial class NuevaPersona : UserControl
    {
        private NuevaPersonaVM vm;
        public NuevaPersona()
        {
            vm = new NuevaPersonaVM();
            InitializeComponent();
            this.DataContext = vm;
        }
    }
}
