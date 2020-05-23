/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 22/11/2019
 * Time: 02:55 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BillarcitoPro
{
	partial class FormProducts
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxProductBrand;
		private System.Windows.Forms.TextBox textBoxProductCant;
		private System.Windows.Forms.TextBox textBoxProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonSaveProduct;
		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.Button buttonEditProduct;
		private System.Windows.Forms.Button buttonDeleteProduct;
		private System.Windows.Forms.TextBox textBoxProductPrice;
		private System.Windows.Forms.Label labelError;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelError = new System.Windows.Forms.Label();
			this.textBoxProductPrice = new System.Windows.Forms.TextBox();
			this.buttonSaveProduct = new System.Windows.Forms.Button();
			this.textBoxProductBrand = new System.Windows.Forms.TextBox();
			this.textBoxProductCant = new System.Windows.Forms.TextBox();
			this.textBoxProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.buttonEditProduct = new System.Windows.Forms.Button();
			this.buttonDeleteProduct = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.panel1.Controls.Add(this.labelError);
			this.panel1.Controls.Add(this.textBoxProductPrice);
			this.panel1.Controls.Add(this.buttonSaveProduct);
			this.panel1.Controls.Add(this.textBoxProductBrand);
			this.panel1.Controls.Add(this.textBoxProductCant);
			this.panel1.Controls.Add(this.textBoxProductName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(630, 47);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(370, 518);
			this.panel1.TabIndex = 0;
			// 
			// labelError
			// 
			this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(14, 339);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(344, 156);
			this.labelError.TabIndex = 12;
			this.labelError.Text = "Error: ";
			this.labelError.Visible = false;
			// 
			// textBoxProductPrice
			// 
			this.textBoxProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxProductPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxProductPrice.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxProductPrice.Location = new System.Drawing.Point(22, 228);
			this.textBoxProductPrice.Name = "textBoxProductPrice";
			this.textBoxProductPrice.Size = new System.Drawing.Size(336, 23);
			this.textBoxProductPrice.TabIndex = 4;
			this.textBoxProductPrice.Text = "PRECIO DEL PRODUCTO";
			this.textBoxProductPrice.Enter += new System.EventHandler(this.TextBoxProductPriceEnter);
			this.textBoxProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxProductPriceKeyPress);
			this.textBoxProductPrice.Leave += new System.EventHandler(this.TextBoxProductPriceLeave);
			// 
			// buttonSaveProduct
			// 
			this.buttonSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.buttonSaveProduct.FlatAppearance.BorderSize = 0;
			this.buttonSaveProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonSaveProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSaveProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSaveProduct.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSaveProduct.Location = new System.Drawing.Point(14, 282);
			this.buttonSaveProduct.Name = "buttonSaveProduct";
			this.buttonSaveProduct.Size = new System.Drawing.Size(344, 40);
			this.buttonSaveProduct.TabIndex = 5;
			this.buttonSaveProduct.Text = "Guardar";
			this.buttonSaveProduct.UseVisualStyleBackColor = false;
			this.buttonSaveProduct.Click += new System.EventHandler(this.ButtonSaveProductClick);
			// 
			// textBoxProductBrand
			// 
			this.textBoxProductBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxProductBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxProductBrand.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxProductBrand.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxProductBrand.Location = new System.Drawing.Point(22, 179);
			this.textBoxProductBrand.Name = "textBoxProductBrand";
			this.textBoxProductBrand.Size = new System.Drawing.Size(336, 23);
			this.textBoxProductBrand.TabIndex = 3;
			this.textBoxProductBrand.Text = "MARCA";
			this.textBoxProductBrand.Enter += new System.EventHandler(this.TextBoxProductBrandEnter);
			this.textBoxProductBrand.Leave += new System.EventHandler(this.TextBoxProductBrandLeave);
			// 
			// textBoxProductCant
			// 
			this.textBoxProductCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxProductCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxProductCant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxProductCant.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxProductCant.Location = new System.Drawing.Point(22, 128);
			this.textBoxProductCant.Name = "textBoxProductCant";
			this.textBoxProductCant.Size = new System.Drawing.Size(336, 23);
			this.textBoxProductCant.TabIndex = 2;
			this.textBoxProductCant.Text = "CONTENIDO NETO";
			this.textBoxProductCant.Enter += new System.EventHandler(this.TextBoxProductCantEnter);
			this.textBoxProductCant.Leave += new System.EventHandler(this.TextBoxProductCantLeave);
			// 
			// textBoxProductName
			// 
			this.textBoxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxProductName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxProductName.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxProductName.Location = new System.Drawing.Point(22, 77);
			this.textBoxProductName.Name = "textBoxProductName";
			this.textBoxProductName.Size = new System.Drawing.Size(336, 23);
			this.textBoxProductName.TabIndex = 1;
			this.textBoxProductName.Text = "NOMBRE DEL PRODUCTO";
			this.textBoxProductName.Enter += new System.EventHandler(this.TextBoxProductNameEnter);
			this.textBoxProductName.Leave += new System.EventHandler(this.TextBoxProductNameLeave);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label2.Location = new System.Drawing.Point(22, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Datos del producto:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "PRODUCTOS";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1000, 47);
			this.panel2.TabIndex = 2;
			// 
			// dataGridViewProducts
			// 
			this.dataGridViewProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProducts.Location = new System.Drawing.Point(28, 68);
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.Size = new System.Drawing.Size(560, 390);
			this.dataGridViewProducts.TabIndex = 3;
			// 
			// buttonEditProduct
			// 
			this.buttonEditProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.buttonEditProduct.FlatAppearance.BorderSize = 0;
			this.buttonEditProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonEditProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEditProduct.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonEditProduct.Location = new System.Drawing.Point(89, 492);
			this.buttonEditProduct.Name = "buttonEditProduct";
			this.buttonEditProduct.Size = new System.Drawing.Size(175, 40);
			this.buttonEditProduct.TabIndex = 6;
			this.buttonEditProduct.Text = "Editar Producto";
			this.buttonEditProduct.UseVisualStyleBackColor = false;
			this.buttonEditProduct.Click += new System.EventHandler(this.ButtonEditProductClick);
			// 
			// buttonDeleteProduct
			// 
			this.buttonDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.buttonDeleteProduct.FlatAppearance.BorderSize = 0;
			this.buttonDeleteProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonDeleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeleteProduct.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonDeleteProduct.Location = new System.Drawing.Point(324, 492);
			this.buttonDeleteProduct.Name = "buttonDeleteProduct";
			this.buttonDeleteProduct.Size = new System.Drawing.Size(175, 40);
			this.buttonDeleteProduct.TabIndex = 7;
			this.buttonDeleteProduct.Text = "Eliminar Producto";
			this.buttonDeleteProduct.UseVisualStyleBackColor = false;
			this.buttonDeleteProduct.Click += new System.EventHandler(this.ButtonDeleteProductClick);
			// 
			// FormProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(1000, 565);
			this.Controls.Add(this.buttonDeleteProduct);
			this.Controls.Add(this.buttonEditProduct);
			this.Controls.Add(this.dataGridViewProducts);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormProducts";
			this.Text = "FormProducts";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
