namespace GymCheck
{
	partial class Form1
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
			components = new System.ComponentModel.Container();
			menuPrincipal = new MenuStrip();
			clientesToolStripMenuItem = new ToolStripMenuItem();
			agregarToolStripMenuItem = new ToolStripMenuItem();
			modificarToolStripMenuItem = new ToolStripMenuItem();
			verToolStripMenuItem = new ToolStripMenuItem();
			pagosToolStripMenuItem = new ToolStripMenuItem();
			nuevosToolStripMenuItem = new ToolStripMenuItem();
			asistenciasToolStripMenuItem = new ToolStripMenuItem();
			semaforoToolStripMenuItem = new ToolStripMenuItem();
			reportesToolStripMenuItem = new ToolStripMenuItem();
			generarToolStripMenuItem = new ToolStripMenuItem();
			configuracionesToolStripMenuItem = new ToolStripMenuItem();
			agregarRedesToolStripMenuItem = new ToolStripMenuItem();
			agregarMediosDePagoToolStripMenuItem = new ToolStripMenuItem();
			aplicacionToolStripMenuItem = new ToolStripMenuItem();
			ayudaToolStripMenuItem = new ToolStripMenuItem();
			acercaDeToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem1 = new ToolStripMenuItem();
			BtnClientes = new Button();
			btnPagos = new Button();
			btnAsistencia = new Button();
			panVerCliente = new Panel();
			btnListo = new Button();
			lblResumen = new Label();
			lblNombre = new Label();
			pbClienteAcces = new PictureBox();
			btnReportes = new Button();
			tmrReportes = new System.Windows.Forms.Timer(components);
			menuPrincipal.SuspendLayout();
			panVerCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbClienteAcces).BeginInit();
			SuspendLayout();
			// 
			// menuPrincipal
			// 
			menuPrincipal.AllowItemReorder = true;
			menuPrincipal.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			menuPrincipal.ImeMode = ImeMode.On;
			menuPrincipal.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, pagosToolStripMenuItem, asistenciasToolStripMenuItem, reportesToolStripMenuItem, configuracionesToolStripMenuItem, ayudaToolStripMenuItem, toolStripMenuItem1 });
			menuPrincipal.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
			menuPrincipal.Location = new Point(0, 0);
			menuPrincipal.Name = "menuPrincipal";
			menuPrincipal.Padding = new Padding(16, 5, 0, 5);
			menuPrincipal.Size = new Size(984, 39);
			menuPrincipal.TabIndex = 0;
			menuPrincipal.Visible = false;
			// 
			// clientesToolStripMenuItem
			// 
			clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarToolStripMenuItem, verToolStripMenuItem });
			clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			clientesToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.C;
			clientesToolStripMenuItem.Size = new Size(97, 29);
			clientesToolStripMenuItem.Text = "Clientes";
			// 
			// agregarToolStripMenuItem
			// 
			agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
			agregarToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.A;
			agregarToolStripMenuItem.Size = new Size(244, 30);
			agregarToolStripMenuItem.Text = "Agregar";
			agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
			// 
			// modificarToolStripMenuItem
			// 
			modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
			modificarToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.U;
			modificarToolStripMenuItem.Size = new Size(244, 30);
			modificarToolStripMenuItem.Text = "Modificar";
			modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
			// 
			// verToolStripMenuItem
			// 
			verToolStripMenuItem.Name = "verToolStripMenuItem";
			verToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.V;
			verToolStripMenuItem.Size = new Size(244, 30);
			verToolStripMenuItem.Text = "Ver";
			// 
			// pagosToolStripMenuItem
			// 
			pagosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevosToolStripMenuItem });
			pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
			pagosToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.P;
			pagosToolStripMenuItem.Size = new Size(79, 29);
			pagosToolStripMenuItem.Text = "Pagos";
			// 
			// nuevosToolStripMenuItem
			// 
			nuevosToolStripMenuItem.Name = "nuevosToolStripMenuItem";
			nuevosToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.N;
			nuevosToolStripMenuItem.Size = new Size(221, 30);
			nuevosToolStripMenuItem.Text = "Nuevos";
			nuevosToolStripMenuItem.Click += nuevosToolStripMenuItem_Click;
			// 
			// asistenciasToolStripMenuItem
			// 
			asistenciasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { semaforoToolStripMenuItem });
			asistenciasToolStripMenuItem.Name = "asistenciasToolStripMenuItem";
			asistenciasToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.T;
			asistenciasToolStripMenuItem.Size = new Size(127, 29);
			asistenciasToolStripMenuItem.Text = "Asistencias";
			// 
			// semaforoToolStripMenuItem
			// 
			semaforoToolStripMenuItem.Name = "semaforoToolStripMenuItem";
			semaforoToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
			semaforoToolStripMenuItem.Size = new Size(239, 30);
			semaforoToolStripMenuItem.Text = "Semaforo";
			semaforoToolStripMenuItem.Click += semaforoToolStripMenuItem_Click;
			// 
			// reportesToolStripMenuItem
			// 
			reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarToolStripMenuItem });
			reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
			reportesToolStripMenuItem.Size = new Size(107, 29);
			reportesToolStripMenuItem.Text = "Reportes";
			// 
			// generarToolStripMenuItem
			// 
			generarToolStripMenuItem.Name = "generarToolStripMenuItem";
			generarToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.R;
			generarToolStripMenuItem.Size = new Size(228, 30);
			generarToolStripMenuItem.Text = "Generar";
			generarToolStripMenuItem.Click += generarToolStripMenuItem_Click;
			// 
			// configuracionesToolStripMenuItem
			// 
			configuracionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarRedesToolStripMenuItem, agregarMediosDePagoToolStripMenuItem, aplicacionToolStripMenuItem });
			configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
			configuracionesToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F;
			configuracionesToolStripMenuItem.Size = new Size(174, 29);
			configuracionesToolStripMenuItem.Text = "Configuraciones";
			// 
			// agregarRedesToolStripMenuItem
			// 
			agregarRedesToolStripMenuItem.Name = "agregarRedesToolStripMenuItem";
			agregarRedesToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D;
			agregarRedesToolStripMenuItem.Size = new Size(377, 30);
			agregarRedesToolStripMenuItem.Text = "Agregar Redes";
			agregarRedesToolStripMenuItem.Click += agregarRedesToolStripMenuItem_Click;
			// 
			// agregarMediosDePagoToolStripMenuItem
			// 
			agregarMediosDePagoToolStripMenuItem.Name = "agregarMediosDePagoToolStripMenuItem";
			agregarMediosDePagoToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.G;
			agregarMediosDePagoToolStripMenuItem.Size = new Size(377, 30);
			agregarMediosDePagoToolStripMenuItem.Text = "Agregar Medios de Pago";
			agregarMediosDePagoToolStripMenuItem.Click += agregarMediosDePagoToolStripMenuItem_Click;
			// 
			// aplicacionToolStripMenuItem
			// 
			aplicacionToolStripMenuItem.Name = "aplicacionToolStripMenuItem";
			aplicacionToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.L;
			aplicacionToolStripMenuItem.Size = new Size(377, 30);
			aplicacionToolStripMenuItem.Text = "Aplicacion";
			aplicacionToolStripMenuItem.Click += aplicacionToolStripMenuItem_Click;
			// 
			// ayudaToolStripMenuItem
			// 
			ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
			ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			ayudaToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Y;
			ayudaToolStripMenuItem.Size = new Size(83, 29);
			ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// acercaDeToolStripMenuItem
			// 
			acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			acercaDeToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.B;
			acercaDeToolStripMenuItem.Size = new Size(265, 30);
			acercaDeToolStripMenuItem.Text = "Acerca de ...";
			acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.M;
			toolStripMenuItem1.Size = new Size(12, 29);
			toolStripMenuItem1.Click += toolStripMenuItem1_Click;
			// 
			// BtnClientes
			// 
			BtnClientes.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			BtnClientes.Location = new Point(17, 68);
			BtnClientes.Margin = new Padding(8);
			BtnClientes.Name = "BtnClientes";
			BtnClientes.Size = new Size(450, 380);
			BtnClientes.TabIndex = 1;
			BtnClientes.Text = "Cliente Nuevo";
			BtnClientes.UseVisualStyleBackColor = true;
			BtnClientes.Click += agregarToolStripMenuItem_Click;
			// 
			// btnPagos
			// 
			btnPagos.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			btnPagos.Location = new Point(17, 464);
			btnPagos.Margin = new Padding(8);
			btnPagos.Name = "btnPagos";
			btnPagos.Size = new Size(450, 180);
			btnPagos.TabIndex = 2;
			btnPagos.Text = "Pagos";
			btnPagos.UseVisualStyleBackColor = true;
			btnPagos.Click += nuevosToolStripMenuItem_Click;
			// 
			// btnAsistencia
			// 
			btnAsistencia.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			btnAsistencia.Location = new Point(517, 68);
			btnAsistencia.Margin = new Padding(8);
			btnAsistencia.Name = "btnAsistencia";
			btnAsistencia.Size = new Size(450, 380);
			btnAsistencia.TabIndex = 3;
			btnAsistencia.Text = "Asistencia";
			btnAsistencia.UseVisualStyleBackColor = true;
			btnAsistencia.Click += semaforoToolStripMenuItem_Click;
			// 
			// panVerCliente
			// 
			panVerCliente.Controls.Add(btnListo);
			panVerCliente.Controls.Add(lblResumen);
			panVerCliente.Controls.Add(lblNombre);
			panVerCliente.Controls.Add(pbClienteAcces);
			panVerCliente.ForeColor = Color.White;
			panVerCliente.Location = new Point(517, 464);
			panVerCliente.Margin = new Padding(8);
			panVerCliente.Name = "panVerCliente";
			panVerCliente.Size = new Size(450, 380);
			panVerCliente.TabIndex = 4;
			panVerCliente.Visible = false;
			// 
			// btnListo
			// 
			btnListo.BackColor = Color.SteelBlue;
			btnListo.Location = new Point(287, 54);
			btnListo.Name = "btnListo";
			btnListo.Size = new Size(160, 50);
			btnListo.TabIndex = 6;
			btnListo.Text = "LISTO";
			btnListo.UseVisualStyleBackColor = false;
			btnListo.Click += btnListo_Click;
			// 
			// lblResumen
			// 
			lblResumen.AutoSize = true;
			lblResumen.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			lblResumen.Location = new Point(8, 262);
			lblResumen.Margin = new Padding(8, 0, 8, 0);
			lblResumen.Name = "lblResumen";
			lblResumen.Size = new Size(98, 38);
			lblResumen.TabIndex = 5;
			lblResumen.Text = "label1";
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			lblNombre.Location = new Point(8, 8);
			lblNombre.Margin = new Padding(8, 0, 8, 0);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(98, 38);
			lblNombre.TabIndex = 1;
			lblNombre.Text = "label1";
			// 
			// pbClienteAcces
			// 
			pbClienteAcces.Location = new Point(8, 54);
			pbClienteAcces.Margin = new Padding(8);
			pbClienteAcces.Name = "pbClienteAcces";
			pbClienteAcces.Size = new Size(200, 200);
			pbClienteAcces.SizeMode = PictureBoxSizeMode.Zoom;
			pbClienteAcces.TabIndex = 0;
			pbClienteAcces.TabStop = false;
			// 
			// btnReportes
			// 
			btnReportes.Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			btnReportes.Location = new Point(17, 664);
			btnReportes.Margin = new Padding(8);
			btnReportes.Name = "btnReportes";
			btnReportes.Size = new Size(450, 180);
			btnReportes.TabIndex = 5;
			btnReportes.Text = "Reportes";
			btnReportes.UseVisualStyleBackColor = true;
			btnReportes.Click += btnReportes_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(984, 861);
			Controls.Add(btnReportes);
			Controls.Add(panVerCliente);
			Controls.Add(btnAsistencia);
			Controls.Add(btnPagos);
			Controls.Add(BtnClientes);
			Controls.Add(menuPrincipal);
			MainMenuStrip = menuPrincipal;
			Margin = new Padding(8);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "GymCheck";
			menuPrincipal.ResumeLayout(false);
			menuPrincipal.PerformLayout();
			panVerCliente.ResumeLayout(false);
			panVerCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbClienteAcces).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuPrincipal;
		private ToolStripMenuItem clientesToolStripMenuItem;
		private ToolStripMenuItem agregarToolStripMenuItem;
		private ToolStripMenuItem modificarToolStripMenuItem;
		private ToolStripMenuItem verToolStripMenuItem;
		private ToolStripMenuItem pagosToolStripMenuItem;
		private ToolStripMenuItem nuevosToolStripMenuItem;
		private ToolStripMenuItem asistenciasToolStripMenuItem;
		private ToolStripMenuItem reportesToolStripMenuItem;
		private ToolStripMenuItem ayudaToolStripMenuItem;
		private ToolStripMenuItem acercaDeToolStripMenuItem;
		private Button BtnClientes;
		private Button btnPagos;
		private Button btnAsistencia;
		private ToolStripMenuItem configuracionesToolStripMenuItem;
		private ToolStripMenuItem agregarRedesToolStripMenuItem;
		private ToolStripMenuItem agregarMediosDePagoToolStripMenuItem;
		private ToolStripMenuItem aplicacionToolStripMenuItem;
		private Panel panVerCliente;
		private Label lblResumen;
		private Label lblNombre;
		private PictureBox pbClienteAcces;
		private ToolStripMenuItem semaforoToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItem1;
		private Button btnListo;
		private Button btnReportes;
		private ToolStripMenuItem generarToolStripMenuItem;
		private System.Windows.Forms.Timer tmrReportes;
	}
}