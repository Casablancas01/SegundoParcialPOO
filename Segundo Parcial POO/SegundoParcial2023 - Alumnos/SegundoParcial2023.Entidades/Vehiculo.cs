using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial2023.Entidades
{
    public abstract class Vehiculo
    {
        public DateTime ingreso;// En el UML no aparece el candado
        private string patente;
        public string Patente
        {
            get { return patente; }
            set
            {
                if (ValidarPatente(value))
                {
                    patente = value;
                }
                else
                {
                    throw new ArgumentException("Formato de patente no válido");
                }
            }
        }

        public Vehiculo(string patente)
        {
            if (ValidarPatente(patente))
            {
                this.patente = patente;
                ingreso = DateTime.Now.AddHours(-3);
            }
            else
            {
                throw new ArgumentException("Formato de patente no válido");
            }
        }
        public abstract string ConsultarDatos();
        public override string ToString()
        {
            return string.Format($"{patente}");
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Patente: "+patente);
            sb.AppendLine("Fecha ingreso: "+ingreso.Date.ToString());
            sb.AppendLine("Hora Ingreso: "+ingreso.Hour.ToString());
            return sb.ToString();

        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Vehiculo otroVehiculo = (Vehiculo)obj;
            return patente == otroVehiculo.patente;
        }

        public override int GetHashCode()
        {
            return patente.GetHashCode();
        }

        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            if (ReferenceEquals(vehiculo1, vehiculo2))
            {
                return true;
            }

            if (vehiculo1 is null || vehiculo2 is null)
            {
                return false;
            }

            return vehiculo1.Equals(vehiculo2);
        }

        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }


        //PATENTE
        public static bool ValidarPatente(string patente)
        {
            if (string.IsNullOrEmpty(patente) || (patente.Length != 6 && patente.Length != 9))
            {
                return false;
            }

            if (patente.Length == 6)
            {
                return ValidarPatenteVieja(patente);
            }
            else if (patente.Length == 9)
            {
                return ValidarPatenteNueva(patente);
            }

            return false;
        }

        private static bool ValidarPatenteVieja(string patente)
        {
            string parteAlfa = patente.Substring(0, 3);
            string parteNum = patente.Substring(3);

            return ValidarParteAlfa(parteAlfa) && ValidarParteNum(parteNum);
        }

        private static bool ValidarPatenteNueva(string patente)
        {
            string parteAlfa1 = patente.Substring(0, 2);
            string parteNum = patente.Substring(2, 3);
            string parteAlfa2 = patente.Substring(5);

            return ValidarParteAlfa(parteAlfa1) && ValidarParteNum(parteNum) && ValidarParteAlfa(parteAlfa2);
        }

        private static bool ValidarParteAlfa(string parteAlfa)
        {
            foreach (char c in parteAlfa)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidarParteNum(string parteNum)
        {
            foreach (char c in parteNum)
            {
                if (!char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
