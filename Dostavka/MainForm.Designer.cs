/*
 * Created by SharpDevelop.
 * User: user
 * Date: 03.06.2017
 * Time: 11:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Dostavka
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox todayBox;
		private System.Windows.Forms.TextBox NomberBox;
		private System.Windows.Forms.TextBox ProductBox;
		private System.Windows.Forms.TextBox ClientBox;
		private System.Windows.Forms.TextBox PhoneBox;
		private System.Windows.Forms.TextBox AddressBox;
		private System.Windows.Forms.Button GoButton;
		private System.Windows.Forms.FolderBrowserDialog whereIsTheFile;
		private System.Windows.Forms.SaveFileDialog saveDialog;
		private System.Windows.Forms.OpenFileDialog openFile;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.todayBox = new System.Windows.Forms.TextBox();
			this.NomberBox = new System.Windows.Forms.TextBox();
			this.ProductBox = new System.Windows.Forms.TextBox();
			this.ClientBox = new System.Windows.Forms.TextBox();
			this.PhoneBox = new System.Windows.Forms.TextBox();
			this.AddressBox = new System.Windows.Forms.TextBox();
			this.GoButton = new System.Windows.Forms.Button();
			this.whereIsTheFile = new System.Windows.Forms.FolderBrowserDialog();
			this.saveDialog = new System.Windows.Forms.SaveFileDialog();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// todayBox
			// 
			this.todayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.todayBox.Location = new System.Drawing.Point(75, 61);
			this.todayBox.Name = "todayBox";
			this.todayBox.Size = new System.Drawing.Size(152, 29);
			this.todayBox.TabIndex = 0;
			this.todayBox.Text = "Дата доставки";
			// 
			// NomberBox
			// 
			this.NomberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NomberBox.Location = new System.Drawing.Point(259, 61);
			this.NomberBox.Name = "NomberBox";
			this.NomberBox.Size = new System.Drawing.Size(158, 29);
			this.NomberBox.TabIndex = 1;
			this.NomberBox.Text = "Номер расходки";
			this.NomberBox.Enter += new System.EventHandler(this.NomberBoxEnter);
			// 
			// ProductBox
			// 
			this.ProductBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ProductBox.Location = new System.Drawing.Point(12, 107);
			this.ProductBox.Name = "ProductBox";
			this.ProductBox.Size = new System.Drawing.Size(461, 29);
			this.ProductBox.TabIndex = 2;
			this.ProductBox.Text = "Наименование товара";
			this.ProductBox.Enter += new System.EventHandler(this.ProductBoxEnter);
			// 
			// ClientBox
			// 
			this.ClientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ClientBox.Location = new System.Drawing.Point(12, 156);
			this.ClientBox.Name = "ClientBox";
			this.ClientBox.Size = new System.Drawing.Size(461, 29);
			this.ClientBox.TabIndex = 3;
			this.ClientBox.Text = "ФИО клиента";
			this.ClientBox.Enter += new System.EventHandler(this.ClientBoxEnter);
			// 
			// PhoneBox
			// 
			this.PhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PhoneBox.Location = new System.Drawing.Point(12, 204);
			this.PhoneBox.Name = "PhoneBox";
			this.PhoneBox.Size = new System.Drawing.Size(461, 29);
			this.PhoneBox.TabIndex = 4;
			this.PhoneBox.Text = "Номер телефона";
			this.PhoneBox.Enter += new System.EventHandler(this.PhoneBoxEnter);
			// 
			// AddressBox
			// 
			this.AddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddressBox.Location = new System.Drawing.Point(12, 258);
			this.AddressBox.Name = "AddressBox";
			this.AddressBox.Size = new System.Drawing.Size(461, 29);
			this.AddressBox.TabIndex = 5;
			this.AddressBox.Text = "Адрес доставки";
			this.AddressBox.Enter += new System.EventHandler(this.AddressBoxEnter);
			// 
			// GoButton
			// 
			this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GoButton.Location = new System.Drawing.Point(194, 308);
			this.GoButton.Name = "GoButton";
			this.GoButton.Size = new System.Drawing.Size(85, 38);
			this.GoButton.TabIndex = 7;
			this.GoButton.Text = "Печать";
			this.GoButton.UseVisualStyleBackColor = true;
			this.GoButton.Click += new System.EventHandler(this.Button2Click);
			// 
			// openFile
			// 
			this.openFile.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 364);
			this.Controls.Add(this.GoButton);
			this.Controls.Add(this.AddressBox);
			this.Controls.Add(this.PhoneBox);
			this.Controls.Add(this.ClientBox);
			this.Controls.Add(this.ProductBox);
			this.Controls.Add(this.NomberBox);
			this.Controls.Add(this.todayBox);
			this.Name = "MainForm";
			this.Text = "Dostavka";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
