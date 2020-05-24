using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillarcitoPro
{
	/// <summary>
	/// Description of FormCatalogPrices.
	/// </summary>
	public partial class FormCatalogPrices : Form
	{
		private DataBase database;
		public FormCatalogPrices(bool statusAdmin)
		{
			InitializeComponent();
			buttonEditPrice.Visible |= statusAdmin;
			
			database = new DataBase();
			ShowProducts();
		}
		void TextBoxProductIdEnter(object sender, EventArgs e)
		{
			if(textBoxProductId.Text == "ID DEL PRODUCTO"){
				textBoxProductId.Text = "";
				textBoxProductId.ForeColor = Color.LightGray;
			}
		}
		void TextBoxProductIdLeave(object sender, EventArgs e)
		{
			if(textBoxProductId.Text == ""){
				textBoxProductId.Text = "ID DEL PRODUCTO";
				textBoxProductId.ForeColor = Color.DimGray;
			}
		}
		void TextBoxProductPriceEnter(object sender, EventArgs e)
		{
			if (textBoxProductPrice.Text == "PRECIO DEL PRODUCTO") {
				textBoxProductPrice.Text = "";
				textBoxProductPrice.ForeColor = Color.LightGray;
			}
		}
		void TextBoxProductPriceLeave(object sender, EventArgs e)
		{
			if (textBoxProductPrice.Text == "") {
				textBoxProductPrice.Text = "PRECIO DEL PRODUCTO";
				textBoxProductPrice.ForeColor = Color.DimGray;
			}
		}
		void TextBoxProductPriceKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') {
				e.Handled = true;
			}
			
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) {
				e.Handled = true;
			}
		}
		void ClearFormElements()
		{
			textBoxProductId.Text = "ID DEL PRODUCTO";
			textBoxProductPrice.Text = "PRECIO DEL PRODUCTO";
			textBoxProductId.ForeColor = Color.DimGray;
			textBoxProductPrice.ForeColor = Color.DimGray;
		}
		void ShowProducts()
		{
			dataGridViewCatalogPrices.DataSource = database.ShowCatalogPrices();
		}
		void ButtonEditPriceClick(object sender, EventArgs e)
		{
			if (!database.VerifyExistenceInt(int.Parse(textBoxProductId.Text), "catalogoPrecio")) {
				labelError.Text = "Error, ID del producto no reconocido. Por favor, ingrese un ID válido para poder modificar un precio.";
				labelError.Visible = true;
				return;
			}
			labelError.Visible = false;
			database.EditCatalogPrice(int.Parse(textBoxProductId.Text), float.Parse(textBoxProductPrice.Text));
			ClearFormElements();
			ShowProducts();
		}

    }
}
