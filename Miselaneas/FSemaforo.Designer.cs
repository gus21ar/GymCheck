namespace Miselaneas
{
	partial class FSemaforo
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
			btnIngresar = new Button();
			pnlVerde = new Panel();
			lblVerde = new Label();
			pnlAmarillo = new Panel();
			lblAmarillo = new Label();
			pnlRojo = new Panel();
			lblRojo = new Label();
			pnlVerde.SuspendLayout();
			pnlAmarillo.SuspendLayout();
			pnlRojo.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(191, 90);
			label1.Name = "label1";
			label1.Size = new Size(388, 38);
			label1.TabIndex = 0;
			label1.Text = "Bienvenido Ingrese su Dni";
			// 
			// txtDni
			// 
			txtDni.Location = new Point(83, 158);
			txtDni.Name = "txtDni";
			txtDni.Size = new Size(305, 44);
			txtDni.TabIndex = 1;
			txtDni.TextChanged += txtDni_TextChanged;
			txtDni.Enter += txtDni_Enter;
			txtDni.KeyPress += txtDni_KeyPress;
			// 
			// btnIngresar
			// 
			btnIngresar.Enabled = false;
			btnIngresar.Location = new Point(420, 151);
			btnIngresar.Name = "btnIngresar";
			btnIngresar.Size = new Size(269, 51);
			btnIngresar.TabIndex = 2;
			btnIngresar.Text = "Ingresar";
			btnIngresar.UseVisualStyleBackColor = true;
			btnIngresar.Click += btnIngresar_Click;
			// 
			// pnlVerde
			// 
			pnlVerde.Controls.Add(lblVerde);
			pnlVerde.Location = new Point(83, 219);
			pnlVerde.Name = "pnlVerde";
			pnlVerde.Size = new Size(606, 100);
			pnlVerde.TabIndex = 3;
			// 
			// lblVerde
			// 
			lblVerde.AutoSize = true;
			lblVerde.Location = new Point(32, 28);
			lblVerde.Name = "lblVerde";
			lblVerde.Size = new Size(99, 38);
			lblVerde.TabIndex = 0;
			lblVerde.Text = "Verde";
			lblVerde.Visible = false;
			// 
			// pnlAmarillo
			// 
			pnlAmarillo.Controls.Add(lblAmarillo);
			pnlAmarillo.Location = new Point(83, 325);
			pnlAmarillo.Name = "pnlAmarillo";
			pnlAmarillo.Size = new Size(606, 100);
			pnlAmarillo.TabIndex = 4;
			// 
			// lblAmarillo
			// 
			lblAmarillo.AutoSize = true;
			lblAmarillo.Location = new Point(32, 26);
			lblAmarillo.Name = "lblAmarillo";
			lblAmarillo.Size = new Size(139, 38);
			lblAmarillo.TabIndex = 1;
			lblAmarillo.Text = "Amarillo";
			lblAmarillo.Visible = false;
			// 
			// pnlRojo
			// 
			pnlRojo.Controls.Add(lblRojo);
			pnlRojo.Location = new Point(83, 431);
			pnlRojo.Name = "pnlRojo";
			pnlRojo.Size = new Size(606, 100);
			pnlRojo.TabIndex = 4;
			// 
			// lblRojo
			// 
			lblRojo.AutoSize = true;
			lblRojo.Location = new Point(32, 32);
			lblRojo.Name = "lblRojo";
			lblRojo.Size = new Size(82, 38);
			lblRojo.TabIndex = 2;
			lblRojo.Text = "Rojo";
			lblRojo.Visible = false;
			// 
			// FSemaforo
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(814, 671);
			Controls.Add(pnlRojo);
			Controls.Add(pnlAmarillo);
			Controls.Add(pnlVerde);
			Controls.Add(btnIngresar);
			Controls.Add(txtDni);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Margin = new Padding(8);
			Name = "FSemaforo";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Bienvenidos";
			FormClosed += FSemaforo_FormClosed;
			pnlVerde.ResumeLayout(false);
			pnlVerde.PerformLayout();
			pnlAmarillo.ResumeLayout(false);
			pnlAmarillo.PerformLayout();
			pnlRojo.ResumeLayout(false);
			pnlRojo.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtDni;
		private Button btnIngresar;
		private Panel pnlVerde;
		private Label lblVerde;
		private Panel pnlAmarillo;
		private Label lblAmarillo;
		private Panel pnlRojo;
		private Label lblRojo;
	}
}