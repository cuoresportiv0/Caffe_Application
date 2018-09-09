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
		private System.Windows.Forms.Label datum;
		
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
			this.datum = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(386, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(291, 53);
			this.label1.TabIndex = 2;
			this.label1.Text = "00:00:00";
			// 
			// stoPrvi
			// 
			this.stoPrvi.BackColor = System.Drawing.Color.White;
			this.stoPrvi.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stoPrvi.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoPrvi.Location = new System.Drawing.Point(147, 158);
			this.stoPrvi.Name = "stoPrvi";
			this.stoPrvi.Size = new System.Drawing.Size(130, 100);
			this.stoPrvi.TabIndex = 3;
			this.stoPrvi.Text = "Sto 1";
			this.stoPrvi.UseVisualStyleBackColor = false;
			this.stoPrvi.Click += new System.EventHandler(this.StoPrviClick);
			// 
			// stoCetvrti
			// 
			this.stoCetvrti.BackColor = System.Drawing.Color.White;
			this.stoCetvrti.Font = new System.Drawing.Font("Elephant", 24F);
			this.stoCetvrti.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoCetvrti.Location = new System.Drawing.Point(330, 304);
			this.stoCetvrti.Name = "stoCetvrti";
			this.stoCetvrti.Size = new System.Drawing.Size(130, 100);
			this.stoCetvrti.TabIndex = 4;
			this.stoCetvrti.Text = "Sto 4";
			this.stoCetvrti.UseVisualStyleBackColor = false;
			this.stoCetvrti.Click += new System.EventHandler(this.StoCetvrtiClick);
			// 
			// stoSesti
			// 
			this.stoSesti.BackColor = System.Drawing.Color.White;
			this.stoSesti.Font = new System.Drawing.Font("Elephant", 24F);
			this.stoSesti.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoSesti.Location = new System.Drawing.Point(147, 478);
			this.stoSesti.Name = "stoSesti";
			this.stoSesti.Size = new System.Drawing.Size(130, 100);
			this.stoSesti.TabIndex = 5;
			this.stoSesti.Text = "Sto 6";
			this.stoSesti.UseVisualStyleBackColor = false;
			this.stoSesti.Click += new System.EventHandler(this.StoSestiClick);
			// 
			// stoDrugi
			// 
			this.stoDrugi.BackColor = System.Drawing.Color.White;
			this.stoDrugi.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stoDrugi.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoDrugi.Location = new System.Drawing.Point(455, 158);
			this.stoDrugi.Name = "stoDrugi";
			this.stoDrugi.Size = new System.Drawing.Size(130, 100);
			this.stoDrugi.TabIndex = 6;
			this.stoDrugi.Text = "Sto 2";
			this.stoDrugi.UseVisualStyleBackColor = false;
			this.stoDrugi.Click += new System.EventHandler(this.StoDrugiClick);
			// 
			// stoSedmi
			// 
			this.stoSedmi.BackColor = System.Drawing.Color.White;
			this.stoSedmi.Font = new System.Drawing.Font("Elephant", 24F);
			this.stoSedmi.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoSedmi.Location = new System.Drawing.Point(455, 478);
			this.stoSedmi.Name = "stoSedmi";
			this.stoSedmi.Size = new System.Drawing.Size(130, 100);
			this.stoSedmi.TabIndex = 7;
			this.stoSedmi.Text = "Sto 7";
			this.stoSedmi.UseVisualStyleBackColor = false;
			this.stoSedmi.Click += new System.EventHandler(this.StoSedmiClick);
			// 
			// stoPeti
			// 
			this.stoPeti.BackColor = System.Drawing.Color.White;
			this.stoPeti.Font = new System.Drawing.Font("Elephant", 24F);
			this.stoPeti.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoPeti.Location = new System.Drawing.Point(576, 304);
			this.stoPeti.Name = "stoPeti";
			this.stoPeti.Size = new System.Drawing.Size(130, 100);
			this.stoPeti.TabIndex = 8;
			this.stoPeti.Text = "Sto 5";
			this.stoPeti.UseVisualStyleBackColor = false;
			this.stoPeti.Click += new System.EventHandler(this.StoPetiClick);
			// 
			// stoTreci
			// 
			this.stoTreci.BackColor = System.Drawing.Color.White;
			this.stoTreci.Font = new System.Drawing.Font("Elephant", 24F);
			this.stoTreci.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoTreci.Location = new System.Drawing.Point(745, 158);
			this.stoTreci.Name = "stoTreci";
			this.stoTreci.Size = new System.Drawing.Size(130, 100);
			this.stoTreci.TabIndex = 9;
			this.stoTreci.Text = "Sto 3";
			this.stoTreci.UseVisualStyleBackColor = false;
			this.stoTreci.Click += new System.EventHandler(this.StoTreciClick);
			// 
			// stoOsmi
			// 
			this.stoOsmi.BackColor = System.Drawing.Color.White;
			this.stoOsmi.Font = new System.Drawing.Font("Elephant", 24F);
			this.stoOsmi.ForeColor = System.Drawing.Color.DarkOrange;
			this.stoOsmi.Location = new System.Drawing.Point(745, 478);
			this.stoOsmi.Name = "stoOsmi";
			this.stoOsmi.Size = new System.Drawing.Size(130, 100);
			this.stoOsmi.TabIndex = 10;
			this.stoOsmi.Text = "Sto 8";
			this.stoOsmi.UseVisualStyleBackColor = false;
			this.stoOsmi.Click += new System.EventHandler(this.StoOsmiClick);
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
			// datum
			// 
			this.datum.BackColor = System.Drawing.Color.Transparent;
			this.datum.Font = new System.Drawing.Font("Elephant", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datum.ForeColor = System.Drawing.Color.White;
			this.datum.Location = new System.Drawing.Point(37, 9);
			this.datum.Name = "datum";
			this.datum.Size = new System.Drawing.Size(343, 69);
			this.datum.TabIndex = 12;
			this.datum.Text = "label2";
			// 
			// Lokal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(984, 661);
			this.Controls.Add(this.datum);
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
			this.Name = "Lokal";
			this.Text = "Lokal";
			this.Load += new System.EventHandler(this.LokalLoad);
			this.ResumeLayout(false);

		}
	}
}
