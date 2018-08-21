/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 7/23/2018
 * Time: 3:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DiplomskiRad
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button lokaldugme;
		private System.Windows.Forms.Button magacindugme;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lokaldugme = new System.Windows.Forms.Button();
			this.magacindugme = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lokaldugme
			// 
			this.lokaldugme.BackColor = System.Drawing.Color.White;
			this.lokaldugme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lokaldugme.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lokaldugme.ForeColor = System.Drawing.Color.Peru;
			this.lokaldugme.Location = new System.Drawing.Point(283, 102);
			this.lokaldugme.Name = "lokaldugme";
			this.lokaldugme.Size = new System.Drawing.Size(218, 54);
			this.lokaldugme.TabIndex = 0;
			this.lokaldugme.Text = "Lokal";
			this.lokaldugme.UseVisualStyleBackColor = false;
			this.lokaldugme.Click += new System.EventHandler(this.LokaldugmeClick);
			// 
			// magacindugme
			// 
			this.magacindugme.BackColor = System.Drawing.Color.White;
			this.magacindugme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.magacindugme.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.magacindugme.ForeColor = System.Drawing.Color.Peru;
			this.magacindugme.Location = new System.Drawing.Point(283, 215);
			this.magacindugme.Name = "magacindugme";
			this.magacindugme.Size = new System.Drawing.Size(218, 52);
			this.magacindugme.TabIndex = 1;
			this.magacindugme.Text = "Magacin";
			this.magacindugme.UseVisualStyleBackColor = false;
			this.magacindugme.Click += new System.EventHandler(this.MagacindugmeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.magacindugme);
			this.Controls.Add(this.lokaldugme);
			this.Name = "MainForm";
			this.Text = "Caffe";
			this.ResumeLayout(false);

		}
	}
}
