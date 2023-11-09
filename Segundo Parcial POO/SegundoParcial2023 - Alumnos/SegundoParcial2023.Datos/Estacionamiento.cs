using SegundoParcial2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial2023.Datos
{
    public class Estacionamiento
    {


        private int espacioDisponible;
        private string nombre;
        private static List<Vehiculo> vehiculos;

        static Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacioDisponible)
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static implicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre" + e.nombre);
            sb.AppendLine("Espacios Disponibles" + e.espacioDisponible);
            sb.AppendLine("Nómina de Jugadores");
            foreach (var i in vehiculos)
            {
                sb.AppendLine(i.ImprimirTicket());
            }


            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return vehiculos.Contains(vehiculo);
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (vehiculo != null && !vehiculos.Contains(vehiculo) && !string.IsNullOrEmpty(vehiculo.Patente) && estacionamiento.espacioDisponible > vehiculos.Count)
            {
                vehiculos.Add(vehiculo);
                return estacionamiento;
            }
            else
            {
                throw new InvalidOperationException("No se puede agregar el vehículo al estacionamiento.");
            }
        }
        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (vehiculos.Contains(vehiculo))
            {
                vehiculos.Remove(vehiculo);
                return vehiculo.ImprimirTicket(); // Retorna el ticket de cobro
            }
            else
            {
                return "El vehículo no es parte del estacionamiento";
            }
        }

    }
}
