/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 23/11/2019
 * Time: 01:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BillarcitoPro
{
	/// <summary>
	/// Description of FormTablesAdmin.
	/// </summary>
	public partial class FormTablesAdmin : Form
	{
		DataBase database;
		public FormTablesAdmin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			database = new DataBase();
			ShowRegisters();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//Librerias para movilizar la interfaz (libreria system.runtime.interopservices)
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		
		void ButtonCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void PanelTittleMouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		void ShowRegisters()
		{
		   dataGridView1.DataSource = database.Show("rentamesas");
		}
		void ButtonDeleteAllClick(object sender, EventArgs e)
		{
			database.DeleteEverything("rentamesas");
			ShowRegisters();
		}
		void ButtonDeleteRegClick(object sender, EventArgs e)
		{
			if(dataGridView1.SelectedRows.Count > 0){
				labelError.Visible = false;
				database.DeleteInt(int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString()), "rentamesas");
				ShowRegisters();
				return;
			}
			labelError.Text = "Error. Por favor, seleccione por completo un registro en la tabla.";
			labelError.Visible = true;
		}
	}
}
