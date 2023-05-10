namespace Miselaneas
{
	partial class FReportes
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
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			dtpDesde = new DateTimePicker();
			btnGenerar = new Button();
			rbtAsistencias = new RadioButton();
			rbtPagos = new RadioButton();
			dgvVisor = new DataGridView();
			pnlBotonera = new Panel();
			btnSalir = new Button();
			btnGuardar = new Button();
			label1 = new Label();
			label2 = new Label();
			dtpHasta = new DateTimePicker();
			pnlFecha = new Panel();
			chbHoy = new CheckBox();
			((System.ComponentModel.ISupportInitialize)dgvVisor).BeginInit();
			pnlBotonera.SuspendLayout();
			pnlFecha.SuspendLayout();
			SuspendLayout();
			// 
			// dtpDesde
			// 
			dtpDesde.Format = DateTimePickerFormat.Short;
			dtpDesde.Location = new Point(124, 20);
			dtpDesde.Name = "dtpDesde";
			dtpDesde.Size = new Size(257, 44);
			dtpDesde.TabIndex = 1;
			// 
			// btnGenerar
			// 
			btnGenerar.Location = new Point(607, 80);
			btnGenerar.Name = "btnGenerar";
			btnGenerar.Size = new Size(262, 93);
			btnGenerar.TabIndex = 2;
			btnGenerar.Text = "Generar";
			btnGenerar.UseVisualStyleBackColor = true;
			btnGenerar.Click += btnGenerar_Click;
			// 
			// rbtAsistencias
			// 
			rbtAsistencias.AutoSize = true;
			rbtAsistencias.Checked = true;
			rbtAsistencias.Location = new Point(12, 12);
			rbtAsistencias.Name = "rbtAsistencias";
			rbtAsistencias.Size = new Size(192, 42);
			rbtAsistencias.TabIndex = 3;
			rbtAsistencias.TabStop = true;
			rbtAsistencias.Text = "Asistencias";
			rbtAsistencias.UseVisualStyleBackColor = true;
			// 
			// rbtPagos
			// 
			rbtPagos.AutoSize = true;
			rbtPagos.Location = new Point(210, 12);
			rbtPagos.Name = "rbtPagos";
			rbtPagos.Size = new Size(118, 42);
			rbtPagos.TabIndex = 4;
			rbtPagos.Text = "Pagos";
			rbtPagos.UseVisualStyleBackColor = true;
			// 
			// dgvVisor
			// 
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = Color.Black;
			dataGridViewCellStyle3.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = Color.White;
			dgvVisor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			dgvVisor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvVisor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvVisor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = SystemColors.Window;
			dataGridViewCellStyle4.Font = new Font("Georgia", 16F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
			dgvVisor.DefaultCellStyle = dataGridViewCellStyle4;
			dgvVisor.Location = new Point(12, 197);
			dgvVisor.Name = "dgvVisor";
			dgvVisor.RowTemplate.Height = 25;
			dgvVisor.Size = new Size(860, 502);
			dgvVisor.TabIndex = 5;
			// 
			// pnlBotonera
			// 
			pnlBotonera.Controls.Add(btnSalir);
			pnlBotonera.Controls.Add(btnGuardar);
			pnlBotonera.Location = new Point(12, 705);
			pnlBotonera.Name = "pnlBotonera";
			pnlBotonera.Size = new Size(860, 70);
			pnlBotonera.TabIndex = 6;
			// 
			// btnSalir
			// 
			btnSalir.Location = new Point(3, 10);
			btnSalir.Name = "btnSalir";
			btnSalir.Size = new Size(160, 50);
			btnSalir.TabIndex = 1;
			btnSalir.Text = "Salir";
			btnSalir.UseVisualStyleBackColor = true;
			btnSalir.Click += btnSalir_Click;
			// 
			// btnGuardar
			// 
			btnGuardar.Location = new Point(697, 10);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(160, 50);
			btnGuardar.TabIndex = 0;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = true;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(5, 25);
			label1.Name = "label1";
			label1.Size = new Size(103, 38);
			label1.TabIndex = 7;
			label1.Text = "Desde";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(5, 75);
			label2.Name = "label2";
			label2.Size = new Size(100, 38);
			label2.TabIndex = 9;
			label2.Text = "Hasta";
			// 
			// dtpHasta
			// 
			dtpHasta.Format = DateTimePickerFormat.Short;
			dtpHasta.Location = new Point(124, 70);
			dtpHasta.Name = "dtpHasta";
			dtpHasta.Size = new Size(257, 44);
			dtpHasta.TabIndex = 8;
			// 
			// pnlFecha
			// 
			pnlFecha.Controls.Add(dtpDesde);
			pnlFecha.Controls.Add(label2);
			pnlFecha.Controls.Add(label1);
			pnlFecha.Controls.Add(dtpHasta);
			pnlFecha.Enabled = false;
			pnlFecha.Location = new Point(203, 60);
			pnlFecha.Name = "pnlFecha";
			pnlFecha.Size = new Size(398, 131);
			pnlFecha.TabIndex = 10;
			// 
			// chbHoy
			// 
			chbHoy.AutoSize = true;
			chbHoy.Checked = true;
			chbHoy.CheckState = CheckState.Checked;
			chbHoy.Location = new Point(35, 106);
			chbHoy.Name = "chbHoy";
			chbHoy.Size = new Size(95, 42);
			chbHoy.TabIndex = 11;
			chbHoy.Text = "Hoy";
			chbHoy.UseVisualStyleBackColor = true;
			chbHoy.CheckedChanged += chbHoy_CheckedChanged;
			// 
			// FReportes
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(884, 791);
			Controls.Add(chbHoy);
			Controls.Add(pnlFecha);
			Controls.Add(pnlBotonera);
			Controls.Add(dgvVisor);
			Controls.Add(rbtPagos);
			Controls.Add(rbtAsistencias);
			Controls.Add(btnGenerar);
			Name = "FReportes";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Reportes";
			((System.ComponentModel.ISupportInitialize)dgvVisor).EndInit();
			pnlBotonera.ResumeLayout(false);
			pnlFecha.ResumeLayout(false);
			pnlFecha.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private DateTimePicker dtpDesde;
		private Button btnGenerar;
		private RadioButton rbtAsistencias;
		private RadioButton rbtPagos;
		private DataGridView dgvVisor;
		private Panel pnlBotonera;
		private Button btnSalir;
		private Button btnGuardar;
		private Label label1;
		private Label label2;
		private DateTimePicker dtpHasta;
		private Panel pnlFecha;
		private CheckBox chbHoy;
	}
}