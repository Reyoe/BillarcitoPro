﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillarcitoPro
{
	/// <summary>
	/// Description of FormMessage.
	/// </summary>
	public partial class FormMessage : Form
	{
		string tittle;
		public FormMessage(int index)
		{
			
			InitializeComponent();
			tittle = "Limite en la Mesa " + index.ToString();
			labelTittle.Text = tittle;
            if (index == 1)
            {
				aqua.Visible = true;
				kuro.Visible = false;
				violet.Visible = false;
				Asuna.Visible = false;
				bocchi.Visible = false;
				rem.Visible = false;
				yui.Visible = false;
				taiga.Visible = false;
			}
			if (index == 2)
			{
				aqua.Visible = false;
				kuro.Visible = true;
				violet.Visible = false;
				Asuna.Visible = false;
				bocchi.Visible = false;
				rem.Visible = false;
				yui.Visible = false;
				taiga.Visible = false;
			}
			if (index == 3)
			{
				aqua.Visible = false;
				kuro.Visible = false;
				violet.Visible = true;
				Asuna.Visible= false;
				bocchi.Visible = false;
				rem.Visible = false;
				yui.Visible = false;
				taiga.Visible = false;
			}
			if (index == 4)
			{
				aqua.Visible = false;
				kuro.Visible = false;
				violet.Visible = false;
				Asuna.Visible = true;
				bocchi.Visible = false;
				rem.Visible = false;
				yui.Visible = false;
				taiga.Visible = false;
			}
			if (index == 5)
			{
				aqua.Visible = false;
				kuro.Visible = false;
				violet.Visible = false;
				Asuna.Visible = false;
				bocchi.Visible = true;
				rem.Visible = false;
				yui.Visible = false;
				taiga.Visible = false;
			}
			if (index == 6)
			{
				aqua.Visible = false;
				kuro.Visible = false;
				violet.Visible = false;
				Asuna.Visible = false;
				bocchi.Visible = false;
				rem.Visible = true;
				yui.Visible = false;
				taiga.Visible = false;
			}
			if (index == 7)
			{
				aqua.Visible = false;
				kuro.Visible = false;
				violet.Visible = false;
				Asuna.Visible = false;
				bocchi.Visible = false;
				rem.Visible = false;
				yui.Visible = true;
				taiga.Visible = false;
			}
			if (index == 8)
			{
				aqua.Visible = false;
				kuro.Visible = false;
				violet.Visible = false;
				Asuna.Visible = false;
				bocchi.Visible = false;
				rem.Visible = false;
				yui.Visible = false;
				taiga.Visible = true;
			}
		}
		void ButtonAcceptClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void FormMessage_Load(object sender, EventArgs e)
		{

		}
	}
}
