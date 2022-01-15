using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Servicios
{
    class PersonaService : ObservableObject
    {
        public ObservableCollection<Persona> ObtenerDatos() {
            ObservableCollection<Persona> resultado = new ObservableCollection<Persona>();
            resultado.Add(new Persona("Pietro",30,"Italiana"));
            resultado.Add(new Persona("Julia",30,"Española"));
            resultado.Add(new Persona("Sophie",30,"Francesa"));
            return resultado;
        }
    }
}
