namespace GymCheck.Mensajes
{
	partial class FMensaje
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
			pbIcono = new PictureBox();
			btnAceptar = new Button();
			lblTitulo = new Label();
			lblMensaje = new Label();
			btnNo = new Button();
			btnSI = new Button();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// pbIcono
			// 
			pbIcono.Location = new Point(15, 101);
			pbIcono.Name = "pbIcono";
			pbIcono.Size = new Size(100, 101);
			pbIcono.SizeMode = PictureBoxSizeMode.Zoom;
			pbIcono.TabIndex = 0;
			pbIcono.TabStop = false;
			// 
			// btnAceptar
			// 
			btnAceptar.BackColor = Color.CornflowerBlue;
			btnAceptar.ForeColor = SystemColors.Window;
			btnAceptar.Location = new Point(213, 14);
			btnAceptar.Name = "btnAceptar";
			btnAceptar.Size = new Size(160, 50);
			btnAceptar.TabIndex = 1;
			btnAceptar.Text = "Aceptar";
			btnAceptar.UseVisualStyleBackColor = false;
			btnAceptar.Visible = false;
			btnAceptar.Click += btnAceptar_Click;
			// 
			// lblTitulo
			// 
			lblTitulo.AutoSize = true;
			lblTitulo.ForeColor = SystemColors.Window;
			lblTitulo.Location = new Point(15, 18);
			lblTitulo.MaximumSize = new Size(700, 50);
			lblTitulo.MinimumSize = new Size(200, 50);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(200, 50);
			lblTitulo.TabIndex = 2;
			lblTitulo.Text = "Titulo";
			// 
			// lblMensaje
			// 
			lblMensaje.AutoEllipsis = true;
			lblMensaje.AutoSize = true;
			lblMensaje.ForeColor = SystemColors.Window;
			lblMensaje.Location = new Point(121, 101);
			lblMensaje.MaximumSize = new Size(650, 180);
			lblMensaje.MinimumSize = new Size(200, 100);
			lblMensaje.Name = "lblMensaje";
			lblMensaje.Size = new Size(200, 100);
			lblMensaje.TabIndex = 3;
			lblMensaje.Text = "Mensaje";
			// 
			// btnNo
			// 
			btnNo.BackColor = Color.Firebrick;
			btnNo.ForeColor = Color.White;
			btnNo.Location = new Point(10, 14);
			btnNo.Name = "btnNo";
			btnNo.Size = new Size(160, 50);
			btnNo.TabIndex = 5;
			btnNo.Text = "No";
			btnNo.UseVisualStyleBackColor = false;
			btnNo.Visible = false;
			btnNo.Click += btnNo_Click;
			// 
			// btnSI
			// 
			btnSI.BackColor = Color.ForestGreen;
			btnSI.ForeColor = SystemColors.Window;
			btnSI.Location = new Point(420, 14);
			btnSI.Name = "btnSI";
			btnSI.Size = new Size(160, 50);
			btnSI.TabIndex = 6;
			btnSI.Text = "Si";
			btnSI.UseVisualStyleBackColor = false;
			btnSI.Visible = false;
			btnSI.Click += btnSI_Click;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.WindowFrame;
			panel1.Controls.Add(btnSI);
			panel1.Controls.Add(btnAceptar);
			panel1.Controls.Add(btnNo);
			panel1.Location = new Point(121, 274);
			panel1.Name = "panel1";
			panel1.Size = new Size(593, 75);
			panel1.TabIndex = 7;
			// 
			// FMensaje
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Firebrick;
			ClientSize = new Size(807, 361);
			Controls.Add(panel1);
			Controls.Add(lblMensaje);
			Controls.Add(lblTitulo);
			Controls.Add(pbIcono);
			Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(8);
			Name = "FMensaje";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FMensaje";
			((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pbIcono;
		private Button btnAceptar;
		private Label lblTitulo;
		private Label lblMensaje;
		private Button btnNo;
		private Button btnSI;
		private Panel panel1;
	}
}