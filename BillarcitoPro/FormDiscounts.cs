using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillarcitoPro
{
	/// <summary>
	/// Description of FormDiscounts.
	/// </summary>
	public partial class FormDiscounts : Form
	{
		DataBase database = new DataBase();
		private bool edit;
		private int auxiliar;
		
		public FormDiscounts(bool statusAdmin)
		{
			
			InitializeComponent();
			edit = false;
			ShowDiscounts();
			buttonDeleteDiscount.Visible |= statusAdmin;
			buttonEditDiscount.Visible |= statusAdmin;
			buttonSaveDiscount.Visible |= statusAdmin;
		}
		void TextBoxDiscountNameEnter(object sender, EventArgs e)
		{
			if (textBoxDiscountName.Text == "NOMBRE DEL DESCUENTO") {
				textBoxDiscountName.Text = "";
				textBoxDiscountName.ForeColor = Color.LightGray;
			}
		}
		void TextBoxDiscountNameLeave(object sender, EventArgs e)
		{
			if (textBoxDiscountName.Text == "") {
				textBoxDiscountName.Text = "NOMBRE DEL DESCUENTO";
				textBoxDiscountName.ForeColor = Color.DimGray;
			}
		}
		void ClearFormElements()
		{
			textBoxDiscountName.Text = "NOMBRE DEL DESCUENTO";
			numericUpDownDiscounFree.Value = 1;
			numericUpDownDiscountRequ.Value = 1;
			textBoxDiscountName.ForeColor = Color.DimGray;
		}
		void ShowDiscounts()
		{
			dataGridViewSales.DataSource = database.Show("horasdescuento");
		}
		void ButtonSaveDiscountClick(object sender, EventArgs e)
		{
			if(edit)
				EditDiscount();
			else
				SaveDiscount();						
		}	
		void EditDiscount(){
			if(database.VerifyExistenceString(textBoxDiscountName.Text, "NOMBRE", "horasdescuento")){
				labelError.Text = "Error. Ya existe un descuento con ese nombre. Por favor, ingrese un nombre de descuento distinto.";
				labelError.Visible = true;
				return;
			}
			labelError.Visible = false;
			database.EditDiscount(auxiliar,textBoxDiscountName.Text, Convert.ToInt32(numericUpDownDiscounFree.Value), Convert.ToInt32(numericUpDownDiscountRequ.Value));
			ClearFormElements();
			ShowDiscounts();
			edit = false;
		}
		void SaveDiscount(){
			if(database.VerifyExistenceString(textBoxDiscountName.Text, "NOMBRE", "horasdescuento")){
				labelError.Text = "Error. Ya existe un descuento con ese nombre.Por favor, ingrese un nombre de descuento distinto.";
				labelError.Visible = true;
				return;
			}
			labelError.Visible = false;
			database.InsertDiscount(textBoxDiscountName.Text, Convert.ToInt32(numericUpDownDiscounFree.Value), Convert.ToInt32(numericUpDownDiscountRequ.Value));
			ClearFormElements();
			ShowDiscounts();
		}
		void ButtonEditDiscountClick(object sender, EventArgs e)
		{
			if(dataGridViewSales.SelectedRows.Count > 0){
				textBoxDiscountName.Text = dataGridViewSales.CurrentRow.Cells["NOMBRE"].Value.ToString();
				edit = true;
				labelError.Visible = false;
				numericUpDownDiscounFree.Value = Convert.ToInt32(dataGridViewSales.CurrentRow.Cells["HORAS_REGALO"].Value);
				numericUpDownDiscountRequ.Value = Convert.ToInt32(dataGridViewSales.CurrentRow.Cells["HORAS_REQUERIDAS"].Value);
				auxiliar = Convert.ToInt32(dataGridViewSales.CurrentRow.Cells["ID"].Value);
				return;
			}
			labelError.Text = "Error. Por favor, seleccione por completo un registro de la tabla.";
			labelError.Visible = true;
		}
		void ButtonDeleteDiscountClick(object sender, EventArgs e)
		{
			if(dataGridViewSales.SelectedRows.Count > 0){
				labelError.Visible = false;
				database.DeleteInt(Convert.ToInt32(dataGridViewSales.CurrentRow.Cells["ID"].Value), "horasdescuento");
				ShowDiscounts();
				return;
			}
			labelError.Text = "Error. Por favor, seleccione por completo un registro de la tabla.";
			labelError.Visible = true;
		}


    }
}
