/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 8/6/2018
 * Time: 11:19 AM
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
	/// Description of Sto.
	/// </summary>
	public partial class Sto : Form
	{
		public SQLiteConnection konekcija;
		public int total=0;
		
		public Sto()
		{
			
			InitializeComponent();
			setKonekcija();
			ucitajDostupnaPica();
		}
		
		void setKonekcija(){
			konekcija = new SQLiteConnection("Data Source=baza.db;Version=3");
			konekcija.Open();
	}
		
		void ucitajDostupnaPica(){
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
					komanda.CommandText = @"SELECT naziv FROM artikli WHERE broj_na_stanju>0 ";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						spisakPica.Items.Add(r.GetValue(0) + "");
						
				}
		

			}
		
		
		}
		void DugmeIsporuciClick(object sender, EventArgs e)
		{
			if(spisakPica.Text!=""){
				using(SQLiteCommand kkomanda = konekcija.CreateCommand()){
				kkomanda.CommandText = @"UPDATE artikli SET broj_na_stanju = broj_na_stanju - 1 WHERE naziv = '"+ spisakPica.Text +"'";
				SQLiteDataReader r= kkomanda.ExecuteReader();
				
			 		}
				using(SQLiteCommand komanda = konekcija.CreateCommand()){
					komanda.CommandText = @"SELECT cena FROM artikli WHERE naziv= '"+spisakPica.Text+"'";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						int cenaIzabranogPica=r.GetInt32(0);
						total+=cenaIzabranogPica;
						Racun.Items.Add(spisakPica.Text+"      "+cenaIzabranogPica+" dinara");
						spisakPica.ResetText();
				}
		
				
			}
				
				
				
				
			
			}
			
			
			
			else{
				MessageBox.Show("Morate odabrati artikal pre nego sto isporucite!","",MessageBoxButtons.OK ,MessageBoxIcon.Error);
			}
		}
		void KreirajRacunClick(object sender, EventArgs e)
		{
			MessageBox.Show("Ukupno zaduzenje stola " +
			                "iznosi : "+total+" dinara","",MessageBoxButtons.OK,MessageBoxIcon.Information);
			total=0;
			Racun.Items.Clear();
		}
		void DugmeNazadClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
