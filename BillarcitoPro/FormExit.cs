using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillarcitoPro
{
	/// <summary>
	/// Description of FormExit.
	/// </summary>
	public partial class FormExit : Form
	{
		bool letsclose;
		public FormExit()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			letsclose = false;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonCloseClick(object sender, EventArgs e)
		{
			letsclose = true;
			this.Close();
		}
		void ButtonCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		public bool DDialogResult()
		{
			return letsclose;
		}
	}
}
