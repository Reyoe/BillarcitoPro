/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 23/11/2019
 * Time: 10:51 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
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
		}
		void ButtonAcceptClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
