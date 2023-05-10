namespace Miselaneas
{
	partial class FPagosRegistro
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
			label1 = new Label();
			txtDni = new TextBox();
			label2 = new Label();
			txtMonto = new TextBox();
			label3 = new Label();
			cmbMedios = new ComboBox();
			lblCliente = new Label();
			btnBuscar = new Button();
			panPago = new Panel();
			btnPagar = new Button();
			btnCancelar = new Button();
			panGeneral = new Panel();
			panPago.SuspendLayout();
			panGeneral.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 19);
			label1.Name = "label1";
			label1.Size = new Size(69, 38);
			label1.TabIndex = 0;
			label1.Text = "Dni";
			// 
			// txtDni
			// 
			txtDni.Location = new Point(120, 13);
			txtDni.Name = "txtDni";
			txtDni.Size = new Size(348, 44);
			txtDni.TabIndex = 1;
			txtDni.TextChanged += txtDni_TextChanged;
			txtDni.KeyPress += txtDni_KeyPress;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 33);
			label2.Name = "label2";
			label2.Size = new Size(111, 38);
			label2.TabIndex = 2;
			label2.Text = "Monto";
			// 
			// txtMonto
			// 
			txtMonto.Location = new Point(111, 33);
			txtMonto.Name = "txtMonto";
			txtMonto.Size = new Size(344, 44);
			txtMonto.TabIndex = 3;
			txtMonto.TextChanged += txtMonto_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 86);
			label3.Name = "label3";
			label3.Size = new Size(106, 38);
			label3.TabIndex = 4;
			label3.Text = "Medio";
			// 
			// cmbMedios
			// 
			cmbMedios.FormattingEnabled = true;
			cmbMedios.Location = new Point(111, 83);
			cmbMedios.Name = "cmbMedios";
			cmbMedios.Size = new Size(344, 46);
			cmbMedios.TabIndex = 5;
			// 
			// lblCliente
			// 
			lblCliente.AutoSize = true;
			lblCliente.Location = new Point(22, 16);
			lblCliente.Name = "lblCliente";
			lblCliente.Size = new Size(116, 38);
			lblCliente.TabIndex = 6;
			lblCliente.Text = "Cliente";
			// 
			// btnBuscar
			// 
			btnBuscar.Enabled = false;
			btnBuscar.Location = new Point(480, 6);
			btnBuscar.Name = "btnBuscar";
			btnBuscar.Size = new Size(130, 51);
			btnBuscar.TabIndex = 7;
			btnBuscar.Text = "buscar";
			btnBuscar.UseVisualStyleBackColor = true;
			btnBuscar.Click += btnBuscar_Click;
			// 
			// panPago
			// 
			panPago.Controls.Add(btnPagar);
			panPago.Controls.Add(txtMonto);
			panPago.Controls.Add(label2);
			panPago.Controls.Add(label3);
			panPago.Controls.Add(cmbMedios);
			panPago.Location = new Point(26, 73);
			panPago.Name = "panPago";
			panPago.Size = new Size(568, 232);
			panPago.TabIndex = 8;
			// 
			// btnPagar
			// 
			btnPagar.Enabled = false;
			btnPagar.Location = new Point(104, 150);
			btnPagar.Name = "btnPagar";
			btnPagar.Size = new Size(348, 67);
			btnPagar.TabIndex = 6;
			btnPagar.Text = "Pagar";
			btnPagar.UseVisualStyleBackColor = true;
			btnPagar.Click += btnPagar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(127, 488);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(341, 61);
			btnCancelar.TabIndex = 9;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// panGeneral
			// 
			panGeneral.Controls.Add(lblCliente);
			panGeneral.Controls.Add(panPago);
			panGeneral.Enabled = false;
			panGeneral.Location = new Point(16, 82);
			panGeneral.Name = "panGeneral";
			panGeneral.Size = new Size(613, 371);
			panGeneral.TabIndex = 10;
			// 
			// FPagosRegistro
			// 
			AcceptButton = btnPagar;
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancelar;
			ClientSize = new Size(659, 561);
			Controls.Add(panGeneral);
			Controls.Add(btnCancelar);
			Controls.Add(btnBuscar);
			Controls.Add(txtDni);
			Controls.Add(label1);
			Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(7, 8, 7, 8);
			Name = "FPagosRegistro";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Pagos";
			panPago.ResumeLayout(false);
			panPago.PerformLayout();
			panGeneral.ResumeLayout(false);
			panGeneral.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtDni;
		private Label label2;
		private TextBox txtMonto;
		private Label label3;
		private ComboBox cmbMedios;
		private Label lblCliente;
		private Button btnBuscar;
		private Panel panPago;
		private Button btnPagar;
		private Button btnCancelar;
		private Panel panGeneral;
	}
}