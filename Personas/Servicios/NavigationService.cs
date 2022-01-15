using Personas.UserControls;
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
        public UserControl AbrirUC1() 
        {
            return new NuevaPersona();
        }
        public UserControl AbrirUC2()
        {
            return new ListadoPersonas();
        }
    }
}
