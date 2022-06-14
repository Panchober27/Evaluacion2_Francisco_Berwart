using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2_Francisco_Berwart {

    class Articulo {
        // propiedades
        // Identificador
        //     Descripción
        // - Valor Aproximado
        // - preferencias de trueque(por cual producto lo cambiaría) >= 3
        // - Fechas de ingreso del articulo/objeto.

        // declarar propiedades
        public string Identificador { get; set; }
        public string Descripcion { get; set; }
        public double ValorAproximado { get; set; }

        public List<string> Preferencias { get; set; }

        // OJO con el tema de las preferencias.

        public DateTime FechaIngreso { get; set; }







    }
}
