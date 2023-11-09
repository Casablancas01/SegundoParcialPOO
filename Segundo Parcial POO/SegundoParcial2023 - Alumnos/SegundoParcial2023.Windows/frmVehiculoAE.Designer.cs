namespace SegundoParcial2023.Windows
{
	partial class frmVehiculoAE
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			label1 = new Label();
			txtPatente = new TextBox();
			label2 = new Label();
			cboVehiculo = new ComboBox();
			btnOK = new Button();
			btnCancelar = new Button();
			errorProvider1 = new ErrorProvider(components);
			label3 = new Label();
			txtModelo = new TextBox();
			label4 = new Label();
			nupCilindrada = new NumericUpDown();
			label5 = new Label();
			cboColores = new ComboBox();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)nupCilindrada).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(43, 15);
			label1.Name = "label1";
			label1.Size = new Size(50, 15);
			label1.TabIndex = 0;
			label1.Text = "Patente:";
			// 
			// txtPatente
			// 
			txtPatente.Location = new Point(139, 12);
			txtPatente.Name = "txtPatente";
			txtPatente.Size = new Size(100, 23);
			txtPatente.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(43, 44);
			label2.Name = "label2";
			label2.Size = new Size(81, 15);
			label2.TabIndex = 0;
			label2.Text = "Tipo Vehículo:";
			// 
			// cboVehiculo
			// 
			cboVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
			cboVehiculo.FormattingEnabled = true;
			cboVehiculo.Location = new Point(140, 44);
			cboVehiculo.Name = "cboVehiculo";
			cboVehiculo.Size = new Size(99, 23);
			cboVehiculo.TabIndex = 2;
			// 
			// btnOK
			// 
			btnOK.Location = new Point(33, 175);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 51);
			btnOK.TabIndex = 3;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(180, 175);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(75, 51);
			btnCancelar.TabIndex = 3;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(43, 76);
			label3.Name = "label3";
			label3.Size = new Size(51, 15);
			label3.TabIndex = 0;
			label3.Text = "Modelo:";
			// 
			// txtModelo
			// 
			txtModelo.Location = new Point(139, 73);
			txtModelo.Name = "txtModelo";
			txtModelo.Size = new Size(100, 23);
			txtModelo.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(43, 104);
			label4.Name = "label4";
			label4.Size = new Size(67, 15);
			label4.TabIndex = 0;
			label4.Text = "Ciilindrada:";
			// 
			// nupCilindrada
			// 
			nupCilindrada.Location = new Point(139, 102);
			nupCilindrada.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			nupCilindrada.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nupCilindrada.Name = "nupCilindrada";
			nupCilindrada.Size = new Size(100, 23);
			nupCilindrada.TabIndex = 4;
			nupCilindrada.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(43, 131);
			label5.Name = "label5";
			label5.Size = new Size(39, 15);
			label5.TabIndex = 0;
			label5.Text = "Color:";
			// 
			// cboColores
			// 
			cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
			cboColores.FormattingEnabled = true;
			cboColores.Location = new Point(140, 131);
			cboColores.Name = "cboColores";
			cboColores.Size = new Size(99, 23);
			cboColores.TabIndex = 2;
			// 
			// frmVehiculoAE
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(283, 240);
			Controls.Add(nupCilindrada);
			Controls.Add(btnCancelar);
			Controls.Add(btnOK);
			Controls.Add(cboColores);
			Controls.Add(label5);
			Controls.Add(cboVehiculo);
			Controls.Add(label2);
			Controls.Add(txtModelo);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(txtPatente);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "frmVehiculoAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmVehiculoAE";
			Load += frmVehiculoAE_Load;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)nupCilindrada).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtPatente;
		private Label label2;
		private ComboBox cboVehiculo;
		private Button btnOK;
		private Button btnCancelar;
		private ErrorProvider errorProvider1;
		private NumericUpDown nupCilindrada;
		private TextBox txtModelo;
		private Label label4;
		private Label label3;
		private ComboBox cboColores;
		private Label label5;
	}
}