﻿/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 8/4/2018
 * Time: 11:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace DiplomskiRad
{
	/// <summary>
	/// Description of Lokal.
	/// </summary>
	public partial class Lokal : Form
	{
		Timer t=new Timer();
		public SQLiteConnection konekcija;
		public Lokal()
		{
			
			InitializeComponent();
			setKonekcija();
			ispisiRadnike();
			
			
		}
		
		public void ispisiRadnike(){
			using(SQLiteCommand komanda = konekcija.CreateCommand()){
					komanda.CommandText = @"SELECT ime_prezime From radnici";
					SQLiteDataReader r = komanda.ExecuteReader();
					while(r.Read()){
						spisakRadnika.Items.Add(r.GetValue(0) + "");
		
		
		}
			}
		}
		
		void setKonekcija(){
			konekcija = new SQLiteConnection("Data Source=baza.db;Version=3");
			konekcija.Open();
		
		}
		void LokalLoad(object sender, EventArgs e)
		{
			t.Interval=1000;
			// disable once RedundantDelegateCreation
			t.Tick += new EventHandler(this.tTick);
			t.Start();
		}
		
		private void tTick(object sender,EventArgs e){
			int hh= DateTime.Now.Hour;
			int mm=DateTime.Now.Minute;
			int ss=DateTime.Now.Second;
			
			string time="";
			
			if(hh<10){ time+="0"+hh;}
			else{time+=hh;}
			time+=":";
			if(mm<10){time+="0"+mm;}
			else{time+=mm;}
			time+=":";
			if(ss<10){time+="0"+ss;}
			else{time+=ss;}
			label1.Text=time;
		
		}
		void DugmeNazadClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void StoPrviClick(object sender, EventArgs e)
		{
			Sto sto1=new Sto();
			sto1.ShowDialog();
		}
		void StoDrugiClick(object sender, EventArgs e)
		{
			Sto sto2=new Sto();
			sto2.ShowDialog();
		}
		void StoTreciClick(object sender, EventArgs e)
		{
			Sto sto3=new Sto();
			sto3.ShowDialog();
		}
		void StoCetvrtiClick(object sender, EventArgs e)
		{
			Sto sto4=new Sto();
			sto4.ShowDialog();
	
		}
		void StoPetiClick(object sender, EventArgs e)
		{
			Sto sto5=new Sto();
			sto5.ShowDialog();
		}
		void StoSestiClick(object sender, EventArgs e)
		{
			Sto sto6=new Sto();
			sto6.ShowDialog();
	
		}
		void StoSedmiClick(object sender, EventArgs e)
		{
			Sto sto7=new Sto();
			sto7.ShowDialog();
	
		}
		void StoOsmiClick(object sender, EventArgs e)
		{
			Sto sto8=new Sto();
			sto8.ShowDialog();
		}
		

	}
}
