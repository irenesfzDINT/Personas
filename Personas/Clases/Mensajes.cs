using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Clases
{
    class Mensajes
    {
        public class NacionalidadRequestMessage : RequestMessage<string> { }
        public class NacionalidadModificadaMessage : ValueChangedMessage<string>
        {
            public NacionalidadModificadaMessage(string nacionalidad) : base(nacionalidad) { }
        }
        public class NuevaPersonaModificadaMessage : ValueChangedMessage<Persona>
        {
            public NuevaPersonaModificadaMessage(Persona persona) : base(persona) { }
        }
        public class PersonaSeleccionadaRequestMessage : RequestMessage<Persona> { }
    }
}
