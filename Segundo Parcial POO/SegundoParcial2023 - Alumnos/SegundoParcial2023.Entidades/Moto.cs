using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial2023.Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            valorHora = 30;
        }
        public Moto(string patente,int cilindrada):base(patente)
        {
            this.ruedas = 2;   
            this.cilindrada = cilindrada;
        }
        public Moto(string patente, int cilindrada,short ruedas):this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }
        public Moto(string patente, int cilindrada, short ruedas,int valorHor) : this(patente, cilindrada,ruedas)
        {
            valorHora = valorHor;
        }




        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo de vehículo: " + GetType().Name);
            sb.AppendLine("Cilindrada: " + cilindrada);
            sb.AppendLine("Número de ruedas: " + ruedas);
            sb.AppendLine("Valor por hora: " + valorHora);
            return sb.ToString();
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
            sb.AppendLine("Costo: " + (estadia.Hours*valorHora).ToString());

            return sb.ToString();
        }
    }
}
