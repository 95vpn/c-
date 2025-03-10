using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    internal class Alumno
    {
        public string nombre;
        public int edad;
        private double nota;
        public string grado;
    

    public Alumno(string Nombre, int Edad, double argNota, string Grado)
        {
            nombre = Nombre;
            edad = Edad;
            nota = argNota;
            grado = Grado;
        }

        public bool Aprobado()
        {
            if (nota >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Nota
        {
            get { return nota; }
            set { if (value >= 0 && value <= 10)
                {
                    nota = value;
                } 
                else
                {
                    nota = -1.0;
                }
            }

    } 
}
