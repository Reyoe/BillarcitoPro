using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillarcitoPro
{
	/// <summary>
	/// Description of FormClients.
	/// </summary>
	///
	public partial class FormClients : Form
	{
		DataBase database;
		private bool edit;
		private string userClient;
		private int horastotales,horasdescuento;
		public FormClients(bool statusAdmin)
		{
			
			InitializeComponent();
			edit = false;
			database = new DataBase();
			ShowClients();
			buttonEditClient.Visible |= statusAdmin;
			buttonDeleteClient.Visible |= statusAdmin;
		}
		void TextBoxClientNameEnter(object sender, EventArgs e)
		{
			if (textBoxClientName.Text == "NOMBRE(S)") {
				textBoxClientName.Text = "";
				textBoxClientName.ForeColor = Color.LightGray;
			}
		}
		void TextBoxClientNameLeave(object sender, EventArgs e)
		{
			if (textBoxClientName.Text == "") {
				textBoxClientName.Text = "NOMBRE(S)";
				textBoxClientName.ForeColor = Color.DimGray;
			}
		}
		void TextBoxClientLNameEnter(object sender, EventArgs e)
		{
			if (textBoxClientLName.Text == "APELLIDO(S)") {
				textBoxClientLName.Text = "";
				textBoxClientLName.ForeColor = Color.LightGray;
			}
		}
		void TextBoxClientLNameLeave(object sender, EventArgs e)
		{
			if (textBoxClientLName.Text == "") {
				textBoxClientLName.Text = "APELLIDO(S)";
				textBoxClientLName.ForeColor = Color.DimGray;
			}
		}
		void TextBoxClientUserEnter(object sender, EventArgs e)
		{
			if (textBoxClientUser.Text == "USUARIO/CLAVE DEL CLIENTE") {
				textBoxClientUser.Text = "";
				textBoxClientUser.ForeColor = Color.LightGray;
			}
		}
		void TextBoxClientUserLeave(object sender, EventArgs e)
		{
			if(textBoxClientUser.Text == ""){
				textBoxClientUser.Text = "USUARIO/CLAVE DEL CLIENTE";
				textBoxClientUser.ForeColor = Color.DimGray;
			}
		}
		void ClearFormElements()
		{
			textBoxClientName.Text = "NOMBRE(S)";
			textBoxClientLName.Text = "APELLIDO(S)";
			textBoxClientUser.Text = "USUARIO/CLAVE DEL CLIENTE";
			textBoxClientUser.ForeColor = Color.DimGray;
			textBoxClientName.ForeColor = Color.DimGray;
			textBoxClientLName.ForeColor = Color.DimGray;
		}
		void ShowClients()
		{
			dataGridViewClients.DataSource = database.Show("clientes");
		}
		void ButtonSaveClientClick(object sender, EventArgs e)
		{
			if(edit){
				EditClient();
			}
			else{
				SaveClient();
			}
		}
		void EditClient()
		{
			if(userClient != textBoxClientUser.Text){
				if(database.VerifyExistenceString(textBoxClientUser.Text, "CLAVE", "clientes")){
					labelError.Text = "Error. Por favor, ingrese un usuario distinto.";
					labelError.Visible = true;
					return;
				}
			}
			labelError.Visible = false;
			database.EditClient(userClient,textBoxClientUser.Text, textBoxClientName.Text, textBoxClientLName.Text, horastotales, horasdescuento);
			ClearFormElements();
			ShowClients();
			edit = false;
		}
		
		void SaveClient()
		{
			if(database.VerifyExistenceString(textBoxClientUser.Text, "CLAVE", "clientes")){
				labelError.Text = "Error. Ya existe un cliente con el usuario ingresado .Por favor, ingrese un cliente con un usuario distinto.";
				labelError.Visible = true;
				return;
			}
			labelError.Visible = false;
			database.InsertClient(textBoxClientUser.Text, textBoxClientName.Text, textBoxClientLName.Text, 0, 0);
			ClearFormElements();
			ShowClients();
		}
		void ButtonEditClientClick(object sender, EventArgs e)
		{
			if(dataGridViewClients.SelectedRows.Count > 0){
				textBoxClientUser.Text = dataGridViewClients.CurrentRow.Cells["CLAVE"].Value.ToString();
				textBoxClientName.Text = dataGridViewClients.CurrentRow.Cells["NOMBRE"].Value.ToString();
				textBoxClientLName.Text = dataGridViewClients.CurrentRow.Cells["APELLIDO"].Value.ToString();
				edit = true;
				labelError.Visible = false;
				userClient = textBoxClientUser.Text;
				horastotales = int.Parse( dataGridViewClients.CurrentRow.Cells["HORAS_TOTALES"].Value.ToString());
				horasdescuento = int.Parse( dataGridViewClients.CurrentRow.Cells["HORAS_DESCUENTOS"].Value.ToString());
				return;
			}
			labelError.Text = "Error. Por favor, seleccione por completo un registro en la tabla.";
			labelError.Visible = true;
		}
		void ButtonDeleteClientClick(object sender, EventArgs e)
		{
			if(dataGridViewClients.SelectedRows.Count > 0){
				labelError.Visible = false;
				database.DeleteString(dataGridViewClients.CurrentRow.Cells["CLAVE"].Value.ToString(), "CLAVE", "clientes");
				ShowClients();
				return;
			}
			labelError.Text = "Error. Por favor, seleccione por completo un registro en la tabla.";
			labelError.Visible = true;
		}
		
	}
}
