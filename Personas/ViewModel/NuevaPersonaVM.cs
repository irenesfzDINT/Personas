using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.ViewModel
{
    class NuevaPersonaVM : ObservableObject
    {
        private readonly PersonaService servicio;
        private readonly NavigationService servicioNavegacion;

        private ObservableCollection<string> nacionalidades;
        public ObservableCollection<string> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }
        public RelayCommand AddNacionalidadCommand { get; }

        public NuevaPersonaVM()
        {
            //control E V
            servicioNavegacion = new NavigationService();
            AddNacionalidadCommand = new RelayCommand(Anyade);
            servicio = new PersonaService();
            Nacionalidades = new ObservableCollection<string>();
            ObservableCollection<Persona> personas = servicio.ObtenerDatos();
            for (int i = 0; i < personas.Count; i++)
            {
                Nacionalidades.Add(personas[i].Nacionalidad);
            }
        }

        private void Anyade()
        {
            servicioNavegacion.AbrirDialogoNacionalidad();
        }
    }
}
