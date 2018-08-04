/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 8/1/2018
 * Time: 11:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
namespace DiplomskiRad
{
	/// <summary>
	/// Description of Magacin.
	/// </summary>
	public partial class Magacin : Form
	{
		public SQLiteConnection konekcija;
		
	
		public Magacin()
		{
			
			InitializeComponent();
			setKonekcija();
			
		
		}
		
		
		void setKonekcija(){
			konekcija = new SQLiteConnection("Data Source=baza.db;Version=3");
			konekcija.Open();
	}
	/*	void PrikazClick(object sender, EventArgs e)
		{

			using (SQLiteCommand comm = new SQLiteCommand("Select * From artikli", konekcija)) {
				using (SQLiteDataReader read = comm.ExecuteReader()) {
					while (read.Read()) {
						dataGridView1.Rows.Add(new object[] {
							read.GetValue(1),
							// U can use column index
							read.GetValue(2),
							// Or column name like this
							read.GetValue(3),
						});
					}
				}
			}
		
}*/
		void PregledClick(object sender, EventArgs e)
			
		{	
			dataGridView1.Rows.Clear();
			dataGridView1.Refresh();
			panelpregled.BringToFront();
			
			
			using (SQLiteCommand comm = new SQLiteCommand("Select * From artikli", konekcija)) {
				using (SQLiteDataReader read = comm.ExecuteReader()) {
					while (read.Read()) {
						dataGridView1.Rows.Add(new object[] {
							read.GetValue(1),
							// U can use column index
							read.GetValue(2),
							// Or column name like this
							read.GetValue(3),
						});
					}
				}
		}
		}
		void AzuriranjeClick(object sender, EventArgs e)
		{
			izborArtikla.Items.Clear();
			nazivArtikla();
			panelazuriranje.BringToFront();
			
		}
		void DugmeNazadClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void nazivArtikla(){
			
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
					komanda.CommandText = @"SELECT naziv From artikli";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						izborArtikla.Items.Add(r.GetValue(0) + "");
						
				}
		

			}
		}
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			Char ch=e.KeyChar;
			if(!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled=true;
				MessageBox.Show("Unesite broj!","", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
				Char ch=e.KeyChar;
			if(!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled=true;
				MessageBox.Show("Unesite broj!" ,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void UnesiIzmeneClick(object sender, EventArgs e)
		{
			 string naziv=izborArtikla.Text;
			 
			 
			 if(textBox1.Text!=""){
			 	int brojInt=int.Parse(textBox1.Text);
			 	
			 	using(SQLiteCommand kkomanda = konekcija.CreateCommand()){
				kkomanda.CommandText = @"UPDATE artikli SET broj_na_stanju = broj_na_stanju +'"+brojInt+"' WHERE naziv = '"+ naziv +"'";
				SQLiteDataReader r= kkomanda.ExecuteReader();
			 		}
			 	
			 
			 }
			 	if(textBox2.Text!=""){
			 		int cenaInt=int.Parse(textBox2.Text);
			 	
			 		using(SQLiteCommand kom= konekcija.CreateCommand()){
			 		kom.CommandText=@"Update artikli SET cena='"+cenaInt+"'WHERE naziv = '"+ naziv +"'";
			 		SQLiteDataReader rr=kom.ExecuteReader();
			 			
			 		}
			 		
			 	}
			 MessageBox.Show("Uspesno izvrsena izmena!" ,"", MessageBoxButtons.OK, MessageBoxIcon.Information);
			 textBox1.Clear();
			 textBox2.Clear();
			 izborArtikla.ResetText();
						 
			 
			 
		}
		void Button3Click(object sender, EventArgs e)
		{
			panelNovi.BringToFront();
		}
		void TextBox4KeyPress(object sender, KeyPressEventArgs e)
		{
			Char ch=e.KeyChar;
			if(!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled=true;
				MessageBox.Show("Morate uneti cenu!" ,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void TextBox5KeyPress(object sender, KeyPressEventArgs e)
		{
			Char ch=e.KeyChar;
			if(!Char.IsDigit(ch) && ch != 8)
			{
				e.Handled=true;
				MessageBox.Show("Morate uneti broj!" ,"", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void DugmeUnosClick(object sender, EventArgs e)
		{
			string imeArtikla=textBox3.Text;
			
			if(textBox3.Text!="" && textBox4.Text!="" && textBox5.Text!=""){
				int cenaNovogArtikla=int.Parse(textBox4.Text);
				int brojNovihArtikala=int.Parse(textBox5.Text);
				
				using(SQLiteCommand izvrsi= konekcija.CreateCommand()){
			 		izvrsi.CommandText=@"INSERT INTO artikli(naziv,cena,broj_na_stanju) values('"+imeArtikla+"',"+cenaNovogArtikla+","+brojNovihArtikala+")";
			 		izvrsi.ExecuteNonQuery();
			 		MessageBox.Show("Unosenje obavljeno uspesno!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
			 		textBox3.Clear();
			 		textBox4.Clear();
			 		textBox5.Clear();
			 		}
			 		
		}
			else{
				MessageBox.Show("Morate uneti podatke za cenu i broj artikala!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
	
	
		
	}
}

 
