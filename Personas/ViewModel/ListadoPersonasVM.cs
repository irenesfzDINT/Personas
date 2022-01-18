﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
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
           /* WeakReferenceMessenger.Default.Register<NuevaPersonaModificadaMessage>(this, (r, m) =>
            {
                Personas.Add(m.Value);
            });*/
        }
    }
}
