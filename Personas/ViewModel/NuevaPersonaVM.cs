using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
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
    class NuevaPersonaVM : ObservableRecipient
    {
        private readonly PersonaService servicio;
        private readonly NavigationService servicioNavegacion;

        private ObservableCollection<string> nacionalidades;
        public ObservableCollection<string> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }

        private Persona nuevaPersonaObj;

        public Persona NuevaPersonaObj
        {
            get { return nuevaPersonaObj; }
            set { SetProperty(ref nuevaPersonaObj, value); }
        }


        public RelayCommand AddNacionalidadCommand { get; }
        public RelayCommand AddPersona { get; }

        public NuevaPersonaVM()
        {
            NuevaPersonaObj = new Persona();
            //control E V
            servicioNavegacion = new NavigationService();
            AddNacionalidadCommand = new RelayCommand(NuevaNacionalidad);
            AddPersona = new RelayCommand(NuevaPersona);
            servicio = new PersonaService();
            Nacionalidades = new ObservableCollection<string>();
            ObservableCollection<Persona> personas = servicio.ObtenerDatos();
            //suscriptor
            WeakReferenceMessenger.Default.Register<NacionalidadModificadaMessage>
            (this, (r, m) =>
            {
                Nacionalidades.Add(m.Value);
            });

            for (int i = 0; i < personas.Count; i++)
            {
                Nacionalidades.Add(personas[i].Nacionalidad);
            }
        }

        private void NuevaPersona()
        {
            WeakReferenceMessenger.Default.Send(
                new NuevaPersonaModificadaMessage(NuevaPersonaObj));
        }

        private void NuevaNacionalidad()
        {
            servicioNavegacion.AbrirDialogoNacionalidad();
        }
    }
}
