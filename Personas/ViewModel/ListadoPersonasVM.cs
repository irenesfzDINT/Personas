using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personas.Clases.Mensajes;

namespace Personas.ViewModel
{
    class ListadoPersonasVM : ObservableRecipient
    {
        private readonly PersonaService servicio;
        //Selected item
        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

        private ObservableCollection<Persona> personas;
        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }
        public ListadoPersonasVM()
        {
            servicio = new PersonaService();
            Personas = servicio.ObtenerDatos();
            //Manda la persona seleccionada
            WeakReferenceMessenger.Default.Register<ListadoPersonasVM, PersonaSeleccionadaRequestMessage>
            (this, (r, m) =>
            {
                m.Reply(r.PersonaSeleccionada);
            });

            //se suscribe
            WeakReferenceMessenger.Default.Register<NuevaPersonaModificadaMessage>
            (this, (r, m) =>
            {
                Personas.Add(m.Value);
            });

        }
    }
}
