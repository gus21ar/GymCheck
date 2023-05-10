namespace Customer
{
	partial class FFechas
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
			chbIngreso = new CheckBox();
			dtpNacimiento = new DateTimePicker();
			dtpIngreso = new DateTimePicker();
			label2 = new Label();
			txtComentario = new TextBox();
			btnAgregar = new Button();
			btnAnterior = new Button();
			btnCancelar = new Button();
			panel1 = new Panel();
			panel2 = new Panel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 13);
			label1.Name = "label1";
			label1.Size = new Size(314, 38);
			label1.TabIndex = 0;
			label1.Text = "Fecha de Nacimiento";
			// 
			// chbIngreso
			// 
			chbIngreso.AutoSize = true;
			chbIngreso.Checked = true;
			chbIngreso.CheckState = CheckState.Checked;
			chbIngreso.Location = new Point(16, 127);
			chbIngreso.Name = "chbIngreso";
			chbIngreso.Size = new Size(208, 42);
			chbIngreso.TabIndex = 1;
			chbIngreso.Text = "Ingresa Hoy";
			chbIngreso.UseVisualStyleBackColor = true;
			chbIngreso.CheckedChanged += chbIngreso_CheckedChanged;
			// 
			// dtpNacimiento
			// 
			dtpNacimiento.Format = DateTimePickerFormat.Short;
			dtpNacimiento.Location = new Point(336, 16);
			dtpNacimiento.Name = "dtpNacimiento";
			dtpNacimiento.Size = new Size(271, 44);
			dtpNacimiento.TabIndex = 2;
			dtpNacimiento.Value = new DateTime(1980, 1, 1, 0, 0, 0, 0);
			// 
			// dtpIngreso
			// 
			dtpIngreso.Enabled = false;
			dtpIngreso.Format = DateTimePickerFormat.Short;
			dtpIngreso.Location = new Point(336, 127);
			dtpIngreso.Name = "dtpIngreso";
			dtpIngreso.Size = new Size(271, 44);
			dtpIngreso.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(16, 189);
			label2.Name = "label2";
			label2.Size = new Size(359, 38);
			label2.TabIndex = 4;
			label2.Text = "Datos a tener en cuenta:";
			// 
			// txtComentario
			// 
			txtComentario.Location = new Point(16, 230);
			txtComentario.Multiline = true;
			txtComentario.Name = "txtComentario";
			txtComentario.Size = new Size(594, 190);
			txtComentario.TabIndex = 5;
			// 
			// btnAgregar
			// 
			btnAgregar.BackColor = Color.SteelBlue;
			btnAgregar.ForeColor = Color.White;
			btnAgregar.Location = new Point(431, 10);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(160, 50);
			btnAgregar.TabIndex = 6;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = false;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// btnAnterior
			// 
			btnAnterior.BackColor = Color.SteelBlue;
			btnAnterior.ForeColor = Color.White;
			btnAnterior.Location = new Point(3, 10);
			btnAnterior.Name = "btnAnterior";
			btnAnterior.Size = new Size(160, 50);
			btnAnterior.TabIndex = 7;
			btnAnterior.Text = "Anterior";
			btnAnterior.UseVisualStyleBackColor = false;
			btnAnterior.Click += btnAnterior_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.Firebrick;
			btnCancelar.ForeColor = Color.White;
			btnCancelar.Location = new Point(226, 10);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(160, 50);
			btnCancelar.TabIndex = 8;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlDarkDark;
			panel1.Controls.Add(btnAnterior);
			panel1.Controls.Add(btnAgregar);
			panel1.Controls.Add(btnCancelar);
			panel1.Location = new Point(16, 431);
			panel1.Name = "panel1";
			panel1.Size = new Size(594, 70);
			panel1.TabIndex = 9;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.Control;
			panel2.Controls.Add(label1);
			panel2.Controls.Add(panel1);
			panel2.Controls.Add(chbIngreso);
			panel2.Controls.Add(txtComentario);
			panel2.Controls.Add(dtpNacimiento);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(dtpIngreso);
			panel2.Location = new Point(100, 100);
			panel2.Name = "panel2";
			panel2.Size = new Size(630, 510);
			panel2.TabIndex = 10;
			// 
			// FFechas
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaptionText;
			ClientSize = new Size(830, 710);
			Controls.Add(panel2);
			Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(8);
			Name = "FFechas";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FFechas";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private CheckBox chbIngreso;
		private DateTimePicker dtpNacimiento;
		private DateTimePicker dtpIngreso;
		private Label label2;
		private TextBox txtComentario;
		private Button btnAgregar;
		private Button btnAnterior;
		private Button btnCancelar;
		private Panel panel1;
		private Panel panel2;
	}
}