namespace Customer
{
	partial class FAddRedes
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
			label2 = new Label();
			btnAgregar = new Button();
			cmbRedes = new ComboBox();
			txtUsuario = new TextBox();
			lsbRedesUser = new ListBox();
			btnQuitar = new Button();
			btnAnterior = new Button();
			btnCancelar = new Button();
			btnSiguiente = new Button();
			panel1 = new Panel();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 15);
			label1.Name = "label1";
			label1.Size = new Size(164, 38);
			label1.TabIndex = 0;
			label1.Text = "Red Social";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 91);
			label2.Name = "label2";
			label2.Size = new Size(129, 38);
			label2.TabIndex = 1;
			label2.Text = "Usuario";
			// 
			// btnAgregar
			// 
			btnAgregar.Enabled = false;
			btnAgregar.Location = new Point(12, 151);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(802, 79);
			btnAgregar.TabIndex = 2;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// cmbRedes
			// 
			cmbRedes.FormattingEnabled = true;
			cmbRedes.Location = new Point(182, 12);
			cmbRedes.Name = "cmbRedes";
			cmbRedes.Size = new Size(632, 46);
			cmbRedes.TabIndex = 3;
			// 
			// txtUsuario
			// 
			txtUsuario.Location = new Point(182, 85);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.Size = new Size(632, 44);
			txtUsuario.TabIndex = 4;
			txtUsuario.TextChanged += txtUsuario_TextChanged;
			// 
			// lsbRedesUser
			// 
			lsbRedesUser.FormattingEnabled = true;
			lsbRedesUser.ItemHeight = 38;
			lsbRedesUser.Location = new Point(12, 236);
			lsbRedesUser.Name = "lsbRedesUser";
			lsbRedesUser.Size = new Size(636, 384);
			lsbRedesUser.TabIndex = 5;
			// 
			// btnQuitar
			// 
			btnQuitar.Location = new Point(654, 236);
			btnQuitar.Name = "btnQuitar";
			btnQuitar.Size = new Size(160, 61);
			btnQuitar.TabIndex = 6;
			btnQuitar.Text = "Quitar";
			btnQuitar.UseVisualStyleBackColor = true;
			btnQuitar.Click += btnQuitar_Click;
			// 
			// btnAnterior
			// 
			btnAnterior.Location = new Point(3, 10);
			btnAnterior.Name = "btnAnterior";
			btnAnterior.Size = new Size(160, 50);
			btnAnterior.TabIndex = 7;
			btnAnterior.Text = "Anterior";
			btnAnterior.UseVisualStyleBackColor = true;
			btnAnterior.Click += btnAnterior_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(318, 10);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(160, 50);
			btnCancelar.TabIndex = 8;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// btnSiguiente
			// 
			btnSiguiente.Location = new Point(639, 10);
			btnSiguiente.Name = "btnSiguiente";
			btnSiguiente.Size = new Size(160, 50);
			btnSiguiente.TabIndex = 9;
			btnSiguiente.Text = "Siguiente";
			btnSiguiente.UseVisualStyleBackColor = true;
			btnSiguiente.Click += btnSiguiente_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(btnAnterior);
			panel1.Controls.Add(btnSiguiente);
			panel1.Controls.Add(btnCancelar);
			panel1.Location = new Point(12, 626);
			panel1.Name = "panel1";
			panel1.Size = new Size(802, 70);
			panel1.TabIndex = 10;
			// 
			// FAddRedes
			// 
			AcceptButton = btnSiguiente;
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancelar;
			ClientSize = new Size(830, 710);
			Controls.Add(panel1);
			Controls.Add(btnQuitar);
			Controls.Add(lsbRedesUser);
			Controls.Add(txtUsuario);
			Controls.Add(cmbRedes);
			Controls.Add(btnAgregar);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(8);
			Name = "FAddRedes";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FAddRedes";
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Button btnAgregar;
		private ComboBox cmbRedes;
		private TextBox txtUsuario;
		private ListBox lsbRedesUser;
		private Button btnQuitar;
		private Button btnAnterior;
		private Button btnCancelar;
		private Button btnSiguiente;
		private Panel panel1;
	}
}