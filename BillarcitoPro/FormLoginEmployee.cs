using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BillarcitoPro
{
	public partial class FormLoginEmployee : Form
	{
		private DataBase database;
		private bool loged;
		public FormLoginEmployee()
		{
			loged = false;
			database = new DataBase();
			InitializeComponent();
			
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
		void TextBoxUserEnter(object sender, EventArgs e)
		{
			if(textBoxUser.Text == "USUARIO"){
				textBoxUser.Text = "";
				textBoxUser.ForeColor = Color.LightGray;
			}
		}
		void TextBoxUserLeave(object sender, EventArgs e)
		{
			if(textBoxUser.Text == ""){
				textBoxUser.Text = "USUARIO";
				textBoxUser.ForeColor = Color.DimGray;
			}
		}
		void ButtonLOGINClick(object sender, EventArgs e)
		{
			if(textBoxUser.Text == "USUARIO"){
				labelError.Text = "Por favor, ingrese un usuario.";
				labelError.Visible = true;
				return;
			}
			if(textBoxPassword.Text == "CONTRASEÑA"){
				labelError.Text = "Por favor, ingrese una contraseña.";
				labelError.Visible = true;
				return;
			}
			//verificar en bd que el usuario y contraseña sean validos
			if(!database.VerifyLogin(textBoxUser.Text, textBoxPassword.Text)){
				labelError.Text = "Usuario o contraseña incorrectos. Por favor, ingrese valores válidos.";
				labelError.Visible = true;
				return;
			}
			
			loged = true;
			this.Close();
		}
		public bool HasLoged()
		{
			return loged;
		}
		void TextBoxPasswordEnter(object sender, EventArgs e)
		{
			if (textBoxPassword.Text == "CONTRASEÑA") {
				textBoxPassword.Text = "";
				textBoxPassword.ForeColor = Color.LightGray;
				textBoxPassword.UseSystemPasswordChar = true;
			}
		}
		void TextBoxPasswordLeave(object sender, EventArgs e)
		{
			if (textBoxPassword.Text == "") {
				textBoxPassword.Text = "CONTRASEÑA";
				textBoxPassword.ForeColor = Color.LightGray;
				textBoxPassword.UseSystemPasswordChar = false;
			}
		}
		public string GetUserEmployee()
		{
			return textBoxUser.Text;
		}
		public string GetPassEmployee()
		{
			return textBoxPassword.Text;
		}
		public void SetLoged()
		{
			loged = true;
		}
		public void setUserEmployee(string user)
		{
			textBoxUser.Text = user;
		}

		private void labelError_Click(object sender, EventArgs e)
		{

		}
	}
}
