using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class MainWindowVM : ObservableObject
    {
        public RelayCommand AbrirUC1Command { get; }
        public RelayCommand AbrirUC2Command { get; }
        private readonly NavigationService servicio;
        private UserControl opcion;
        public UserControl Opcion
        {
            get { return opcion; }
            set { SetProperty(ref opcion, value); }
        }

        public MainWindowVM()
        {
            servicio = new NavigationService();
            AbrirUC1Command = new RelayCommand(AbrirUC1);
            AbrirUC2Command = new RelayCommand(AbrirUC2);
        }

        private void AbrirUC2()
        {
            Opcion = servicio.AbrirUC2();
        }

        private void AbrirUC1()
        {
            Opcion = servicio.AbrirUC1();
        }
    }
}
