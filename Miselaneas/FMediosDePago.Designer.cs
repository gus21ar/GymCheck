namespace Miselaneas
{
	partial class FMediosDePago
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
			txtNombre = new TextBox();
			btnAgregar = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Georgia", 48F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(715, 72);
			label1.TabIndex = 0;
			label1.Text = "Agregar Medios de Pago";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 136);
			label2.Name = "label2";
			label2.Size = new Size(143, 38);
			label2.TabIndex = 1;
			label2.Text = "Nombre:";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(161, 136);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(561, 44);
			txtNombre.TabIndex = 2;
			// 
			// btnAgregar
			// 
			btnAgregar.Location = new Point(12, 220);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(715, 179);
			btnAgregar.TabIndex = 3;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// FMediosDePago
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(734, 411);
			Controls.Add(btnAgregar);
			Controls.Add(txtNombre);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(8, 8, 8, 8);
			Name = "FMediosDePago";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Agregar Medios De Pago";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtNombre;
		private Button btnAgregar;
	}
}