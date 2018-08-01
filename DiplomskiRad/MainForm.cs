/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 7/23/2018
 * Time: 3:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DiplomskiRad{
	
	public partial class MainForm : Form
	{
		public SQLiteConnection konekcija;
		
		public MainForm()
		{
			
			InitializeComponent();
			setKonekcija();
			
		
		}
		
		
		void setKonekcija(){
			konekcija = new SQLiteConnection("Data Source=baza.db;Version=3");
			konekcija.Open();
		}
		void MagacindugmeClick(object sender, EventArgs e)
		{
			Magacin magacin = new Magacin();
			magacin.ShowDialog();
		}
	}

}