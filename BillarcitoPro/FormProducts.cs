using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillarcitoPro
{
	public partial class FormProducts : Form
	{
		private DataBase database;
		private bool edit;
		private int id;
		public FormProducts()
		{
			
			InitializeComponent();
			edit = false;
			database = new DataBase();
			
			ShowProducts();
		}
		void TextBoxProductNameEnter(object sender, EventArgs e)
		{
			if (textBoxProductName.Text == "NOMBRE DEL PRODUCTO") {
				textBoxProductName.Text = "";
				textBoxProductName.ForeColor = Color.LightGray;
			}
		}
		void TextBoxProductNameLeave(object sender, EventArgs e)
		{
			if (textBoxProductName.Text == "") {
				textBoxProductName.Text = "NOMBRE DEL PRODUCTO";
				textBoxProductName.ForeColor = Color.DimGray;
			}
		}
		void TextBoxProductCantEnter(object sender, EventArgs e)
		{
			if (textBoxProductCant.Text == "CONTENIDO NETO") {
				textBoxProductCant.Text = "";
				textBoxProductCant.ForeColor = Color.LightGray;
			}
		}
		void TextBoxProductCantLeave(object sender, EventArgs e)
		{
			if (textBoxProductCant.Text == "") {
				textBoxProductCant.Text = "CONTENIDO NETO";
				textBoxProductCant.ForeColor = Color.DimGray;
			}
		}
		void TextBoxProductBrandEnter(object sender, EventArgs e)
		{
			if (textBoxProductBrand.Text == "MARCA") {
				textBoxProductBrand.Text = "";
				textBoxProductBrand.ForeColor = Color.LightGray;
			}
		}
		void TextBoxProductBrandLeave(object sender, EventArgs e)
		{
			if (textBoxProductBrand.Text == "") {
				textBoxProductBrand.Text = "MARCA";
				textBoxProductBrand.ForeColor = Color.DimGray;
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
		void TextBoxProductStockKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
				e.Handled = true;
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
			textBoxProductName.Text = "NOMBRE DEL PRODUCTO";
			textBoxProductCant.Text = "CONTENIDO NETO";
			textBoxProductBrand.Text = "MARCA";
			textBoxProductPrice.Text = "PRECIO DEL PRODUCTO";
			textBoxProductName.ForeColor = Color.DimGray;
			textBoxProductCant.ForeColor = Color.DimGray;
			textBoxProductBrand.ForeColor = Color.DimGray;
			textBoxProductPrice.ForeColor = Color.DimGray;
		}
		void ButtonSaveProductClick(object sender, EventArgs e)
		{
			if (edit) {
				EditProduct();
			}
			else{
				SaveProduct();
			}
		}
		void ButtonEditProductClick(object sender, EventArgs e)
		{
			if (dataGridViewProducts.SelectedRows.Count > 0) {
				textBoxProductName.Text = dataGridViewProducts.CurrentRow.Cells["NOMBRE"].Value.ToString();
				textBoxProductCant.Text = dataGridViewProducts.CurrentRow.Cells["CONTENIDO_NET"].Value.ToString();
				textBoxProductBrand.Text = dataGridViewProducts.CurrentRow.Cells["MARCA"].Value.ToString();
				id = int.Parse(dataGridViewProducts.CurrentRow.Cells["ID"].Value.ToString());
				textBoxProductPrice.Enabled = false;
				labelError.Visible = false;
				edit = true;
				return;
			}
			labelError.Visible = true;
			labelError.Text = "Error. Por favor, seleccione por completo un registro de la tabla.";
		}
		void ButtonDeleteProductClick(object sender, EventArgs e)
		{
			if(dataGridViewProducts.SelectedRows.Count > 0){
				
				if (database.VerifyProdVent(int.Parse(dataGridViewProducts.CurrentRow.Cells["ID"].Value.ToString()))) {
					labelError.Text = "Error. No puedes eliminar a un producto asociado a ventas.";
					labelError.Visible = true;
					return;
				}
				if (database.VerifyProdVent(6)) {
					labelError.Text = "Error. No puedes eliminar a un producto asociado a ventas.";
					labelError.Visible = true;
					return;
				}
				
				labelError.Visible = false;
				database.DeleteInt(int.Parse(dataGridViewProducts.CurrentRow.Cells["ID"].Value.ToString()), "catalogoPrecio");
				database.DeleteInt(int.Parse(dataGridViewProducts.CurrentRow.Cells["ID"].Value.ToString()), "productos");
				ShowProducts();
				return;
			}
			labelError.Text = "Error. Por favor, seleccione por completo un registro en la tabla.";
			labelError.Visible = true;
		}
		void SaveProduct()
		{
			if (textBoxProductName.Text == "NOMBRE DEL PRODUCTO") {
				labelError.Visible = true;
				labelError.Text = "Error. Por favor, ingrese el nombre del producto a registrar.";
				return;
			}
			labelError.Visible = false;
			database.InsertProduct(textBoxProductName.Text, textBoxProductCant.Text, textBoxProductBrand.Text, float.Parse(textBoxProductPrice.Text));
			ClearFormElements();
			ShowProducts();
		}
		void EditProduct()
		{
			database.EditProduct(id, textBoxProductName.Text, textBoxProductCant.Text, textBoxProductBrand.Text);
			textBoxProductPrice.Enabled = true;
			ClearFormElements();
			ShowProducts();
			edit = false;
		}
		void ShowProducts()
		{
			dataGridViewProducts.DataSource = database.Show("productos");
		}
	}
}
