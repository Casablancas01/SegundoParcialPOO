namespace SegundoParcial2023.Windows
{
    public partial class frmVehiculoAE : Form
	{
		public frmVehiculoAE()
		{
			InitializeComponent();
		}

		private void frmVehiculoAE_Load(object sender, EventArgs e)
		{
			CargarDatosComboVehiculos();
			CargarDatosComboColores();
		}

		private void CargarDatosComboColores()
		{
			List<ConsoleColor> colors = new List<ConsoleColor>();
			for (int i = 0; i < 10; i++)
			{
				colors.Add((ConsoleColor)i);
			}
			cboColores.DataSource = colors;
			cboColores.SelectedIndex = 0;
		}

		private void CargarDatosComboVehiculos()
		{
			//var lista = Enum.GetValues(typeof(TipoVehiculo)).Cast<TipoVehiculo>().ToList();
			//cboVehiculo.DataSource = lista;
			//cboVehiculo.SelectedIndex = 0;
		}


	}
}
