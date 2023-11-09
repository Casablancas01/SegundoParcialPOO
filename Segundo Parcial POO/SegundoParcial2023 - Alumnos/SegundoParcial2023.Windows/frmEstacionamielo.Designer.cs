namespace SegundoParcial2023.Windows
{
	partial class frmEstacionamielo
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			splitContainer1 = new SplitContainer();
			dgvDatos = new DataGridView();
			colPatente = new DataGridViewTextBoxColumn();
			colTipo = new DataGridViewTextBoxColumn();
			colEntrada = new DataGridViewTextBoxColumn();
			btnGuardarJson = new Button();
			btnGuardarXml = new Button();
			btnGuardarTxt = new Button();
			btnRetirar = new Button();
			btnIngresar = new Button();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(dgvDatos);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(btnGuardarJson);
			splitContainer1.Panel2.Controls.Add(btnGuardarXml);
			splitContainer1.Panel2.Controls.Add(btnGuardarTxt);
			splitContainer1.Panel2.Controls.Add(btnRetirar);
			splitContainer1.Panel2.Controls.Add(btnIngresar);
			splitContainer1.Size = new Size(800, 450);
			splitContainer1.SplitterDistance = 673;
			splitContainer1.TabIndex = 0;
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colPatente, colTipo, colEntrada });
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.Location = new Point(0, 0);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowTemplate.Height = 25;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(673, 450);
			dgvDatos.TabIndex = 0;
			// 
			// colPatente
			// 
			colPatente.HeaderText = "Patente";
			colPatente.Name = "colPatente";
			colPatente.ReadOnly = true;
			// 
			// colTipo
			// 
			colTipo.HeaderText = "Tipo";
			colTipo.Name = "colTipo";
			colTipo.ReadOnly = true;
			// 
			// colEntrada
			// 
			colEntrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colEntrada.HeaderText = "Entrada";
			colEntrada.Name = "colEntrada";
			colEntrada.ReadOnly = true;
			// 
			// btnGuardarJson
			// 
			btnGuardarJson.Location = new Point(21, 366);
			btnGuardarJson.Name = "btnGuardarJson";
			btnGuardarJson.Size = new Size(75, 54);
			btnGuardarJson.TabIndex = 0;
			btnGuardarJson.Text = "Guardar JSON";
			btnGuardarJson.UseVisualStyleBackColor = true;
			// 
			// btnGuardarXml
			// 
			btnGuardarXml.Location = new Point(21, 306);
			btnGuardarXml.Name = "btnGuardarXml";
			btnGuardarXml.Size = new Size(75, 54);
			btnGuardarXml.TabIndex = 0;
			btnGuardarXml.Text = "Guardar XML";
			btnGuardarXml.UseVisualStyleBackColor = true;
			// 
			// btnGuardarTxt
			// 
			btnGuardarTxt.Location = new Point(21, 246);
			btnGuardarTxt.Name = "btnGuardarTxt";
			btnGuardarTxt.Size = new Size(75, 54);
			btnGuardarTxt.TabIndex = 0;
			btnGuardarTxt.Text = "Guardar TXT";
			btnGuardarTxt.UseVisualStyleBackColor = true;
			// 
			// btnRetirar
			// 
			btnRetirar.Location = new Point(21, 97);
			btnRetirar.Name = "btnRetirar";
			btnRetirar.Size = new Size(75, 54);
			btnRetirar.TabIndex = 0;
			btnRetirar.Text = "Retirar";
			btnRetirar.UseVisualStyleBackColor = true;
			// 
			// btnIngresar
			// 
			btnIngresar.Location = new Point(21, 24);
			btnIngresar.Name = "btnIngresar";
			btnIngresar.Size = new Size(75, 54);
			btnIngresar.TabIndex = 0;
			btnIngresar.Text = "Ingresar";
			btnIngresar.UseVisualStyleBackColor = true;
			// 
			// frmEstacionamielo
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(splitContainer1);
			Name = "frmEstacionamielo";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Estacionamiento";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private DataGridView dgvDatos;
		private Button btnIngresar;
		private Button btnRetirar;
		private DataGridViewTextBoxColumn colPatente;
		private DataGridViewTextBoxColumn colTipo;
		private DataGridViewTextBoxColumn colEntrada;
		private Button btnGuardarJson;
		private Button btnGuardarXml;
		private Button btnGuardarTxt;
	}
}