namespace Customer
{
	partial class FTomarFoto
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
			pbCamara = new PictureBox();
			pbFoto = new PictureBox();
			btnCancelar = new Button();
			btnCapture = new Button();
			btnIniciarCamara = new Button();
			cmbCamaras = new ComboBox();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)pbCamara).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// btnSiguiente
			// 
			btnSiguiente.BackColor = Color.SteelBlue;
			btnSiguiente.ForeColor = Color.White;
			btnSiguiente.Location = new Point(638, 10);
			btnSiguiente.Margin = new Padding(8, 7, 8, 7);
			btnSiguiente.Name = "btnSiguiente";
			btnSiguiente.Size = new Size(160, 50);
			btnSiguiente.TabIndex = 0;
			btnSiguiente.Text = "Siguiente";
			btnSiguiente.UseVisualStyleBackColor = false;
			btnSiguiente.Click += btnSiguiente_Click;
			// 
			// pbCamara
			// 
			pbCamara.Location = new Point(6, 6);
			pbCamara.Margin = new Padding(2);
			pbCamara.Name = "pbCamara";
			pbCamara.Size = new Size(400, 400);
			pbCamara.SizeMode = PictureBoxSizeMode.Zoom;
			pbCamara.TabIndex = 1;
			pbCamara.TabStop = false;
			// 
			// pbFoto
			// 
			pbFoto.Location = new Point(418, 6);
			pbFoto.Margin = new Padding(2);
			pbFoto.Name = "pbFoto";
			pbFoto.Size = new Size(400, 400);
			pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
			pbFoto.TabIndex = 2;
			pbFoto.TabStop = false;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.Firebrick;
			btnCancelar.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			btnCancelar.ForeColor = Color.White;
			btnCancelar.Location = new Point(8, 10);
			btnCancelar.Margin = new Padding(8, 7, 8, 7);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(160, 50);
			btnCancelar.TabIndex = 3;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// btnCapture
			// 
			btnCapture.Location = new Point(650, 504);
			btnCapture.Margin = new Padding(2);
			btnCapture.Name = "btnCapture";
			btnCapture.Size = new Size(160, 50);
			btnCapture.TabIndex = 6;
			btnCapture.Text = "Cápturar";
			btnCapture.UseVisualStyleBackColor = true;
			btnCapture.Click += btnCapture_Click;
			// 
			// btnIniciarCamara
			// 
			btnIniciarCamara.Location = new Point(6, 504);
			btnIniciarCamara.Margin = new Padding(2);
			btnIniciarCamara.Name = "btnIniciarCamara";
			btnIniciarCamara.Size = new Size(240, 50);
			btnIniciarCamara.TabIndex = 7;
			btnIniciarCamara.Text = "Iniciar Cámara";
			btnIniciarCamara.UseVisualStyleBackColor = true;
			btnIniciarCamara.Click += btnIniciarCamara_Click;
			// 
			// cmbCamaras
			// 
			cmbCamaras.FormattingEnabled = true;
			cmbCamaras.Location = new Point(6, 431);
			cmbCamaras.Margin = new Padding(2);
			cmbCamaras.Name = "cmbCamaras";
			cmbCamaras.Size = new Size(493, 46);
			cmbCamaras.TabIndex = 8;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlDarkDark;
			panel1.Controls.Add(btnCancelar);
			panel1.Controls.Add(btnSiguiente);
			panel1.Location = new Point(12, 628);
			panel1.Name = "panel1";
			panel1.Size = new Size(806, 70);
			panel1.TabIndex = 9;
			// 
			// FTomarFoto
			// 
			AcceptButton = btnSiguiente;
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancelar;
			ClientSize = new Size(830, 710);
			Controls.Add(panel1);
			Controls.Add(cmbCamaras);
			Controls.Add(btnIniciarCamara);
			Controls.Add(btnCapture);
			Controls.Add(pbFoto);
			Controls.Add(pbCamara);
			Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(8, 7, 8, 7);
			Name = "FTomarFoto";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Agregar Cliente";
			Activated += FTomarFoto_Activated;
			FormClosed += FTomarFoto_FormClosed;
			Load += FTomarFoto_Load;
			((System.ComponentModel.ISupportInitialize)pbCamara).EndInit();
			((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Button btnSiguiente;
		private PictureBox pbCamara;
		private PictureBox pbFoto;
		private Button btnCancelar;
		private Button btnCapture;
		private Button btnIniciarCamara;
		private ComboBox cmbCamaras;
		private Panel panel1;
	}
}