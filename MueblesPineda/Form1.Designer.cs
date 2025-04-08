namespace MueblesPineda
{
	partial class Form1
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
			btnEnviar = new Button();
			txtMensaje = new TextBox();
			lstMensajes = new ListBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnEnviar
			// 
			btnEnviar.Location = new Point(505, 363);
			btnEnviar.Name = "btnEnviar";
			btnEnviar.Size = new Size(86, 23);
			btnEnviar.TabIndex = 0;
			btnEnviar.Text = "Enviar";
			btnEnviar.UseVisualStyleBackColor = true;
			btnEnviar.Click += btnEnviar_Click;
			// 
			// txtMensaje
			// 
			txtMensaje.Location = new Point(124, 364);
			txtMensaje.Name = "txtMensaje";
			txtMensaje.PlaceholderText = "Mensaje";
			txtMensaje.Size = new Size(375, 23);
			txtMensaje.TabIndex = 1;
			// 
			// lstMensajes
			// 
			lstMensajes.FormattingEnabled = true;
			lstMensajes.ItemHeight = 15;
			lstMensajes.Location = new Point(124, 87);
			lstMensajes.Name = "lstMensajes";
			lstMensajes.Size = new Size(467, 244);
			lstMensajes.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(49, 30);
			label1.MaximumSize = new Size(200, 100);
			label1.Name = "label1";
			label1.Size = new Size(186, 28);
			label1.TabIndex = 3;
			label1.Text = "💬 Chat con Cliente";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(713, 450);
			Controls.Add(label1);
			Controls.Add(lstMensajes);
			Controls.Add(txtMensaje);
			Controls.Add(btnEnviar);
			Name = "Form1";
			Text = "Muebles Pineda";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnEnviar;
		private TextBox txtMensaje;
		private ListBox lstMensajes;
		private Label label1;
	}
}
