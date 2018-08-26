/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 8/25/2018
 * Time: 3:50 PM
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
	/// Description of Izvestaj.
	/// </summary>
	public partial class Izvestaj : Form
	{
		SQLiteConnection konekcija;
		
		
		
	
		public Izvestaj()
		{
			
			InitializeComponent();
			setKonekcija();
			ispisiMesece();
			
		}
		
		
		void setKonekcija(){
			konekcija = new SQLiteConnection("Data Source=baza.db;Version=3");
			konekcija.Open();
	}
		
		
		public void ispisiMesece(){
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
					komanda.CommandText = @"SELECT DISTINCT mesec From racuni";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						odabirMeseca.Items.Add(r.GetValue(0)+"");
						
		
						
		}
		
			}
		}
		public void ispisiDane(){
			odabirDana.Items.Clear();
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
				
					komanda.CommandText = @"SELECT distinct dan From racuni WHERE mesec = "+odabirMeseca.Text+"";
			
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						odabirDana.Items.Add(r.GetValue(0)+"");
						
		
	
						
		
					}
		
			}
		}
		
		public void ukupanPrihodMesec(){
			prihodMesec.Items.Clear();
			
			using(SQLiteCommand koman = konekcija.CreateCommand()){
				koman.CommandText = @"SELECT sum(total) FROM racuni WHERE mesec = "+odabirMeseca.Text+"";
				SQLiteDataReader rr = koman.ExecuteReader();
				while(rr.Read()){
					
					prihodMesec.Items.Add(rr.GetValue(0)+".00 dinara");
				
				}
				
			}
			}
			
			public void ukupanPrihodDan(){
			prihodDan.Items.Clear();
			
			using(SQLiteCommand koma = konekcija.CreateCommand()){
				koma.CommandText = @"SELECT sum(total) FROM racuni WHERE mesec = "+odabirMeseca.Text+" AND dan = "+odabirDana.Text+"";
				SQLiteDataReader rr = koma.ExecuteReader();
				while(rr.Read()){
					
					prihodDan.Items.Add(rr.GetValue(0)+".00 dinara");
				
				}
				
			}
			}
		
		
		
		void popuniGridMesec(){
			grid.Rows.Clear();
			grid.Refresh();
			using (SQLiteCommand comm = new SQLiteCommand("SELECT dan , mesec , godina , vreme , total FROM racuni WHERE mesec = "+odabirMeseca.Text+"", konekcija)) {
				using (SQLiteDataReader read = comm.ExecuteReader()) {
					while (read.Read()) {
						grid.Rows.Add(new object[] {
							read.GetValue(0),
							
							read.GetValue(1),
							
							read.GetValue(2),
							
							read.GetValue(3),
							
							read.GetValue(4),
						});
					}
				}
			
		
		
		
			}
		}
		
		
		void popuniGridDan(){
			grid.Rows.Clear();
			grid.Refresh();
			using (SQLiteCommand comm = new SQLiteCommand("SELECT dan , mesec , godina , vreme , total FROM racuni WHERE mesec = "+odabirMeseca.Text+" AND dan = "+odabirDana.Text+"", konekcija)) {
				using (SQLiteDataReader read = comm.ExecuteReader()) {
					while (read.Read()) {
						grid.Rows.Add(new object[] {
							read.GetValue(0),
							
							read.GetValue(1),
							
							read.GetValue(2),
							
							read.GetValue(3),
							
							read.GetValue(4),
						});
					}
				}
			
		
		
		
			}
		}
			
		
		
		
		
	
		
		
		
		void OdabirMesecaSelectedIndexChanged(object sender, EventArgs e)
		{
			
			ispisiDane();
			ukupanPrihodMesec();
			popuniGridMesec();
		}
		void OdabirDanaSelectedIndexChanged(object sender, EventArgs e)
		{
			ukupanPrihodDan();
			popuniGridDan();
		}
		void DugmeNazadClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
		
		}
	}

