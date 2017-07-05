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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button1;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
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
			this.NomberBox.Location = new System.Drawing.Point(331, 61);
			this.NomberBox.Name = "NomberBox";
			this.NomberBox.Size = new System.Drawing.Size(158, 29);
			this.NomberBox.TabIndex = 1;
			this.NomberBox.Text = "Номер расходки";
			this.NomberBox.Enter += new System.EventHandler(this.NomberBoxEnter);
			// 
			// ProductBox
			// 
			this.ProductBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ProductBox.Location = new System.Drawing.Point(12, 127);
			this.ProductBox.Name = "ProductBox";
			this.ProductBox.Size = new System.Drawing.Size(560, 29);
			this.ProductBox.TabIndex = 2;
			this.ProductBox.Text = "Наименование товара";
			this.ProductBox.Enter += new System.EventHandler(this.ProductBoxEnter);
			// 
			// ClientBox
			// 
			this.ClientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ClientBox.Location = new System.Drawing.Point(12, 200);
			this.ClientBox.Name = "ClientBox";
			this.ClientBox.Size = new System.Drawing.Size(560, 29);
			this.ClientBox.TabIndex = 3;
			this.ClientBox.Text = "ФИО клиента";
			this.ClientBox.Enter += new System.EventHandler(this.ClientBoxEnter);
			// 
			// PhoneBox
			// 
			this.PhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PhoneBox.Location = new System.Drawing.Point(12, 274);
			this.PhoneBox.Name = "PhoneBox";
			this.PhoneBox.Size = new System.Drawing.Size(560, 29);
			this.PhoneBox.TabIndex = 4;
			this.PhoneBox.Text = "Номер телефона";
			this.PhoneBox.Enter += new System.EventHandler(this.PhoneBoxEnter);
			// 
			// AddressBox
			// 
			this.AddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddressBox.Location = new System.Drawing.Point(12, 344);
			this.AddressBox.Name = "AddressBox";
			this.AddressBox.Size = new System.Drawing.Size(560, 29);
			this.AddressBox.TabIndex = 5;
			this.AddressBox.Text = "Адрес доставки";
			this.AddressBox.Enter += new System.EventHandler(this.AddressBoxEnter);
			// 
			// GoButton
			// 
			this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.GoButton.Location = new System.Drawing.Point(365, 463);
			this.GoButton.Name = "GoButton";
			this.GoButton.Size = new System.Drawing.Size(137, 38);
			this.GoButton.TabIndex = 7;
			this.GoButton.Text = "Печать";
			this.GoButton.UseVisualStyleBackColor = true;
			this.GoButton.Click += new System.EventHandler(this.Button2Click);
			// 
			// openFile
			// 
			this.openFile.FileName = "openFileDialog1";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(75, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "Дата";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(331, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "Номер";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "Товар";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 15);
			this.label4.TabIndex = 11;
			this.label4.Text = "Клиент";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 256);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 15);
			this.label5.TabIndex = 12;
			this.label5.Text = "Телефон";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 326);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "Адрес";
			// 
			// checkBox1
			// 
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox1.Location = new System.Drawing.Point(47, 404);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(180, 32);
			this.checkBox1.TabIndex = 14;
			this.checkBox1.Text = "Наша Доставка";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.checkBox2.Location = new System.Drawing.Point(365, 399);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(155, 42);
			this.checkBox2.TabIndex = 15;
			this.checkBox2.Text = "Нужен занос";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.button1.Location = new System.Drawing.Point(47, 463);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 38);
			this.button1.TabIndex = 16;
			this.button1.Text = "Доставщик";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 527);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GoButton);
			this.Controls.Add(this.AddressBox);
			this.Controls.Add(this.PhoneBox);
			this.Controls.Add(this.ClientBox);
			this.Controls.Add(this.ProductBox);
			this.Controls.Add(this.NomberBox);
			this.Controls.Add(this.todayBox);
			this.Name = "MainForm";
			this.Text = "Dostavka";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
