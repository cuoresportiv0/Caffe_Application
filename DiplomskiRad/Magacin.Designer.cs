/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 8/1/2018
 * Time: 11:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DiplomskiRad
{
	partial class Magacin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button pregled;
		private System.Windows.Forms.Button azuriranje;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panelpregled;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button prikaz;
		private System.Windows.Forms.DataGridViewTextBoxColumn artikl;
		private System.Windows.Forms.DataGridViewTextBoxColumn cena;
		private System.Windows.Forms.DataGridViewTextBoxColumn stanje;
		private System.Windows.Forms.Panel panelazuriranje;
		private System.Windows.Forms.Button dugmeNazad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox izborArtikla;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button unesiIzmene;
		private System.Windows.Forms.Label label2;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magacin));
			this.pregled = new System.Windows.Forms.Button();
			this.azuriranje = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panelpregled = new System.Windows.Forms.Panel();
			this.prikaz = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.artikl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelazuriranje = new System.Windows.Forms.Panel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.unesiIzmene = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.izborArtikla = new System.Windows.Forms.ComboBox();
			this.dugmeNazad = new System.Windows.Forms.Button();
			this.panelpregled.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panelazuriranje.SuspendLayout();
			this.SuspendLayout();
			// 
			// pregled
			// 
			this.pregled.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pregled.ForeColor = System.Drawing.Color.Peru;
			this.pregled.Location = new System.Drawing.Point(40, 49);
			this.pregled.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.pregled.Name = "pregled";
			this.pregled.Size = new System.Drawing.Size(155, 57);
			this.pregled.TabIndex = 0;
			this.pregled.Text = "Pregled ";
			this.pregled.UseVisualStyleBackColor = true;
			this.pregled.Click += new System.EventHandler(this.PregledClick);
			// 
			// azuriranje
			// 
			this.azuriranje.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.azuriranje.ForeColor = System.Drawing.Color.Peru;
			this.azuriranje.Location = new System.Drawing.Point(345, 51);
			this.azuriranje.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.azuriranje.Name = "azuriranje";
			this.azuriranje.Size = new System.Drawing.Size(159, 57);
			this.azuriranje.TabIndex = 1;
			this.azuriranje.Text = "Azuriranje";
			this.azuriranje.UseVisualStyleBackColor = true;
			this.azuriranje.Click += new System.EventHandler(this.AzuriranjeClick);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Peru;
			this.button3.Location = new System.Drawing.Point(651, 51);
			this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(163, 55);
			this.button3.TabIndex = 2;
			this.button3.Text = "Unos novog artikla";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// panelpregled
			// 
			this.panelpregled.Controls.Add(this.prikaz);
			this.panelpregled.Controls.Add(this.dataGridView1);
			this.panelpregled.Location = new System.Drawing.Point(147, 129);
			this.panelpregled.Name = "panelpregled";
			this.panelpregled.Size = new System.Drawing.Size(617, 482);
			this.panelpregled.TabIndex = 3;
			// 
			// prikaz
			// 
			this.prikaz.ForeColor = System.Drawing.Color.Peru;
			this.prikaz.Location = new System.Drawing.Point(4, 4);
			this.prikaz.Name = "prikaz";
			this.prikaz.Size = new System.Drawing.Size(151, 23);
			this.prikaz.TabIndex = 1;
			this.prikaz.Text = "Prikazi stanje";
			this.prikaz.UseVisualStyleBackColor = true;
			this.prikaz.Click += new System.EventHandler(this.PrikazClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Peru;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.artikl,
			this.cena,
			this.stanje});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Peru;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.Location = new System.Drawing.Point(4, 34);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(544, 384);
			this.dataGridView1.TabIndex = 2;
			// 
			// artikl
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Peru;
			this.artikl.DefaultCellStyle = dataGridViewCellStyle2;
			this.artikl.HeaderText = "Artikl";
			this.artikl.Name = "artikl";
			this.artikl.ReadOnly = true;
			this.artikl.Width = 200;
			// 
			// cena
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Peru;
			this.cena.DefaultCellStyle = dataGridViewCellStyle3;
			this.cena.HeaderText = "Cena";
			this.cena.Name = "cena";
			this.cena.ReadOnly = true;
			this.cena.Width = 150;
			// 
			// stanje
			// 
			this.stanje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Peru;
			this.stanje.DefaultCellStyle = dataGridViewCellStyle4;
			this.stanje.HeaderText = "Broj na stanju";
			this.stanje.Name = "stanje";
			this.stanje.ReadOnly = true;
			this.stanje.Width = 150;
			// 
			// panelazuriranje
			// 
			this.panelazuriranje.Controls.Add(this.textBox2);
			this.panelazuriranje.Controls.Add(this.label3);
			this.panelazuriranje.Controls.Add(this.textBox1);
			this.panelazuriranje.Controls.Add(this.unesiIzmene);
			this.panelazuriranje.Controls.Add(this.label2);
			this.panelazuriranje.Controls.Add(this.label1);
			this.panelazuriranje.Controls.Add(this.izborArtikla);
			this.panelazuriranje.Location = new System.Drawing.Point(201, 115);
			this.panelazuriranje.Name = "panelazuriranje";
			this.panelazuriranje.Size = new System.Drawing.Size(548, 438);
			this.panelazuriranje.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.ForeColor = System.Drawing.Color.Peru;
			this.textBox2.Location = new System.Drawing.Point(20, 278);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(114, 26);
			this.textBox2.TabIndex = 8;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2KeyPress);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Peru;
			this.label3.Location = new System.Drawing.Point(20, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Unesite novu cenu:";
			// 
			// textBox1
			// 
			this.textBox1.ForeColor = System.Drawing.Color.Peru;
			this.textBox1.Location = new System.Drawing.Point(20, 185);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(114, 26);
			this.textBox1.TabIndex = 6;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// unesiIzmene
			// 
			this.unesiIzmene.BackColor = System.Drawing.Color.FloralWhite;
			this.unesiIzmene.ForeColor = System.Drawing.Color.Peru;
			this.unesiIzmene.Location = new System.Drawing.Point(421, 375);
			this.unesiIzmene.Name = "unesiIzmene";
			this.unesiIzmene.Size = new System.Drawing.Size(100, 34);
			this.unesiIzmene.TabIndex = 5;
			this.unesiIzmene.Text = "Azuriraj";
			this.unesiIzmene.UseVisualStyleBackColor = false;
			this.unesiIzmene.Click += new System.EventHandler(this.UnesiIzmeneClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Peru;
			this.label2.Location = new System.Drawing.Point(20, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(320, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "Unesite broj pristiglih komada:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Peru;
			this.label1.Location = new System.Drawing.Point(20, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Izaberite artikl:";
			// 
			// izborArtikla
			// 
			this.izborArtikla.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.izborArtikla.ForeColor = System.Drawing.Color.Peru;
			this.izborArtikla.FormattingEnabled = true;
			this.izborArtikla.Location = new System.Drawing.Point(20, 66);
			this.izborArtikla.Name = "izborArtikla";
			this.izborArtikla.Size = new System.Drawing.Size(206, 26);
			this.izborArtikla.TabIndex = 0;
			// 
			// dugmeNazad
			// 
			this.dugmeNazad.BackColor = System.Drawing.Color.FloralWhite;
			this.dugmeNazad.ForeColor = System.Drawing.Color.Red;
			this.dugmeNazad.Location = new System.Drawing.Point(746, 496);
			this.dugmeNazad.Name = "dugmeNazad";
			this.dugmeNazad.Size = new System.Drawing.Size(87, 48);
			this.dugmeNazad.TabIndex = 5;
			this.dugmeNazad.Text = "Nazad";
			this.dugmeNazad.UseVisualStyleBackColor = false;
			this.dugmeNazad.Click += new System.EventHandler(this.DugmeNazadClick);
			// 
			// Magacin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(914, 580);
			this.Controls.Add(this.panelazuriranje);
			this.Controls.Add(this.dugmeNazad);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.azuriranje);
			this.Controls.Add(this.pregled);
			this.Controls.Add(this.panelpregled);
			this.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Magacin";
			this.Text = "Magacin";
			this.panelpregled.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panelazuriranje.ResumeLayout(false);
			this.panelazuriranje.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
