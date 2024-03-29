﻿/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 8/6/2018
 * Time: 11:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DiplomskiRad
{
	partial class Sto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelSto;
		private System.Windows.Forms.ComboBox spisakPica;
		private System.Windows.Forms.Button dugmeIsporuci;
		private System.Windows.Forms.Label labelZaduzenje;
		private System.Windows.Forms.ListBox Racun;
		private System.Windows.Forms.Button kreirajRacun;
		private System.Windows.Forms.Button dugmeNazad;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sto));
			this.labelSto = new System.Windows.Forms.Label();
			this.spisakPica = new System.Windows.Forms.ComboBox();
			this.dugmeIsporuci = new System.Windows.Forms.Button();
			this.labelZaduzenje = new System.Windows.Forms.Label();
			this.Racun = new System.Windows.Forms.ListBox();
			this.kreirajRacun = new System.Windows.Forms.Button();
			this.dugmeNazad = new System.Windows.Forms.Button();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.SuspendLayout();
			// 
			// labelSto
			// 
			this.labelSto.BackColor = System.Drawing.Color.White;
			this.labelSto.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSto.ForeColor = System.Drawing.Color.DarkOrange;
			this.labelSto.Location = new System.Drawing.Point(34, 28);
			this.labelSto.Name = "labelSto";
			this.labelSto.Size = new System.Drawing.Size(188, 27);
			this.labelSto.TabIndex = 0;
			this.labelSto.Text = "Odaberite artikal:";
			// 
			// spisakPica
			// 
			this.spisakPica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.spisakPica.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.spisakPica.ForeColor = System.Drawing.Color.DarkOrange;
			this.spisakPica.FormattingEnabled = true;
			this.spisakPica.Location = new System.Drawing.Point(34, 81);
			this.spisakPica.Name = "spisakPica";
			this.spisakPica.Size = new System.Drawing.Size(167, 24);
			this.spisakPica.TabIndex = 1;
			// 
			// dugmeIsporuci
			// 
			this.dugmeIsporuci.BackColor = System.Drawing.SystemColors.Control;
			this.dugmeIsporuci.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dugmeIsporuci.ForeColor = System.Drawing.Color.DarkOrange;
			this.dugmeIsporuci.Location = new System.Drawing.Point(71, 143);
			this.dugmeIsporuci.Name = "dugmeIsporuci";
			this.dugmeIsporuci.Size = new System.Drawing.Size(110, 39);
			this.dugmeIsporuci.TabIndex = 2;
			this.dugmeIsporuci.Text = "Isporuka";
			this.dugmeIsporuci.UseVisualStyleBackColor = false;
			this.dugmeIsporuci.Click += new System.EventHandler(this.DugmeIsporuciClick);
			// 
			// labelZaduzenje
			// 
			this.labelZaduzenje.BackColor = System.Drawing.Color.White;
			this.labelZaduzenje.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelZaduzenje.ForeColor = System.Drawing.Color.DarkOrange;
			this.labelZaduzenje.Location = new System.Drawing.Point(626, 29);
			this.labelZaduzenje.Name = "labelZaduzenje";
			this.labelZaduzenje.Size = new System.Drawing.Size(178, 26);
			this.labelZaduzenje.TabIndex = 3;
			this.labelZaduzenje.Text = "Dugovanje stola:";
			// 
			// Racun
			// 
			this.Racun.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Racun.ForeColor = System.Drawing.Color.Black;
			this.Racun.FormattingEnabled = true;
			this.Racun.ItemHeight = 16;
			this.Racun.Location = new System.Drawing.Point(582, 71);
			this.Racun.Name = "Racun";
			this.Racun.Size = new System.Drawing.Size(262, 212);
			this.Racun.TabIndex = 4;
			// 
			// kreirajRacun
			// 
			this.kreirajRacun.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold);
			this.kreirajRacun.ForeColor = System.Drawing.Color.DarkOrange;
			this.kreirajRacun.Location = new System.Drawing.Point(620, 304);
			this.kreirajRacun.Name = "kreirajRacun";
			this.kreirajRacun.Size = new System.Drawing.Size(184, 33);
			this.kreirajRacun.TabIndex = 5;
			this.kreirajRacun.Text = "Ispostavi Racun";
			this.kreirajRacun.UseVisualStyleBackColor = true;
			this.kreirajRacun.Click += new System.EventHandler(this.KreirajRacunClick);
			// 
			// dugmeNazad
			// 
			this.dugmeNazad.BackColor = System.Drawing.Color.White;
			this.dugmeNazad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dugmeNazad.ForeColor = System.Drawing.Color.Red;
			this.dugmeNazad.Location = new System.Drawing.Point(800, 420);
			this.dugmeNazad.Name = "dugmeNazad";
			this.dugmeNazad.Size = new System.Drawing.Size(72, 35);
			this.dugmeNazad.TabIndex = 6;
			this.dugmeNazad.Text = "Nazad";
			this.dugmeNazad.UseVisualStyleBackColor = false;
			this.dugmeNazad.Click += new System.EventHandler(this.DugmeNazadClick);
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// Sto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(884, 467);
			this.Controls.Add(this.dugmeNazad);
			this.Controls.Add(this.kreirajRacun);
			this.Controls.Add(this.Racun);
			this.Controls.Add(this.labelZaduzenje);
			this.Controls.Add(this.dugmeIsporuci);
			this.Controls.Add(this.spisakPica);
			this.Controls.Add(this.labelSto);
			this.Name = "Sto";
			this.Text = "Sto";
			this.ResumeLayout(false);

		}
	}
}
