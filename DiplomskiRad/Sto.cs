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
using System.IO;


namespace DiplomskiRad
{
	/// <summary>
	/// Description of Sto.
	/// </summary>
	public partial class Sto : Form
	{
		//public List <int> piceID;
		public SQLiteConnection konekcija;
		public int total=0;
		public string vreme;
		private StringReader myReader;
		
		public Sto()
		{
			
			InitializeComponent();
			setKonekcija();
			ucitajDostupnaPica();
			Racun.Items.Clear();
			Racun.Items.Add("        "+DateTime.Now);
			Racun.Items.Add(System.Environment.NewLine);
			
		}
		
		protected void printDocument1_PrintPage(object sender,
          System.Drawing.Printing.PrintPageEventArgs ev)
			 {
			float linesPerPage = 0;
			float yPosition = 0;
			int count = 0;
			float leftMargin = ev.MarginBounds.Left;
			float topMargin = ev.MarginBounds.Top;
			string line = null;
			Font printFont = this.Racun.Font;
			
			SolidBrush myBrush = new SolidBrush(Color.Black);
			//Racunanje linija po strani koriscenjem MarginBounds-a
			linesPerPage =ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
			
			
			//Iteracija kroz string koriscenjem StringReader-a i ispisivanje svake linije
			while (count < linesPerPage && ((line = myReader.ReadLine()) != null)){
				//Racunanje pozicije sledece linije na osnovu sirine odgovarajuceg fonta
				yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));
				//crtanje sledece linije
				ev.Graphics.DrawString(line, printFont,
			                       myBrush, leftMargin,
			                       yPosition, new StringFormat());
				count++;
			}
			
			//ako ima vise linija ispisi ih na sledecoj strani
			if (line != null)
				ev.HasMorePages = true;
			else
				ev.HasMorePages = false;
		
			myBrush.Dispose();
		
		
		
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
						//piceID dodaj id u listu ID
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
			if(total>0){
			Racun.Items.Add(System.Environment.NewLine);
			Racun.Items.Add("Ukupno zaduzenje: "+total+".00 dinara");
			
			int dan=DateTime.Today.Day;
			int mesec=DateTime.Today.Month;
			int godina=DateTime.Today.Year;
		
			vreme=DateTime.Now.ToShortTimeString();
			
			using(SQLiteCommand izvrsi= konekcija.CreateCommand()){
				izvrsi.CommandText=@"INSERT INTO racuni(vreme,dan,mesec,godina,total) values('"+vreme+"',"+dan+","+mesec+","+godina+","+total+")";
			 		izvrsi.ExecuteNonQuery();}
			
			//MessageBox.Show("Ukupno zaduzenje stola " +
			//                "iznosi : "+total+" dinara","",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			printDialog1.Document = printDocument1;
			string strText = "";
			foreach (object x in Racun.Items){
				
				strText = strText + x + "\n";
			}
			
			myReader = new StringReader(strText);
			if (printDialog1.ShowDialog() == DialogResult.OK){
				
				this.printDocument1.Print();
			}
			
			
			
			
			
				
				
				
				
			total=0;
			Racun.Items.Clear();
			Racun.Items.Add("        "+DateTime.Now);
			Racun.Items.Add(System.Environment.NewLine);
			}
			
			else{
				MessageBox.Show("Da bi ste ispostavili racun mora postojati zaduzenje!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		void DugmeNazadClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
	}
}
