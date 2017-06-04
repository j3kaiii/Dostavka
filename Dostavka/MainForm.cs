/*
 * Created by SharpDevelop.
 * User: user
 * Date: 03.06.2017
 * Time: 11:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Dostavka
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private String pathFile;
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
		void Button1Click(object sender, EventArgs e)
		{
			if(whereIsTheFile.ShowDialog() == DialogResult.OK)
			{
				pathFile = whereIsTheFile.SelectedPath;
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
