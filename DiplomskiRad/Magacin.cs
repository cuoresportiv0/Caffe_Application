﻿/*
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
			nazivArtikla();
		
		}
		
		
		void setKonekcija(){
			konekcija = new SQLiteConnection("Data Source=baza.db;Version=3");
			konekcija.Open();
	}
		void PrikazClick(object sender, EventArgs e)
		{
			SQLiteCommand comm = new SQLiteCommand("Select * From artikli", konekcija);
			using (SQLiteDataReader read = comm.ExecuteReader()){
				while (read.Read())
        {
            dataGridView1.Rows.Add(new object[] { 
            read.GetValue(1),  // U can use column index
            read.GetValue(2),  // Or column name like this
            read.GetValue(3),
             
            });
			
			
			}
		}
		
}
		void PregledClick(object sender, EventArgs e)
		{
			panelpregled.BringToFront();
		}
		void AzuriranjeClick(object sender, EventArgs e)
		{
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
			 string broj=textBox1.Text;
			 string cenaa=textBox2.Text;
			 if(broj!=""){
			 	int brojInt=int.Parse(broj);
			 	using(SQLiteCommand kkomanda = konekcija.CreateCommand()){
				kkomanda.CommandText = @"UPDATE artikli SET broj_na_stanju = broj_na_stanju +'"+brojInt+"' WHERE naziv = '"+ naziv +"'";
				SQLiteDataReader r = kkomanda.ExecuteReader();
			 }
			 }
			 	if(cenaa!=""){
			 		int cenaInt=int.Parse(cenaa);
			 		using(SQLiteCommand kom= konekcija.CreateCommand()){
			 		kom.CommandText=@"Update artikli SET cena='"+cenaInt+"'WHERE naziv = '"+ naziv +"'";
			 		SQLiteDataReader r = kom.ExecuteReader();
			 			
			 		}
			 	
			 	}
		}
	
		
	}
	}
