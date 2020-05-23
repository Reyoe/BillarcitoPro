/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 22/11/2019
 * Time: 06:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillarcitoPro
{
	/// <summary>
	/// Description of FormEmployees.
	/// </summary>
	public partial class FormEmployees : Form
	{
		DataBase database = new DataBase();
		private bool edit;
		private string auxiliar;
		
		public FormEmployees()
		{

			InitializeComponent();
			edit = false;
			ShowEmployees();

		}
		void TextBoxEmpNameEnter(object sender, EventArgs e)
		{
			if (textBoxEmpName.Text == "NOMBRE(S)") {
				textBoxEmpName.Text = "";
				textBoxEmpName.ForeColor = Color.LightGray;
			}
		}
		void TextBoxEmpNameLeave(object sender, EventArgs e)
		{
			if (textBoxEmpName.Text == "") {
				textBoxEmpName.Text = "NOMBRE(S)";
				textBoxEmpName.ForeColor = Color.DimGray;
			}
		}
		void TextBoxEmpLNameEnter(object sender, EventArgs e)
		{
			if (textBoxEmpLName.Text == "APELLIDO(S)") {
				textBoxEmpLName.Text = "";
				textBoxEmpLName.ForeColor = Color.LightGray;
			}
		}
		void TextBoxEmpLNameLeave(object sender, EventArgs e)
		{
			if (textBoxEmpLName.Text == "") {
				textBoxEmpLName.Text = "APELLIDO(S)";
				textBoxEmpLName.ForeColor = Color.DimGray;
			}
		}
		void TextBoxEmpTelEnter(object sender, EventArgs e)
		{
			if (textBoxEmpTel.Text == "TELEFONO") {
				textBoxEmpTel.Text = "";
				textBoxEmpTel.ForeColor = Color.LightGray;
			}
		}
		void TextBoxEmpTelLeave(object sender, EventArgs e)
		{
			if (textBoxEmpTel.Text == "") {
				textBoxEmpTel.Text = "TELEFONO";
				textBoxEmpTel.ForeColor = Color.DimGray;
			}
		}
		void TextBoxEmpUserEnter(object sender, EventArgs e)
		{
			if (textBoxEmpUser.Text == "USUARIO") {
				textBoxEmpUser.Text = "";
				textBoxEmpUser.ForeColor = Color.LightGray;
			}
		}
		void TextBoxEmpUserLeave(object sender, EventArgs e)
		{
			if (textBoxEmpUser.Text == "") {
				textBoxEmpUser.Text = "USUARIO";
				textBoxEmpUser.ForeColor = Color.DimGray;
			}
		}
		void TextBoxEmpPassEnter(object sender, EventArgs e)
		{
			if (textBoxEmpPass.Text == "CONTRASEÑA") {
				textBoxEmpPass.Text = "";
				textBoxEmpPass.ForeColor = Color.LightGray;
			}
		}
		void TextBoxEmpPassLeave(object sender, EventArgs e)
		{
			if (textBoxEmpPass.Text == "") {
				textBoxEmpPass.Text = "CONTRASEÑA";
				textBoxEmpPass.ForeColor = Color.DimGray;
			}
		}
		void TextBoxEmpTelKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
				e.Handled = true;
			}
		}
		void ClearFormElements()
		{
			textBoxEmpName.Text = "NOMBRE(S)";
			textBoxEmpLName.Text = "APELLIDO(S)";
			textBoxEmpTel.Text = "TELEFONO";
			textBoxEmpUser.Text = "USUARIO";
			textBoxEmpPass.Text = "CONTRASEÑA";
			comboBoxPosition.SelectedItem = null;
			textBoxEmpName.ForeColor = Color.DimGray;
			textBoxEmpLName.ForeColor = Color.DimGray;
			textBoxEmpTel.ForeColor = Color.DimGray;
			textBoxEmpUser.ForeColor = Color.DimGray;
			textBoxEmpPass.ForeColor = Color.DimGray;
		}
		
		void ShowEmployees()
		{
			dataGridViewEmployee.DataSource = database.Show("trabajadores");
		}
		
		void SaveEmployee()
		{
			if(database.VerifyExistenceString(textBoxEmpUser.Text, "USUARIO", "trabajadores")){
				labelError.Text = "Error. Ya existe un trabajador con el usuario ingresado. Por favor, ingrese un trabajador con un usuario distinto.";
				labelError.Visible = true;
				return;
			}
			labelError.Visible = false;
			database.InsertEmployee(textBoxEmpUser.Text, textBoxEmpPass.Text, textBoxEmpName.Text, textBoxEmpLName.Text, textBoxEmpTel.Text, comboBoxPosition.SelectedItem.ToString());
			ClearFormElements();
			ShowEmployees();
		}
		void EditEmployee()
		{
			if(auxiliar != textBoxEmpUser.Text){
				if(database.VerifyExistenceString(textBoxEmpUser.Text, "USUARIO", "trabajadores")){
					labelError.Text = "Error. Ya existe un trabajador con el usuario ingresado. Por favor, ingrese un usuario distinto.";
					labelError.Visible = true;
					return;
				}
				if(database.VerifyEmpVent(auxiliar)){
					labelError.Text = "Error. No puedes editar el usuario a un trabajador asociado a ventas.";
					labelError.Visible = true;
					return;
				}
			}
			if (comboBoxPosition.SelectedItem == null) {
				labelError.Text = "Error. Por favor, especifica una posición de trabajo.";
				labelError.Visible = true;
				return;
			}
			labelError.Visible = false;
			database.EditEmployee(auxiliar,textBoxEmpUser.Text,textBoxEmpPass.Text,textBoxEmpName.Text,textBoxEmpLName.Text,textBoxEmpTel.Text, comboBoxPosition.SelectedItem.ToString());
			ClearFormElements();
			ShowEmployees();
			edit = false;
		}
		void ButtonSaveEmployeeClick(object sender, EventArgs e)
		{
			if(edit)
				EditEmployee();
			else
				SaveEmployee();
		}
		void ButtonEditEmployeeClick(object sender, EventArgs e)
		{
			if(dataGridViewEmployee.SelectedRows.Count > 0){
				textBoxEmpUser.Text = dataGridViewEmployee.CurrentRow.Cells["USUARIO"].Value.ToString();
				textBoxEmpPass.Text = dataGridViewEmployee.CurrentRow.Cells["CLAVE"].Value.ToString();
				textBoxEmpName.Text = dataGridViewEmployee.CurrentRow.Cells["NOMBRE"].Value.ToString();
				textBoxEmpLName.Text = dataGridViewEmployee.CurrentRow.Cells["APELLIDO"].Value.ToString();
				textBoxEmpTel.Text = dataGridViewEmployee.CurrentRow.Cells["TELEFONO"].Value.ToString();
				edit = true;
				labelError.Visible = false;
				auxiliar = textBoxEmpUser.Text;
				return;
			}
			labelError.Text = "Error. Por favor, seleccione por completo un registro en la tabla.";
			labelError.Visible = true;
		}
		void ButtonDeleteEmployeeClick(object sender, EventArgs e)
		{
			if(dataGridViewEmployee.SelectedRows.Count > 0){
				
				if(database.VerifyEmpVent(dataGridViewEmployee.CurrentRow.Cells["USUARIO"].Value.ToString())){
					labelError.Text = "Error. No puedes eliminar a un trabajador asociado a ventas.";
					labelError.Visible = true;
					return;
				}
				labelError.Visible = false;
				database.DeleteString(dataGridViewEmployee.CurrentRow.Cells["USUARIO"].Value.ToString(), "USUARIO", "trabajadores");
				ShowEmployees();
				return;
			}
			labelError.Text = "Error. Por favor, seleccione por completo un registro en la tabla.";
			labelError.Visible = true;
		}
	}
}
