using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2_Francisco_Berwart {
    class Persona {
        // propiedades
        // rut
        // nomrbres
        // apellidos
        // telefono
        // email

        // declarar propiedades
        public string Rut { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        // constructor
        public Persona(string rut, string nombres,string apellidos, string telefono, string email) {
            // inicializar propiedades
            Rut = rut;
            Nombres = nombres;
            Apellidos = apellidos;
            Telefono = telefono;
            Email = email;
        }


        // metodo
        // mostrar datos
        public void MostrarDatos() {
            Console.WriteLine("Rut: " + Rut);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Telefono: " + Telefono);
            Console.WriteLine("Email: " + Email);
        }



    }
}
