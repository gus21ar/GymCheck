namespace Miselaneas
{
	partial class FConfig
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
			tabControl1 = new TabControl();
			tPCadena = new TabPage();
			btnGuardar = new Button();
			txtPass = new TextBox();
			label3 = new Label();
			txtUsuario = new TextBox();
			label4 = new Label();
			txtBase = new TextBox();
			label2 = new Label();
			txtServidor = new TextBox();
			label1 = new Label();
			tPRutas = new TabPage();
			label5 = new Label();
			lblFolderPdf = new Label();
			label6 = new Label();
			btnPdfFolder = new Button();
			lblFolderBuckUp = new Label();
			lblFolderDefault = new Label();
			label101 = new Label();
			btnBuckUpFolder = new Button();
			label100 = new Label();
			btnGymFolder = new Button();
			tPHoras = new TabPage();
			btnConfigurar = new Button();
			nudSegundo = new NumericUpDown();
			label8 = new Label();
			nudPrimero = new NumericUpDown();
			label7 = new Label();
			fBDGymFolder = new FolderBrowserDialog();
			fBDBuckUp = new FolderBrowserDialog();
			fBDPdfFolder = new FolderBrowserDialog();
			tabControl1.SuspendLayout();
			tPCadena.SuspendLayout();
			tPRutas.SuspendLayout();
			tPHoras.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudSegundo).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudPrimero).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tPCadena);
			tabControl1.Controls.Add(tPRutas);
			tabControl1.Controls.Add(tPHoras);
			tabControl1.Location = new Point(12, 12);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(713, 437);
			tabControl1.TabIndex = 0;
			// 
			// tPCadena
			// 
			tPCadena.Controls.Add(btnGuardar);
			tPCadena.Controls.Add(txtPass);
			tPCadena.Controls.Add(label3);
			tPCadena.Controls.Add(txtUsuario);
			tPCadena.Controls.Add(label4);
			tPCadena.Controls.Add(txtBase);
			tPCadena.Controls.Add(label2);
			tPCadena.Controls.Add(txtServidor);
			tPCadena.Controls.Add(label1);
			tPCadena.Location = new Point(4, 47);
			tPCadena.Name = "tPCadena";
			tPCadena.Padding = new Padding(3);
			tPCadena.Size = new Size(705, 386);
			tPCadena.TabIndex = 0;
			tPCadena.Text = "Cadena";
			tPCadena.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			btnGuardar.Location = new Point(240, 232);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(440, 148);
			btnGuardar.TabIndex = 8;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = true;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// txtPass
			// 
			txtPass.Location = new Point(158, 182);
			txtPass.Name = "txtPass";
			txtPass.Size = new Size(522, 44);
			txtPass.TabIndex = 7;
			txtPass.TextAlign = HorizontalAlignment.Center;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(9, 185);
			label3.Name = "label3";
			label3.Size = new Size(91, 38);
			label3.TabIndex = 6;
			label3.Text = "Pass:";
			// 
			// txtUsuario
			// 
			txtUsuario.Location = new Point(158, 124);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.Size = new Size(522, 44);
			txtUsuario.TabIndex = 5;
			txtUsuario.TextAlign = HorizontalAlignment.Center;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 127);
			label4.Name = "label4";
			label4.Size = new Size(139, 38);
			label4.TabIndex = 4;
			label4.Text = "Usuario:";
			// 
			// txtBase
			// 
			txtBase.Location = new Point(158, 64);
			txtBase.Name = "txtBase";
			txtBase.Size = new Size(522, 44);
			txtBase.TabIndex = 3;
			txtBase.TextAlign = HorizontalAlignment.Center;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 64);
			label2.Name = "label2";
			label2.Size = new Size(93, 38);
			label2.TabIndex = 2;
			label2.Text = "Base:";
			// 
			// txtServidor
			// 
			txtServidor.Location = new Point(158, 6);
			txtServidor.Name = "txtServidor";
			txtServidor.Size = new Size(522, 44);
			txtServidor.TabIndex = 1;
			txtServidor.TextAlign = HorizontalAlignment.Center;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 9);
			label1.Name = "label1";
			label1.Size = new Size(146, 38);
			label1.TabIndex = 0;
			label1.Text = "Servidor:";
			// 
			// tPRutas
			// 
			tPRutas.Controls.Add(label5);
			tPRutas.Controls.Add(lblFolderPdf);
			tPRutas.Controls.Add(label6);
			tPRutas.Controls.Add(btnPdfFolder);
			tPRutas.Controls.Add(lblFolderBuckUp);
			tPRutas.Controls.Add(lblFolderDefault);
			tPRutas.Controls.Add(label101);
			tPRutas.Controls.Add(btnBuckUpFolder);
			tPRutas.Controls.Add(label100);
			tPRutas.Controls.Add(btnGymFolder);
			tPRutas.Location = new Point(4, 47);
			tPRutas.Name = "tPRutas";
			tPRutas.Padding = new Padding(3);
			tPRutas.Size = new Size(705, 386);
			tPRutas.TabIndex = 1;
			tPRutas.Text = "Rutas";
			tPRutas.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = Color.IndianRed;
			label5.Location = new Point(6, 358);
			label5.Name = "label5";
			label5.Size = new Size(686, 25);
			label5.TabIndex = 9;
			label5.Text = "Las carpetas se guardan automáticamente al ser seleccionadas";
			// 
			// lblFolderPdf
			// 
			lblFolderPdf.AutoSize = true;
			lblFolderPdf.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblFolderPdf.Location = new Point(324, 307);
			lblFolderPdf.Name = "lblFolderPdf";
			lblFolderPdf.Size = new Size(50, 18);
			lblFolderPdf.TabIndex = 8;
			lblFolderPdf.Text = "label5";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(6, 256);
			label6.Name = "label6";
			label6.Size = new Size(318, 38);
			label6.TabIndex = 7;
			label6.Text = "Carpeta archivos Pdf ";
			// 
			// btnPdfFolder
			// 
			btnPdfFolder.Location = new Point(324, 247);
			btnPdfFolder.Name = "btnPdfFolder";
			btnPdfFolder.Size = new Size(245, 57);
			btnPdfFolder.TabIndex = 6;
			btnPdfFolder.Text = "Pdf Folder";
			btnPdfFolder.UseVisualStyleBackColor = true;
			btnPdfFolder.Click += btnPdfFolder_Click;
			// 
			// lblFolderBuckUp
			// 
			lblFolderBuckUp.AutoSize = true;
			lblFolderBuckUp.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblFolderBuckUp.Location = new Point(324, 201);
			lblFolderBuckUp.Name = "lblFolderBuckUp";
			lblFolderBuckUp.Size = new Size(50, 18);
			lblFolderBuckUp.TabIndex = 5;
			lblFolderBuckUp.Text = "label5";
			// 
			// lblFolderDefault
			// 
			lblFolderDefault.AutoSize = true;
			lblFolderDefault.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblFolderDefault.Location = new Point(324, 96);
			lblFolderDefault.Name = "lblFolderDefault";
			lblFolderDefault.Size = new Size(50, 18);
			lblFolderDefault.TabIndex = 4;
			lblFolderDefault.Text = "label5";
			// 
			// label101
			// 
			label101.AutoSize = true;
			label101.Location = new Point(52, 150);
			label101.Name = "label101";
			label101.Size = new Size(249, 38);
			label101.TabIndex = 3;
			label101.Text = "Carpeta BuckUp";
			// 
			// btnBuckUpFolder
			// 
			btnBuckUpFolder.Location = new Point(324, 141);
			btnBuckUpFolder.Name = "btnBuckUpFolder";
			btnBuckUpFolder.Size = new Size(245, 57);
			btnBuckUpFolder.TabIndex = 2;
			btnBuckUpFolder.Text = "BuckUp Folder";
			btnBuckUpFolder.UseVisualStyleBackColor = true;
			btnBuckUpFolder.Click += btnBuckUpFolder_Click;
			// 
			// label100
			// 
			label100.AutoSize = true;
			label100.Location = new Point(6, 45);
			label100.Name = "label100";
			label100.Size = new Size(300, 38);
			label100.TabIndex = 1;
			label100.Text = "Carpeta de Archivos";
			// 
			// btnGymFolder
			// 
			btnGymFolder.Location = new Point(324, 36);
			btnGymFolder.Name = "btnGymFolder";
			btnGymFolder.Size = new Size(245, 57);
			btnGymFolder.TabIndex = 0;
			btnGymFolder.Text = "Gym Folder";
			btnGymFolder.UseVisualStyleBackColor = true;
			btnGymFolder.Click += btnGymFolder_Click;
			// 
			// tPHoras
			// 
			tPHoras.Controls.Add(btnConfigurar);
			tPHoras.Controls.Add(nudSegundo);
			tPHoras.Controls.Add(label8);
			tPHoras.Controls.Add(nudPrimero);
			tPHoras.Controls.Add(label7);
			tPHoras.Location = new Point(4, 47);
			tPHoras.Name = "tPHoras";
			tPHoras.Padding = new Padding(3);
			tPHoras.Size = new Size(705, 386);
			tPHoras.TabIndex = 2;
			tPHoras.Text = "Horas";
			tPHoras.UseVisualStyleBackColor = true;
			tPHoras.Enter += tPHoras_Enter;
			// 
			// btnConfigurar
			// 
			btnConfigurar.Location = new Point(179, 207);
			btnConfigurar.Name = "btnConfigurar";
			btnConfigurar.Size = new Size(188, 64);
			btnConfigurar.TabIndex = 4;
			btnConfigurar.Text = "Configurar";
			btnConfigurar.UseVisualStyleBackColor = true;
			btnConfigurar.Click += btnConfigurar_Click;
			// 
			// nudSegundo
			// 
			nudSegundo.Location = new Point(333, 120);
			nudSegundo.Name = "nudSegundo";
			nudSegundo.Size = new Size(120, 44);
			nudSegundo.TabIndex = 3;
			nudSegundo.TextAlign = HorizontalAlignment.Center;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 122);
			label8.Name = "label8";
			label8.Size = new Size(325, 38);
			label8.TabIndex = 2;
			label8.Text = "Hora segundo reporte";
			// 
			// nudPrimero
			// 
			nudPrimero.Location = new Point(333, 47);
			nudPrimero.Name = "nudPrimero";
			nudPrimero.Size = new Size(120, 44);
			nudPrimero.TabIndex = 1;
			nudPrimero.TextAlign = HorizontalAlignment.Center;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 49);
			label7.Name = "label7";
			label7.Size = new Size(303, 38);
			label7.TabIndex = 0;
			label7.Text = "Hora primer reporte";
			// 
			// FConfig
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(761, 461);
			Controls.Add(tabControl1);
			Name = "FConfig";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FConfig";
			tabControl1.ResumeLayout(false);
			tPCadena.ResumeLayout(false);
			tPCadena.PerformLayout();
			tPRutas.ResumeLayout(false);
			tPRutas.PerformLayout();
			tPHoras.ResumeLayout(false);
			tPHoras.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudSegundo).EndInit();
			((System.ComponentModel.ISupportInitialize)nudPrimero).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tPCadena;
		private Button btnGuardar;
		private TextBox txtPass;
		private Label label3;
		private TextBox txtUsuario;
		private Label label4;
		private TextBox txtBase;
		private Label label2;
		private TextBox txtServidor;
		private Label label1;
		private TabPage tPRutas;
		private Label label101;
		private Button btnBuckUpFolder;
		private Label label100;
		private Button btnGymFolder;
		private FolderBrowserDialog fBDGymFolder;
		private FolderBrowserDialog fBDBuckUp;
		private Label lblFolderBuckUp;
		private Label lblFolderDefault;
		private Label lblFolderPdf;
		private Label label6;
		private Button btnPdfFolder;
		private Label label5;
		private FolderBrowserDialog fBDPdfFolder;
		private TabPage tPHoras;
		private NumericUpDown nudSegundo;
		private Label label8;
		private NumericUpDown nudPrimero;
		private Label label7;
		private Button btnConfigurar;
	}
}