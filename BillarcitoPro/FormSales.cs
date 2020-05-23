/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 22/11/2019
 * Time: 04:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillarcitoPro
{
	/// <summary>
	/// Description of FormSales.
	/// </summary>
	public partial class FormSales : Form
	{
		private string userAdmin;
		DataBase database = new DataBase();
		public FormSales(bool statusAdmin, string _userAdmin)
		{

			InitializeComponent();
			ShowSales();
			userAdmin = _userAdmin;
			buttonDeleteSale.Visible |= statusAdmin;

		}
		void TextBoxSaleIdProductEnter(object sender, EventArgs e)
		{
			if (textBoxSaleIdProduct.Text == "ID DEL PRODUCTO") {
				textBoxSaleIdProduct.Text = "";
				textBoxSaleIdProduct.ForeColor = Color.LightGray;
			}
		}
		void TextBoxSaleIdProductLeave(object sender, EventArgs e)
		{
			if (textBoxSaleIdProduct.Text == "") {
				textBoxSaleIdProduct.Text = "ID DEL PRODUCTO";
				textBoxSaleIdProduct.ForeColor = Color.DimGray;
			}
		}
		void ClearFormElements()
		{
			textBoxSaleIdProduct.Text = "ID DEL PRODUCTO";
			textBoxSaleIdProduct.ForeColor = Color.DimGray;
			numericUpDownSaleCant.Value = 1;
			comboBoxSaleMethod.SelectedItem = null;
		}
		void ButtonSaveSaleClick(object sender, EventArgs e)
		{
			var fle = new FormLoginEmployee();
			float price;
			
			if(!database.VerifyExistenceInt(Convert.ToInt32(textBoxSaleIdProduct.Text), "productos")){
				labelError.Text = "Error. El id del producto ingresado no existe. Por favor, ingrese un valor válido.";
				labelError.Visible = true;
				return;
			}
			
			if (userAdmin == "")
				fle.ShowDialog();
			else{
				fle.SetLoged();
				fle.setUserEmployee(userAdmin);
			}
			
			if(fle.HasLoged()){
				labelError.Visible = false;
				price = database.GetPriceProduct(Convert.ToInt32(textBoxSaleIdProduct.Text));
				database.InsertSale(comboBoxSaleMethod.Text, fle.GetUserEmployee(), Convert.ToInt32(textBoxSaleIdProduct.Text), price, Convert.ToInt32(numericUpDownSaleCant.Value));
				ClearFormElements();
				ShowSales();
			}
		}
		void ShowSales()
		{
			dataGridViewSales.DataSource = database.Show("ventas");
		}
		void ButtonDeleteSaleClick(object sender, EventArgs e)
		{
			if(dataGridViewSales.SelectedRows.Count > 0){
				labelError.Visible = false;
				database.DeleteInt(Convert.ToInt32(dataGridViewSales.CurrentRow.Cells["ID"].Value), "ventas");
				ShowSales();
				return;
			}
			labelError.Text = "Error. Por favor, seleccione por completo un registro.";
			labelError.Visible = true;
		}
	}
}
