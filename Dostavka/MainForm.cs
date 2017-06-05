/*
 * Created by SharpDevelop.
 * User: user
 * Date: 03.06.2017
 * Time: 11:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Dostavka
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private String pathFile;
		private String pathCfg = "config.txt";
		
		private static Excel.Workbook MyBook = null;
		private static Excel.Application MyApp = null;
		private static Excel.Worksheet MySheet = null;
		private Excel.Range MyCells;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			/*---- создаем конфиг при первом запуске и выбираем папку для Exel ---*/
			if(!File.Exists(pathCfg))
			{
				if(openFile.ShowDialog() == DialogResult.OK)
				{
					pathFile = openFile.FileName;
				}
				using (StreamWriter sw = File.CreateText(pathCfg))
				{
					sw.WriteLine(pathFile);
				}
			}
			/*----- получаем из конфига путь файла exel -----------*/
			using (StreamReader sr = File.OpenText(pathCfg))
			{
				pathFile = sr.ReadLine();
			}
			/*------- ставим дату по умолчанию - текущая ----------*/
			todayBox.Text = DateTime.Today.ToShortDateString();
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			MyApp = new Excel.Application();
			MyApp.Visible = false;
			MyBook = MyApp.Workbooks.Open(pathFile);
			MySheet = (Excel.Worksheet)MyBook.Sheets[1];
			int lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
			int newRow = lastRow + 1;
			/*----  рисуем границы  ----*/
			MyCells = MySheet.get_Range("A" + newRow, "F" + newRow);
			MyCells.Borders.ColorIndex = 1;
			MyCells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
			MyCells.Borders.Weight = Excel.XlBorderWeight.xlMedium;
			MyCells.Font.Size = 14;
			MyCells.Font.Bold = true;
			/*--  заполняем excel из полей программы  --*/
			MySheet.Cells[newRow, "A"] = todayBox.Text;
			MySheet.Cells[newRow, "B"] = NomberBox.Text;
			MySheet.Cells[newRow, "C"] = ProductBox.Text;
			MySheet.Cells[newRow, "D"] = ClientBox.Text;
			MySheet.Cells[newRow, "E"] = PhoneBox.Text;
			MySheet.Cells[newRow, "F"] = AddressBox.Text;
			
			MyBook.Save();
			MyApp.Quit();
		}
		void NomberBoxEnter(object sender, EventArgs e)
		{
			NomberBox.Text = "";
		}
		void ProductBoxEnter(object sender, EventArgs e)
		{
			ProductBox.Text = "";
		}
		void ClientBoxEnter(object sender, EventArgs e)
		{
			ClientBox.Text = "";
		}
		void PhoneBoxEnter(object sender, EventArgs e)
		{	
			PhoneBox.Text = "";
		}
		void AddressBoxEnter(object sender, EventArgs e)
		{
			AddressBox.Text = "";
		}
		
	}
}
