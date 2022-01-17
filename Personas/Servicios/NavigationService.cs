using Personas.UserControls;
using Personas.Ventanas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.Servicios
{
    class NavigationService
    {
        ListadoPersonas lista = new ListadoPersonas();
        public void AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad dialogo = new DialogoNacionalidad();
            dialogo.ShowDialog();
        }
        public UserControl AbrirUC1()
        {
            return new NuevaPersona();
        }
        public UserControl AbrirUC2()
        {
            return lista;
        }
    }
}
