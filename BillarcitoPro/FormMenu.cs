using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BillarcitoPro
{
	public partial class Menu : Form
	{
		private bool statusAdmin;
		private string userAdmin;
		private DataBase database;
		List<Table> tables;
		public Menu()
		{

			InitializeComponent();
			statusAdmin = false;
			userAdmin = "";
			database = new DataBase();
			
			tables = new List<Table>();
			for (int i = 1; i <= database.GetNumTables(); i++) {
				var table = new Table(i);
				tables.Add(table);
			}
			
		}
		
		//Librerias para movilizar la interfaz (libreria system.runtime.interopservices)
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		
		void ButtonCloseClick(object sender, EventArgs e)
		{
			int iterator = 0;
			bool flag = true;
			
			while(iterator < tables.Count){
				if (!tables[iterator].IsAvailable()) {
					flag = false;
					break;
				}
				iterator++;
			}
			if (flag) {
				this.Close();	
			}
			
			var fe = new FormExit();
			fe.ShowDialog();
			
			if (fe.DDialogResult()) {
				this.Close();
			}
		}
		void ButtonMaximizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			buttonMaximize.Visible = false;
			buttonRestore.Visible = true;
		}
		void ButtonRestoreClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			buttonRestore.Visible = false;
			buttonMaximize.Visible = true;
		}
		void ButtonMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void PanelTittleMouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		
		private void OpenSubForm(object subform)
		{
			if (this.panelContainer.Controls.Count > 0) {
				this.panelContainer.Controls.RemoveAt(0);
			}
			
			var sf = subform as Form;
			sf.TopLevel = false;
			sf.Dock = DockStyle.Fill;
			this.panelContainer.Controls.Add(sf);
			this.panelContainer.Tag = sf;
			sf.Show();
		}
		void ButtonTablesClick(object sender, EventArgs e)
		{
			OpenSubForm(new TablesForm(statusAdmin, ref tables, userAdmin));
		}
		void ButtonAdminClick(object sender, EventArgs e)
		{
			var alf = new AdminLoginForm();
			alf.ShowDialog();
			statusAdmin = alf.HasLoged();
			if (statusAdmin) {
				userAdmin = alf.GetUserAdmin();
				panelProducts.Visible = true;
				buttonProducts.Visible = true;
				panelEmployees.Visible = true;
				buttonEmployees.Visible = true;
				
				buttonAdmin.Visible = false;
				buttonLogoutAdmin.Visible = true;
				OpenSubForm(new TablesForm(statusAdmin, ref tables, userAdmin));
			}
		}
		void ButtonProductsClick(object sender, EventArgs e)
		{
			OpenSubForm(new FormProducts());
		}
		void ButtonSalesClick(object sender, EventArgs e)
		{
			OpenSubForm(new FormSales(statusAdmin, userAdmin));
		}
		void ButtonPricesClick(object sender, EventArgs e)
		{
			OpenSubForm(new FormCatalogPrices(statusAdmin));
		}
		void ButtonClientsClick(object sender, EventArgs e)
		{
			OpenSubForm(new FormClients(statusAdmin));
		}
		void ButtonEmployeesClick(object sender, EventArgs e)
		{
			OpenSubForm(new FormEmployees());
		}
		void ButtonLogoutAdminClick(object sender, EventArgs e)
		{
			statusAdmin = false;
			userAdmin = "";
			panelProducts.Visible = false;
			buttonProducts.Visible = false;
			panelEmployees.Visible = false;
			buttonEmployees.Visible = false;
			
			buttonAdmin.Visible = true;
			buttonLogoutAdmin.Visible = false;
			OpenSubForm(new TablesForm(statusAdmin, ref tables, userAdmin));
		}
		void MenuLoad(object sender, EventArgs e)
		{
			OpenSubForm(new TablesForm(statusAdmin, ref tables, userAdmin));
		}
		void Button1Click(object sender, EventArgs e)//button discounts
		{
			OpenSubForm(new FormDiscounts(statusAdmin));
		}
		void TimerTablesTick(object sender, EventArgs e)
		{
			for (int i = 0; i < tables.Count; i++) {
				if(!tables[i].IsAvailable()){
					if (tables[i].CalculateTimeRemaining() == "00:00:00") {
						if(!tables[i].IsFinished()){
							tables[i].SetFinished();
							var fm = new FormMessage(i+1);
							fm.ShowDialog();	
						}
					}
				}
			}
		}
	}
}
