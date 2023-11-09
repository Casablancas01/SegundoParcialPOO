using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial2023.Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            valorHora = 70;
        }
        public PickUp(string patente,string modelo):base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(string patente, string modelo, int valorHor) : this(patente,modelo)
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
            sb.AppendLine("Modelo: " + modelo);
            sb.AppendLine("Valor por hora: " + valorHora);
            return sb.ToString();
        }
    }
}
