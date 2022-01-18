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
        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public RelayCommand AddNacionalidadCommand { get; }

        public NuevaPersonaVM()
        {
            //control E V
            servicioNavegacion = new NavigationService();
            AddNacionalidadCommand = new RelayCommand(NuevaNacionalidad);
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

        private void NuevaNacionalidad()
        {
            servicioNavegacion.AbrirDialogoNacionalidad();
        }
    }
}
