using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BillarcitoPro
{
	/// <summary>
	/// Description of TablesForm.
	/// </summary>
	public partial class TablesForm : Form
	{
		private List<Table> tables;
		private int indexTables;
		private string userAdmin;
		private DataBase database;
		public TablesForm(bool adminStatus, ref List<Table> _tables, string _userAdmin)
		{
			
			InitializeComponent();
			database = new DataBase();
			tables = _tables;
			userAdmin = _userAdmin;
			indexTables = 0;
			groupBoxModTables.Visible |= adminStatus;
			
		}
		void CheckBoxClientCheckedChanged(object sender, EventArgs e)
		{
			textBoxClient.Enabled = checkBoxClient.Checked ? true : false;
		}
		void TextBoxClientEnter(object sender, EventArgs e)
		{
			if (textBoxClient.Text == "CLAVE DEL CLIENTE") {
				textBoxClient.Text = "";
				textBoxClient.ForeColor = Color.LightGray;
			}
		}
		void TextBoxClientLeave(object sender, EventArgs e)
		{
			if (textBoxClient.Text == "") {
				textBoxClient.Text = "CLAVE DEL CLIENTE";
				textBoxClient.ForeColor = Color.DimGray;
			}
		}
		void TextBoxDiscountUserClientEnter(object sender, EventArgs e)
		{
			if (textBoxDiscountUserClient.Text == "CLAVE DEL CLIENTE") {
				textBoxDiscountUserClient.Text = "";
				textBoxDiscountUserClient.ForeColor = Color.LightGray;
			}
		}
		void TextBoxDiscountUserClientLeave(object sender, EventArgs e)
		{
			if (textBoxDiscountUserClient.Text == "") {
				textBoxDiscountUserClient.Text = "CLAVE DEL CLIENTE";
				textBoxDiscountUserClient.ForeColor = Color.DimGray;
			}
		}
		void TextBoxDiscountIdDiscEnter(object sender, EventArgs e)
		{
			if (textBoxDiscountIdDisc.Text == "ID DESCUENTO") {
				textBoxDiscountIdDisc.Text = "";
				textBoxDiscountIdDisc.ForeColor = Color.LightGray;
			}
		}
		void TextBoxDiscountIdDiscLeave(object sender, EventArgs e)
		{
			if (textBoxDiscountIdDisc.Text == "") {
				textBoxDiscountIdDisc.Text = "ID DESCUENTO";
				textBoxDiscountIdDisc.ForeColor = Color.DimGray;
			}
		}
		void TextBoxDiscountIdDiscKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
				e.Handled = true;
			}
		}
		void ButtonTablesRegistresClick(object sender, EventArgs e)
		{
			var fta = new FormTablesAdmin();
			fta.ShowDialog();
		}
		void ClearFormElements()
		{
			textBoxDiscountIdDisc.Text = "ID DESCUENTO";
			textBoxDiscountIdDisc.ForeColor = Color.DimGray;
			textBoxDiscountUserClient.Text = "CLAVE DEL CLIENTE";
			textBoxDiscountUserClient.ForeColor = Color.DimGray;
			textBoxClient.Text = "CLAVE DEL CLIENTE";
			textBoxClient.ForeColor = Color.DimGray;
			checkBoxClient.Checked = false;
			numericUpDownHours.Value = 0;
			numericUpDownMinutes.Value = 0;
			comboBoxMethod.SelectedItem = null;
			
			labelTimeElapsed.Text = "00:00:00";
			labelTimeRemaining.Text = "00:00:00";
			labelCost.Text = "0.00";
		}
		void UpdateLabelsTableInformation(int index)
		{
			bool available;
			
			labelNumberTable.Text = "MESA " + tables[index].GetId();
			available = tables[index].IsAvailable();		
			
			labelTableOnGame.Visible = !available;			//label que marca ocupado
			pictureBoxNotAvailable.Visible = !available;	//dibujo de la mesa
			groupBoxDiscounts.Visible = available;			//gruposboxes
			groupBoxRequeriments.Visible = available;
			
			buttonStart.Enabled = available;				//boton empezar
			buttonFinish.Enabled = !available;				//boton terminar
			
			if (!available) {
				UpdateLabelsTableIndexTime();
			}
			
		}
		void TablesFormLoad(object sender, EventArgs e)
		{
			if (tables.Count > 0) {
				buttonStart.Visible = true;
				buttonFinish.Visible = true;
				groupBoxDiscounts.Visible = true;
				groupBoxRequeriments.Visible = true;
				UpdateLabelsTableInformation(indexTables);
			}
			else{
				labelNumberTable.Text = "No hay mesas.";
				
				labelTimeElapsed.Visible = false;
				labelTimeRemaining.Visible = false;
				labelTableAvailable.Visible = false;
				labelTableOnGame.Visible = false;
				
				buttonFinish.Visible = false;
				buttonStart.Visible = false;
				groupBoxDiscounts.Visible = false;
				groupBoxRequeriments.Visible = false;
			}
		}
		void ButtonLeftTablesClick(object sender, EventArgs e)
		{
			if (tables.Count == 0) {
				return;
			}
			if (indexTables == 0) {
				indexTables = tables.Count - 1;
				UpdateLabelsTableInformation(indexTables);
			}
			else{
				indexTables--;
				UpdateLabelsTableInformation(indexTables);
			}
		}
		void Button2RightTablesClick(object sender, EventArgs e)
		{
			if (tables.Count == 0) {
				return;
			}
			if (indexTables + 1 == tables.Count) {
				indexTables = 0;
				UpdateLabelsTableInformation(indexTables);
			}
			else{
				indexTables++;
				UpdateLabelsTableInformation(indexTables);
			}
		}
		void ButtonStartClick(object sender, EventArgs e)
		{
			if (checkBoxClient.Checked) {
				if (textBoxClient.Text == "CLAVE DEL CLIENTE") {
					labelMessages.Text = "ERROR: DEBE INGRESAR LA CLAVE DEL CLIENTE PARA COMENZAR EL JUEGO.";
					labelMessages.Visible = true;
					return;	
				}
				
				if (!database.VerifyExistenceString(textBoxClient.Text, "CLAVE", "clientes")) {
					labelMessages.Text = "ERROR: INGRESAR LA CLAVE DE UN CLIENTE EXISTENTE PARA COMENZAR EL JUEGO.";
					labelMessages.Visible = true;
					return;
				}
			}
			if (comboBoxMethod.SelectedItem == null) {
				labelMessages.Text = "ERROR: DEBE SELECCIONAR UN METODO DE PAGO PARA COMENZAR EL JUEGO.";
				labelMessages.Visible = true;
				return;
			}
			if (!checkBoxClient.Checked) {
				textBoxClient.Text = "No Registrado.";
			}
			labelMessages.Visible = false;
			tables[indexTables].BeginGame(int.Parse(numericUpDownHours.Value.ToString()), int.Parse(numericUpDownMinutes.Value.ToString()), textBoxClient.Text, comboBoxMethod.SelectedItem.ToString(), false);
			ClearFormElements();
			TablesFormLoad(new object(), new EventArgs());
		}
		void ButtonFinishClick(object sender, EventArgs e)
		{
			if (tables[indexTables].IsDiscount()) {
				tables[indexTables].Stop();
				tables[indexTables].Clear();
				ClearFormElements();
				TablesFormLoad(new object(), new EventArgs());
				return;
			}
			
			var fle = new FormLoginEmployee();
			
			if (userAdmin == "") 
				fle.ShowDialog();	
			else{
				fle.SetLoged();
				fle.setUserEmployee(userAdmin);
			}
			
			if (fle.HasLoged()) {
				tables[indexTables].SetEmployee(fle.GetUserEmployee());
				tables[indexTables].SaveRegisterInDB();
				tables[indexTables].Stop();
				tables[indexTables].Clear();
				ClearFormElements();
				TablesFormLoad(new object(), new EventArgs());
			}
		}
		void TimerTablesTick(object sender, EventArgs e)
		{
			if (tables.Count > 0) {
				UpdateLabelsTableIndexTime();	
			}
		}
		void UpdateLabelsTableIndexTime()
		{
			if (!tables[indexTables].IsAvailable()) {
				labelTimeElapsed.Text = tables[indexTables].CalculateTimeElapsed();
				labelTimeRemaining.Text = tables[indexTables].CalculateTimeRemaining();
				labelCost.Text = tables[indexTables].CalculateCost();	
			}
		}
		void ButtonApplyDiscountClick(object sender, EventArgs e)
		{
			int hrs;
			if (textBoxDiscountUserClient.Text == "CLAVE DEL CLIENTE") {
				labelMessages.Text = "ERROR: DEBE INGRESAR LA CLAVE DEL CLIENTE PARA APLICAR DESCUENTO.";
				labelMessages.Visible = true;
				return;
			}
			if (textBoxDiscountIdDisc.Text == "ID DESCUENTO") {
				labelMessages.Text = "ERROR: DEBE INGRESAR EL ID DEL DESCUENTO PARA APLICAR DESCUENTO.";
				labelMessages.Visible = true;
				return;
			}
			if (!database.VerifyExistenceInt(int.Parse(textBoxDiscountIdDisc.Text), "horasdescuento")) {
				labelMessages.Text = "ERROR: ID DE DESCUENTO NO RECONOCIDO.";
				labelMessages.Visible = true;
				return;
			}
			if (!database.VerifyExistenceString(textBoxDiscountUserClient.Text, "CLAVE", "clientes")) {
				labelMessages.Text = "ERROR: CLAVE DE CLIENTE NO DESCONOCIDA.";
				labelMessages.Visible = true;
				return;
			}
			hrs = database.UpdateHrsDiscount(textBoxDiscountUserClient.Text, textBoxDiscountIdDisc.Text);
			if (hrs == 0) {
				labelMessages.Text = "ERROR: EL CLIENTE NO AJUSTA LAS HORAS REQUERIDAS PARA APLICAR EL DESCUENTO.";
				labelMessages.Visible = true;
				return;
			}
			
			labelMessages.Visible = false;
			tables[indexTables].BeginGame(hrs, 0, textBoxDiscountUserClient.Text, "DESCUENTO", true);
			ClearFormElements();
			TablesFormLoad(new object(), new EventArgs());
		}
		void ButtonPushTableClick(object sender, EventArgs e)
		{
			var table = new Table(tables.Count + 1);
			tables.Add(table);
			database.PushTable();
			indexTables = 0;
			TablesFormLoad(new object(), new EventArgs());
		}
		void ButtonPopTableClick(object sender, EventArgs e)
		{
			if (tables.Count == 0) {
				return;
			}

			tables.RemoveAt(tables.Count - 1);
			database.PopTable();
			indexTables = 0;
			TablesFormLoad(new object(), new EventArgs());
		}

        private void textBoxClient_TextChanged(object sender, EventArgs e)
        {

        }

		private void pictureBoxNotAvailable_Click(object sender, EventArgs e)
		{

		}
	}
}
