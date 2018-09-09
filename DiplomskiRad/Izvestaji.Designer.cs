/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 8/25/2018
 * Time: 3:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DiplomskiRad
{
	partial class Izvestaj
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		
		private System.Windows.Forms.ComboBox odabirMeseca;
		private System.Windows.Forms.DataGridView grid;
		private System.Windows.Forms.DataGridViewTextBoxColumn dan;
		private System.Windows.Forms.DataGridViewTextBoxColumn mesec;
		private System.Windows.Forms.DataGridViewTextBoxColumn godina;
		private System.Windows.Forms.DataGridViewTextBoxColumn vreme;
		private System.Windows.Forms.DataGridViewTextBoxColumn ukupnaVrednost;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox odabirDana;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox prihodMesec;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox prihodDan;
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Izvestaj));
			this.label1 = new System.Windows.Forms.Label();
			this.odabirMeseca = new System.Windows.Forms.ComboBox();
			this.grid = new System.Windows.Forms.DataGridView();
			this.dan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mesec = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vreme = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ukupnaVrednost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.odabirDana = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.prihodMesec = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.prihodDan = new System.Windows.Forms.ListBox();
			this.dugmeNazad = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkOrange;
			this.label1.Location = new System.Drawing.Point(28, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Izaberite mesec:";
			// 
			// odabirMeseca
			// 
			this.odabirMeseca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.odabirMeseca.ForeColor = System.Drawing.Color.Black;
			this.odabirMeseca.FormattingEnabled = true;
			this.odabirMeseca.Location = new System.Drawing.Point(273, 23);
			this.odabirMeseca.Name = "odabirMeseca";
			this.odabirMeseca.Size = new System.Drawing.Size(63, 24);
			this.odabirMeseca.TabIndex = 1;
			this.odabirMeseca.SelectedIndexChanged += new System.EventHandler(this.OdabirMesecaSelectedIndexChanged);
			// 
			// grid
			// 
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.AllowUserToResizeColumns = false;
			this.grid.AllowUserToResizeRows = false;
			this.grid.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dan,
			this.mesec,
			this.godina,
			this.vreme,
			this.ukupnaVrednost});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid.DefaultCellStyle = dataGridViewCellStyle2;
			this.grid.Location = new System.Drawing.Point(189, 190);
			this.grid.Name = "grid";
			this.grid.Size = new System.Drawing.Size(544, 355);
			this.grid.TabIndex = 2;
			// 
			// dan
			// 
			this.dan.HeaderText = "Dan";
			this.dan.Name = "dan";
			// 
			// mesec
			// 
			this.mesec.HeaderText = "Mesec";
			this.mesec.Name = "mesec";
			// 
			// godina
			// 
			this.godina.HeaderText = "Godina";
			this.godina.Name = "godina";
			// 
			// vreme
			// 
			this.vreme.HeaderText = "Vreme";
			this.vreme.Name = "vreme";
			// 
			// ukupnaVrednost
			// 
			this.ukupnaVrednost.HeaderText = "Vrednost racuna";
			this.ukupnaVrednost.Name = "ukupnaVrednost";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkOrange;
			this.label2.Location = new System.Drawing.Point(28, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(212, 31);
			this.label2.TabIndex = 3;
			this.label2.Text = "Izaberite dan:";
			// 
			// odabirDana
			// 
			this.odabirDana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.odabirDana.ForeColor = System.Drawing.Color.Black;
			this.odabirDana.FormattingEnabled = true;
			this.odabirDana.Location = new System.Drawing.Point(273, 84);
			this.odabirDana.Name = "odabirDana";
			this.odabirDana.Size = new System.Drawing.Size(63, 24);
			this.odabirDana.TabIndex = 4;
			this.odabirDana.SelectedIndexChanged += new System.EventHandler(this.OdabirDanaSelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkOrange;
			this.label3.Location = new System.Drawing.Point(382, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(351, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ukupan prihod za izabrani mesec:";
			// 
			// prihodMesec
			// 
			this.prihodMesec.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.prihodMesec.FormattingEnabled = true;
			this.prihodMesec.ItemHeight = 20;
			this.prihodMesec.Location = new System.Drawing.Point(749, 13);
			this.prihodMesec.Name = "prihodMesec";
			this.prihodMesec.Size = new System.Drawing.Size(120, 44);
			this.prihodMesec.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkOrange;
			this.label4.Location = new System.Drawing.Point(382, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(351, 31);
			this.label4.TabIndex = 7;
			this.label4.Text = "Ukupan prihod za izabrani dan:";
			// 
			// prihodDan
			// 
			this.prihodDan.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.prihodDan.FormattingEnabled = true;
			this.prihodDan.ItemHeight = 20;
			this.prihodDan.Location = new System.Drawing.Point(749, 64);
			this.prihodDan.Name = "prihodDan";
			this.prihodDan.Size = new System.Drawing.Size(120, 44);
			this.prihodDan.TabIndex = 8;
			// 
			// dugmeNazad
			// 
			this.dugmeNazad.BackColor = System.Drawing.Color.White;
			this.dugmeNazad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dugmeNazad.ForeColor = System.Drawing.Color.Red;
			this.dugmeNazad.Location = new System.Drawing.Point(900, 12);
			this.dugmeNazad.Name = "dugmeNazad";
			this.dugmeNazad.Size = new System.Drawing.Size(72, 35);
			this.dugmeNazad.TabIndex = 9;
			this.dugmeNazad.Text = "Nazad";
			this.dugmeNazad.UseVisualStyleBackColor = false;
			this.dugmeNazad.Click += new System.EventHandler(this.DugmeNazadClick);
			// 
			// Izvestaj
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(984, 661);
			this.Controls.Add(this.dugmeNazad);
			this.Controls.Add(this.prihodDan);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.prihodMesec);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.odabirDana);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.odabirMeseca);
			this.Controls.Add(this.label1);
			this.Name = "Izvestaj";
			this.Text = "Izvestaji";
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
