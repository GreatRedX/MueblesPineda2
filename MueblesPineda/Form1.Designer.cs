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
			SuspendLayout();
			// 
			// btnEnviar
			// 
			btnEnviar.Location = new Point(253, 115);
			btnEnviar.Name = "btnEnviar";
			btnEnviar.Size = new Size(75, 23);
			btnEnviar.TabIndex = 0;
			btnEnviar.Text = "button1";
			btnEnviar.UseVisualStyleBackColor = true;
			btnEnviar.Click += btnEnviar_Click;
			// 
			// txtMensaje
			// 
			txtMensaje.Location = new Point(147, 116);
			txtMensaje.Name = "txtMensaje";
			txtMensaje.Size = new Size(100, 23);
			txtMensaje.TabIndex = 1;
			// 
			// lstMensajes
			// 
			lstMensajes.FormattingEnabled = true;
			lstMensajes.ItemHeight = 15;
			lstMensajes.Location = new Point(147, 188);
			lstMensajes.Name = "lstMensajes";
			lstMensajes.Size = new Size(120, 94);
			lstMensajes.TabIndex = 2;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lstMensajes);
			Controls.Add(txtMensaje);
			Controls.Add(btnEnviar);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnEnviar;
		private TextBox txtMensaje;
		private ListBox lstMensajes;
	}
}