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

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
