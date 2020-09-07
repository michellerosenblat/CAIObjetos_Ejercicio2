using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIObjetos_Ejercicio2
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechanacimiento;
        private int ubicacion;
        List<string> perros = new List<string>();
        int edad;

        internal string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        internal string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        internal int Ubicacion
        {
            get
            {
                return ubicacion;
            }
        }
        internal DateTime FechaNacimiento
        {
            get
            {
                return fechanacimiento;
            }
            set
            {
                fechanacimiento = value;
            }
        }

        public int GetEdad()
        {
            
            return (DateTime.Now.Subtract(fechanacimiento).Days)/365;
        }
        public void Caminar (int distancia)
        {
            ubicacion = ubicacion + distancia;
        }
        public void Adoptar (string nombreperro)
        {
            perros.Add(nombreperro);
        }

        public int CantidadPerros()
        {
            return perros.Count();
        }

        public Persona(string nom, string ape, DateTime fechanac)
        {
            nombre = nom;
            apellido = ape;
            fechanacimiento = fechanac;
            ubicacion = 0;
        }
        public int Felicidad()
        {
            return 100 - GetEdad() + 5 * CantidadPerros();
        }
    }
}
