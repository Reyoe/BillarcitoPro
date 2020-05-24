using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BillarcitoPro
{
	public partial class AdminLoginForm : Form
	{
		private bool loged;
		private string userAdmin;
		private DataBase database;
		public AdminLoginForm()
		{
			loged = false;
			database = new DataBase();
			userAdmin = "";
			InitializeComponent();
			
		}
		//Librerias para movilizar la interfaz (libreria system.runtime.interopservices)
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		
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
		void TextBoxPasswordEnter(object sender, EventArgs e)
		{
			if(textBoxPassword.Text == "CONTRASEÑA"){
				textBoxPassword.Text = "";
				textBoxPassword.ForeColor = Color.LightGray;
				textBoxPassword.UseSystemPasswordChar = true;
			}
		}
		void TextBoxPasswordLeave(object sender, EventArgs e)
		{
			if(textBoxPassword.Text == ""){
				textBoxPassword.Text = "CONTRASEÑA";
				textBoxPassword.ForeColor = Color.DimGray;
				textBoxPassword.UseSystemPasswordChar = false;
			}
		}
		void ButtonCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void PanelTittleMouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
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
			if(!database.VerifyLoginAdmin(textBoxUser.Text, textBoxPassword.Text)){
				labelError.Text = "Usuario o contraseña incorrectos. Por favor, ingrese valores válidos.";
				labelError.Visible = true;
				return;
			}
			
			loged = true;
			userAdmin = textBoxUser.Text;
			this.Close();
		}
		public bool HasLoged()
		{
			return loged;
		}
		public string GetUserAdmin()
		{
			return userAdmin;
		}

	}
}
