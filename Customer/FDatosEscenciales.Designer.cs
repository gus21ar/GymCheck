namespace Customer
{
	partial class FDatosEscenciales
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
			btnSiguiente = new Button();
			label1 = new Label();
			txtNombre = new TextBox();
			txtApellido = new TextBox();
			label2 = new Label();
			txtDni = new TextBox();
			label3 = new Label();
			btnCancelar = new Button();
			btnAnterior = new Button();
			panel1 = new Panel();
			panel2 = new Panel();
			panel3 = new Panel();
			panel4 = new Panel();
			panel5 = new Panel();
			panel6 = new Panel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			panel5.SuspendLayout();
			panel6.SuspendLayout();
			SuspendLayout();
			// 
			// btnSiguiente
			// 
			btnSiguiente.BackColor = Color.SteelBlue;
			btnSiguiente.Enabled = false;
			btnSiguiente.ForeColor = Color.White;
			btnSiguiente.Location = new Point(397, 10);
			btnSiguiente.Name = "btnSiguiente";
			btnSiguiente.Size = new Size(160, 50);
			btnSiguiente.TabIndex = 0;
			btnSiguiente.Text = "Siguiente";
			btnSiguiente.UseVisualStyleBackColor = false;
			btnSiguiente.Click += btnSiguiente_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(15, 15);
			label1.Name = "label1";
			label1.Size = new Size(133, 38);
			label1.TabIndex = 1;
			label1.Text = "Nombre";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(177, 12);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(398, 44);
			txtNombre.TabIndex = 2;
			txtNombre.TextChanged += txtNombre_TextChanged;
			// 
			// txtApellido
			// 
			txtApellido.Location = new Point(177, 94);
			txtApellido.Name = "txtApellido";
			txtApellido.Size = new Size(398, 44);
			txtApellido.TabIndex = 4;
			txtApellido.TextChanged += txtNombre_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 97);
			label2.Name = "label2";
			label2.Size = new Size(133, 38);
			label2.TabIndex = 3;
			label2.Text = "Apellido";
			// 
			// txtDni
			// 
			txtDni.Location = new Point(177, 170);
			txtDni.Name = "txtDni";
			txtDni.Size = new Size(398, 44);
			txtDni.TabIndex = 6;
			txtDni.TextChanged += txtNombre_TextChanged;
			txtDni.KeyPress += txtDni_KeyPress;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(15, 173);
			label3.Name = "label3";
			label3.Size = new Size(78, 38);
			label3.TabIndex = 5;
			label3.Text = "DNI";
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.Firebrick;
			btnCancelar.ForeColor = Color.White;
			btnCancelar.Location = new Point(202, 10);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(160, 50);
			btnCancelar.TabIndex = 7;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// btnAnterior
			// 
			btnAnterior.BackColor = Color.SteelBlue;
			btnAnterior.ForeColor = Color.White;
			btnAnterior.Location = new Point(3, 10);
			btnAnterior.Name = "btnAnterior";
			btnAnterior.Size = new Size(160, 50);
			btnAnterior.TabIndex = 8;
			btnAnterior.Text = "Anterior";
			btnAnterior.UseVisualStyleBackColor = false;
			btnAnterior.Click += btnAnterior_Click;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlDarkDark;
			panel1.Controls.Add(btnCancelar);
			panel1.Controls.Add(btnSiguiente);
			panel1.Controls.Add(btnAnterior);
			panel1.Location = new Point(15, 220);
			panel1.Name = "panel1";
			panel1.Size = new Size(560, 70);
			panel1.TabIndex = 9;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.Control;
			panel2.Controls.Add(label1);
			panel2.Controls.Add(panel1);
			panel2.Controls.Add(txtNombre);
			panel2.Controls.Add(txtDni);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(txtApellido);
			panel2.Location = new Point(75, 165);
			panel2.Name = "panel2";
			panel2.Size = new Size(600, 300);
			panel2.TabIndex = 10;
			// 
			// panel3
			// 
			panel3.BackColor = SystemColors.ControlDarkDark;
			panel3.Controls.Add(panel4);
			panel3.Location = new Point(10, 10);
			panel3.Name = "panel3";
			panel3.Size = new Size(810, 690);
			panel3.TabIndex = 11;
			// 
			// panel4
			// 
			panel4.BackColor = SystemColors.ActiveCaptionText;
			panel4.Controls.Add(panel5);
			panel4.Location = new Point(10, 10);
			panel4.Name = "panel4";
			panel4.Size = new Size(790, 670);
			panel4.TabIndex = 11;
			// 
			// panel5
			// 
			panel5.BackColor = SystemColors.Menu;
			panel5.Controls.Add(panel6);
			panel5.Location = new Point(10, 10);
			panel5.Name = "panel5";
			panel5.Size = new Size(770, 650);
			panel5.TabIndex = 11;
			// 
			// panel6
			// 
			panel6.BackColor = SystemColors.ControlDark;
			panel6.Controls.Add(panel2);
			panel6.Location = new Point(10, 10);
			panel6.Name = "panel6";
			panel6.Size = new Size(750, 630);
			panel6.TabIndex = 11;
			// 
			// FDatosEscenciales
			// 
			AcceptButton = btnSiguiente;
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			CancelButton = btnCancelar;
			ClientSize = new Size(830, 710);
			Controls.Add(panel3);
			Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(8);
			Name = "FDatosEscenciales";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FDatosEscenciales";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel5.ResumeLayout(false);
			panel6.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Button btnSiguiente;
		private Label label1;
		private TextBox txtNombre;
		private TextBox txtApellido;
		private Label label2;
		private TextBox txtDni;
		private Label label3;
		private Button btnCancelar;
		private Button btnAnterior;
		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private Panel panel4;
		private Panel panel5;
		private Panel panel6;
	}
}