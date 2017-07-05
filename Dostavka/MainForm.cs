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
using Word = Microsoft.Office.Interop.Word;
using System.Xml;

using System.Reflection;

namespace Dostavka
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private String pathFile = "";
		private String pathCfg = "config.txt";
		//private String currDir;
		DialogForm df = new DialogForm();
		ServiceForm sf = new ServiceForm();
		
		
		
		private static Excel.Workbook MyBook = null;
		private static Excel.Application MyApp = null;
		private static Excel.Worksheet MySheet = null;
		private Excel.Range MyCells;
		
		private static Word._Application MyWord = null;
		private static Object MyFile = null;
		private static Word._Document MyDoc = null;
		private int lastRow = 0;
		Dictionary<string, int> dic = new Dictionary<string, int>();
		
		private string address = "";
		private string man = "none";
		public int targetRow = 1;
		
		//private Boolean isNewFile = false;
		//private int summa;
		
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
			while(!File.Exists(pathCfg))
			{
				if(openFile.ShowDialog() == DialogResult.OK)
				{
					pathFile = openFile.FileName;
				}
				
				if (!pathFile.Equals(""))
				{
					using (StreamWriter sw = File.CreateText(pathCfg))
					{
						sw.WriteLine(pathFile);
									
					}
				}
				else
				{
					df.ShowDialog();
					
					if (df.DialogResult == DialogResult.Cancel)
					{
						Environment.Exit(0);
						
					}
				}
				//isNewFile = true;
			}
			
			/*----- получаем из конфига путь файла exel -----------*/
			using (StreamReader sr = File.OpenText(pathCfg))
			{
				pathFile = sr.ReadLine();
			}
			
			/*------- ставим дату по умолчанию - текущая ----------*/
			todayBox.Text = DateTime.Today.ToShortDateString();
			
			/*----подключаем exel-------*/
			MyApp = new Excel.Application();
			MyApp.Visible = false;
			MyBook = MyApp.Workbooks.Open(pathFile);
			if (checkBox1.Checked) MySheet = (Excel.Worksheet)MyBook.Sheets[1];
			else MySheet = (Excel.Worksheet)MyBook.Sheets[2];
			lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
			
			/*-------подключаем word-----------*/
			MyWord = new Word.Application();
			MyFile = Environment.CurrentDirectory + "\\talon.dotx";
			
			MyWord.Visible = false;
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			writeToExcel();
			
			writeToWardAndPrint();
						
			Environment.Exit(0);
			
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
		
		void Button1Click(object sender, EventArgs e)
		{
			getUserList();
			
			getAddressList();
			
			sf.ShowDialog();
						
			if (sf.DialogResult == DialogResult.OK)
			{
				putInfoToDialogForm();
				MySheet.Cells[targetRow, "H"] = man;//заносим фамилию в excel по номеру строки
				//address = null;
				//man = null;
				//sf.Close();
				MyBook.Save();
			}
			
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			MyWord.Quit();
			MyApp.Quit();
		}
		
		private void getAddressList()
		{
			String marker = "";
			String dateValue = "";
			String addressValue = "";
			
			for (int i = 1; i <= lastRow; i++)
			{
				marker = (string)(MySheet.Cells[i, "H"] as Excel.Range).Value;
				dateValue = (string)(MySheet.Cells[i, "A"] as Excel.Range).Value;
				addressValue = (string)(MySheet.Cells[i, "F"] as Excel.Range).Value;
				
				if(marker == "+") 
				{
					sf.dateList.Items.Add(dateValue + " : " + addressValue);
					dic.Add(addressValue, i);
				}
			}
		}
		
		private void getUserList()
		{
			XmlDocument xDoc = new XmlDocument();
			xDoc.Load("users.xml");
			XmlElement root = xDoc.DocumentElement;
			
			foreach(XmlNode names in root)
			{
				XmlNode attr = names.Attributes.GetNamedItem("name");
				if(attr != null)
				{
					sf.userList.Items.Add(attr.Value);
				}
			}
		}
		
		private void putInfoToDialogForm()
		{
			Console.WriteLine("address = " + address + " : " + "targetRow = " + targetRow);
			address = sf.dateList.SelectedItem.ToString();//берем значение адреса из чекбокса
			foreach(KeyValuePair<string, int> keyValue in dic)//ищем соответствие в словаре
			{
				if (keyValue.Value.ToString() == address)//по соответсвию находим номер строки в excel
						targetRow = int.Parse(keyValue.Key);
			}
				
			man = sf.userList.SelectedItem.ToString();//берем фамилию из второго чекбокса
		}
		
		private void writeToExcel()
		{
			/*----  находим последнюю запись  ----*/
			
			/*сравниваем последнюю дату в таблице с датой этого дня*/
			
			int newRow = lastRow + 1;
			/*----  рисуем границы  ----*/
			MyCells = MySheet.get_Range("A" + newRow, "G" + newRow);
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
			MySheet.Cells[newRow, "G"] = "250";
			if (checkBox2.Checked) MySheet.Cells[newRow, "H"] = "+";
			
			MyBook.Save();
			
		}
		
		private void writeToWardAndPrint()
		{
			/*-----------  заполняем талон для печати  -----------*/
			/*--  талон автоматом сохранится в папку с прогой   --*/
			/*-------  старый файл при наличии перепишется  ------*/
			MyDoc = MyWord.Documents.Add(ref MyFile);
			MyDoc.Bookmarks["date"].Range.Text = todayBox.Text;
			MyDoc.Bookmarks["nomer"].Range.Text = NomberBox.Text;
			MyDoc.Bookmarks["product"].Range.Text = ProductBox.Text;
			MyDoc.Bookmarks["client"].Range.Text = ClientBox.Text;
			MyDoc.Bookmarks["phone"].Range.Text = PhoneBox.Text;
			MyDoc.Bookmarks["address"].Range.Text = AddressBox.Text;
			MyDoc.SaveAs(FileName: Environment.CurrentDirectory + "\\for_print.docx");
			
			/*------  печатаем документ  -------*/
			object copies = "1";
			object pages = "1";
			object range = Word.WdPrintOutRange.wdPrintCurrentPage;
			object items = Word.WdPrintOutItem.wdPrintDocumentContent;
			object pageType = Word.WdPrintOutPages.wdPrintAllPages;
			object oTrue = true;
			object oFalse = false;
			object missing = Type.Missing;
			/*MyDoc.PrintOut(ref oTrue, ref oFalse,ref range, ref missing, ref missing, ref missing,
			               ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
							ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);*/
			object doNotSave = Word.WdSaveOptions.wdDoNotSaveChanges;
			MyDoc.Close(ref doNotSave, ref missing, ref missing);
			MyWord.Quit();
		}
	}
}
