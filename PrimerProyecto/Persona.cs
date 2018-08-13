using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    class Persona
    {
        public int Edad { get; set; } //Encapsula (primera en mayusculas cuando son variables de encapsulamiento)
        public string Nombre { get; set; }

        public Persona(int edad, string nombre) //constructor llamado igual que la clase
        {
            Edad = edad; // hace referencia al parametro del constructor llamado de la clase (variable global)
            this.Nombre = nombre; //se puede dejar con o sin This
        }

        public Persona() //contructor vacio
        {
            Edad = 0;
            Nombre = "";
        }

        public void cumplirAnio() //no regresa nada
        {
            Edad++;
        }
    }
}
