
namespace Wisej.MessageBoxPatch
{
	partial class Page1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new Wisej.Web.Button();
            this.desktop1 = new Wisej.Web.Desktop();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // desktop1
            // 
            this.desktop1.AutoHideTaskbar = true;
            this.desktop1.Location = new System.Drawing.Point(223, 67);
            this.desktop1.Name = "desktop1";
            this.desktop1.Size = new System.Drawing.Size(447, 371);
            this.desktop1.Text = "desktop1";
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.desktop1);
            this.Controls.Add(this.button1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1055, 542);
            this.Text = "Page1";
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Button button1;
		private Web.Desktop desktop1;
	}
}

