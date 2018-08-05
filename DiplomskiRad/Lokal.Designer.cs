/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 8/4/2018
 * Time: 11:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DiplomskiRad
{
	partial class Lokal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelRadnik;
		private System.Windows.Forms.ComboBox spisakRadnika;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button stoPrvi;
		private System.Windows.Forms.Button stoCetvrti;
		private System.Windows.Forms.Button stoSesti;
		private System.Windows.Forms.Button stoDrugi;
		private System.Windows.Forms.Button stoSedmi;
		private System.Windows.Forms.Button stoPeti;
		private System.Windows.Forms.Button stoTreci;
		private System.Windows.Forms.Button stoOsmi;
		private System.Windows.Forms.Button dugmeNazad;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lokal));
			this.labelRadnik = new System.Windows.Forms.Label();
			this.spisakRadnika = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.stoPrvi = new System.Windows.Forms.Button();
			this.stoCetvrti = new System.Windows.Forms.Button();
			this.stoSesti = new System.Windows.Forms.Button();
			this.stoDrugi = new System.Windows.Forms.Button();
			this.stoSedmi = new System.Windows.Forms.Button();
			this.stoPeti = new System.Windows.Forms.Button();
			this.stoTreci = new System.Windows.Forms.Button();
			this.stoOsmi = new System.Windows.Forms.Button();
			this.dugmeNazad = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelRadnik
			// 
			this.labelRadnik.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelRadnik.ForeColor = System.Drawing.Color.DarkOrange;
			this.labelRadnik.Location = new System.Drawing.Point(48, 24);
			this.labelRadnik.Name = "labelRadnik";
			this.labelRadnik.Size = new System.Drawing.Size(142, 23);
			this.labelRadnik.TabIndex = 0;
			this.labelRadnik.Text = "Radnik:";
			// 
			// spisakRadnika
			// 
			this.spisakRadnika.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.spisakRadnika.ForeColor = System.Drawing.Color.DarkOrange;
			this.spisakRadnika.FormattingEnabled = true;
			this.spisakRadnika.Location = new System.Drawing.Point(48, 63);
			this.spisakRadnika.Name = "spisakRadnika";
			this.spisakRadnika.Size = new System.Drawing.Size(142, 26);
			this.spisakRadnika.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkOrange;
			this.label1.Location = new System.Drawing.Point(446, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 48);
			this.label1.TabIndex = 2;
			this.label1.Text = "00:00:00";
			// 
			// stoPrvi
			// 
			this.stoPrvi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stoPrvi.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoPrvi.Location = new System.Drawing.Point(147, 158);
			this.stoPrvi.Name = "stoPrvi";
			this.stoPrvi.Size = new System.Drawing.Size(112, 84);
			this.stoPrvi.TabIndex = 3;
			this.stoPrvi.Text = "Sto 1";
			this.stoPrvi.UseVisualStyleBackColor = true;
			// 
			// stoCetvrti
			// 
			this.stoCetvrti.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stoCetvrti.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoCetvrti.Location = new System.Drawing.Point(330, 304);
			this.stoCetvrti.Name = "stoCetvrti";
			this.stoCetvrti.Size = new System.Drawing.Size(112, 84);
			this.stoCetvrti.TabIndex = 4;
			this.stoCetvrti.Text = "Sto 4";
			this.stoCetvrti.UseVisualStyleBackColor = true;
			// 
			// stoSesti
			// 
			this.stoSesti.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stoSesti.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoSesti.Location = new System.Drawing.Point(147, 478);
			this.stoSesti.Name = "stoSesti";
			this.stoSesti.Size = new System.Drawing.Size(112, 84);
			this.stoSesti.TabIndex = 5;
			this.stoSesti.Text = "Sto 6";
			this.stoSesti.UseVisualStyleBackColor = true;
			// 
			// stoDrugi
			// 
			this.stoDrugi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stoDrugi.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoDrugi.Location = new System.Drawing.Point(455, 158);
			this.stoDrugi.Name = "stoDrugi";
			this.stoDrugi.Size = new System.Drawing.Size(112, 84);
			this.stoDrugi.TabIndex = 6;
			this.stoDrugi.Text = "Sto 2";
			this.stoDrugi.UseVisualStyleBackColor = true;
			// 
			// stoSedmi
			// 
			this.stoSedmi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stoSedmi.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoSedmi.Location = new System.Drawing.Point(455, 478);
			this.stoSedmi.Name = "stoSedmi";
			this.stoSedmi.Size = new System.Drawing.Size(112, 84);
			this.stoSedmi.TabIndex = 7;
			this.stoSedmi.Text = "Sto 7";
			this.stoSedmi.UseVisualStyleBackColor = true;
			// 
			// stoPeti
			// 
			this.stoPeti.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stoPeti.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoPeti.Location = new System.Drawing.Point(576, 304);
			this.stoPeti.Name = "stoPeti";
			this.stoPeti.Size = new System.Drawing.Size(112, 84);
			this.stoPeti.TabIndex = 8;
			this.stoPeti.Text = "Sto 5";
			this.stoPeti.UseVisualStyleBackColor = true;
			// 
			// stoTreci
			// 
			this.stoTreci.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stoTreci.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoTreci.Location = new System.Drawing.Point(745, 158);
			this.stoTreci.Name = "stoTreci";
			this.stoTreci.Size = new System.Drawing.Size(112, 84);
			this.stoTreci.TabIndex = 9;
			this.stoTreci.Text = "Sto 3";
			this.stoTreci.UseVisualStyleBackColor = true;
			// 
			// stoOsmi
			// 
			this.stoOsmi.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stoOsmi.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoOsmi.Location = new System.Drawing.Point(745, 478);
			this.stoOsmi.Name = "stoOsmi";
			this.stoOsmi.Size = new System.Drawing.Size(112, 84);
			this.stoOsmi.TabIndex = 10;
			this.stoOsmi.Text = "Sto 8";
			this.stoOsmi.UseVisualStyleBackColor = true;
			// 
			// dugmeNazad
			// 
			this.dugmeNazad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dugmeNazad.ForeColor = System.Drawing.Color.Red;
			this.dugmeNazad.Location = new System.Drawing.Point(900, 12);
			this.dugmeNazad.Name = "dugmeNazad";
			this.dugmeNazad.Size = new System.Drawing.Size(72, 35);
			this.dugmeNazad.TabIndex = 11;
			this.dugmeNazad.Text = "Nazad";
			this.dugmeNazad.UseVisualStyleBackColor = true;
			this.dugmeNazad.Click += new System.EventHandler(this.DugmeNazadClick);
			// 
			// Lokal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(984, 661);
			this.Controls.Add(this.dugmeNazad);
			this.Controls.Add(this.stoOsmi);
			this.Controls.Add(this.stoTreci);
			this.Controls.Add(this.stoPeti);
			this.Controls.Add(this.stoSedmi);
			this.Controls.Add(this.stoDrugi);
			this.Controls.Add(this.stoSesti);
			this.Controls.Add(this.stoCetvrti);
			this.Controls.Add(this.stoPrvi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.spisakRadnika);
			this.Controls.Add(this.labelRadnik);
			this.Name = "Lokal";
			this.Text = "Lokal";
			this.Load += new System.EventHandler(this.LokalLoad);
			this.ResumeLayout(false);

		}
	}
}
