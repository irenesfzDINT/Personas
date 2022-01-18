using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personas.Clases.Mensajes;

namespace Personas.ViewModel
{
    class DatosPersonaVM : ObservableRecipient
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }
        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public DatosPersonaVM()
        {
            Persona p = WeakReferenceMessenger.Default.Send<PersonaSeleccionadaRequestMessage>();
            Nombre = p.Nombre;
            Edad = p.Edad;
            Nacionalidad = p.Nacionalidad;
        }
    }
}
