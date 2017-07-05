/*
 * Created by SharpDevelop.
 * User: user
 * Date: 01.07.2017
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dostavka
{
	/// <summary>
	/// Description of ServiceForm.
	/// </summary>
	public partial class ServiceForm : Form
	{
		public ServiceForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public bool isClicked = false;
		
		void Button1Click(object sender, EventArgs e)
		{
			isClicked = true;
		}
	}
}
