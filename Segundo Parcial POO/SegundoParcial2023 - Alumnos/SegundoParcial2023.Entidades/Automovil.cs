using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial2023.Entidades
{
    public  class Automovil:Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;
        static Automovil()
        {
            valorHora = 50;
        }
        public Automovil(string patente,ConsoleColor color):base(patente)
        {
            this.color = color;
        }
        public Automovil(string patente, ConsoleColor color,int valorHor):this(patente,color)
        {
            valorHora = valorHor;
        }

        public override string ImprimirTicket()
        {
            DateTime horaSalida = DateTime.Now;
            TimeSpan estadia = horaSalida.Subtract(ingreso);
            // Para obtener la duración en horas, minutos y segundos
            int horas = estadia.Hours;
            int minutos = estadia.Minutes;
            int segundos = estadia.Seconds;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket()); // Llama al método ImprimirTicket de la clase base (Vehiculo)
            sb.AppendLine("Fecha Egreso: " + horaSalida.Date.ToString());
            sb.AppendLine("Estadia: " + estadia.Hours.ToString());
            sb.AppendLine("Costo: " + (estadia.Hours * valorHora).ToString());

            return sb.ToString();
        }
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo de vehículo: " + GetType().Name);
            sb.AppendLine("Color: " + color);
            sb.AppendLine("Valor por hora: " + valorHora);
            return sb.ToString();
        }
    }
}
