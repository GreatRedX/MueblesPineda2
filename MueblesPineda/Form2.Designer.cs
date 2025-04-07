namespace MueblesPineda
{
	partial class Form2
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
			button1 = new Button();
			textBox1 = new TextBox();
			lstMensajes = new ListBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(302, 99);
			button1.Name = "button1";
			button1.Size = new Size(97, 33);
			button1.TabIndex = 0;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(113, 95);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(143, 23);
			textBox1.TabIndex = 1;
			// 
			// lstMensajes
			// 
			lstMensajes.FormattingEnabled = true;
			lstMensajes.ItemHeight = 15;
			lstMensajes.Location = new Point(153, 182);
			lstMensajes.Name = "lstMensajes";
			lstMensajes.Size = new Size(120, 94);
			lstMensajes.TabIndex = 3;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lstMensajes);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Name = "Form2";
			Text = "Form2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private TextBox textBox1;
		private ListBox lstMensajes;
	}
}