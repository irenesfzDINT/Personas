using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personas.Clases.Mensajes;

namespace Personas.ViewModel
{
    class DialogoNacionalidadVM : ObservableRecipient
    {
        private string textoNacionalidad;

        public string TextoNacionalidad
        {
            get { return textoNacionalidad; }
            set { SetProperty(ref textoNacionalidad, value); }
        }
        public RelayCommand NuevaNacionalidadCommand { get; }

        public DialogoNacionalidadVM()
        {
            NuevaNacionalidadCommand = new RelayCommand(NuevaNacionalidad);
        }

        private void NuevaNacionalidad()
        {
            //envia datos
            WeakReferenceMessenger.Default.Send(new NacionalidadModificadaMessage(TextoNacionalidad));
        }
    }
}
