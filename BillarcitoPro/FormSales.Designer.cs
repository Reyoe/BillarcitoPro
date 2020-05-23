/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 22/11/2019
 * Time: 04:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BillarcitoPro
{
	partial class FormSales
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonSaveSale;
		private System.Windows.Forms.TextBox textBoxSaleIdProduct;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonDeleteSale;
		private System.Windows.Forms.DataGridView dataGridViewSales;
		private System.Windows.Forms.ComboBox comboBoxSaleMethod;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDownSaleCant;
		private System.Windows.Forms.Label label4;
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelError = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxSaleMethod = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownSaleCant = new System.Windows.Forms.NumericUpDown();
			this.buttonSaveSale = new System.Windows.Forms.Button();
			this.textBoxSaleIdProduct = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonDeleteSale = new System.Windows.Forms.Button();
			this.dataGridViewSales = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaleCant)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 38);
			this.label1.TabIndex = 3;
			this.label1.Text = "VENTAS";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1000, 47);
			this.panel2.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.panel1.Controls.Add(this.labelError);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.comboBoxSaleMethod);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.numericUpDownSaleCant);
			this.panel1.Controls.Add(this.buttonSaveSale);
			this.panel1.Controls.Add(this.textBoxSaleIdProduct);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(630, 47);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(370, 518);
			this.panel1.TabIndex = 5;
			// 
			// labelError
			// 
			this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(14, 314);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(344, 124);
			this.labelError.TabIndex = 15;
			this.labelError.Text = "Error: ";
			this.labelError.Visible = false;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DimGray;
			this.label4.Location = new System.Drawing.Point(22, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "METODO DE PAGO";
			// 
			// comboBoxSaleMethod
			// 
			this.comboBoxSaleMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.comboBoxSaleMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSaleMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxSaleMethod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxSaleMethod.ForeColor = System.Drawing.Color.LightGray;
			this.comboBoxSaleMethod.FormattingEnabled = true;
			this.comboBoxSaleMethod.Items.AddRange(new object[] {
			"EFECTIVO",
			"TARJETA DE CREDITO"});
			this.comboBoxSaleMethod.Location = new System.Drawing.Point(22, 206);
			this.comboBoxSaleMethod.Name = "comboBoxSaleMethod";
			this.comboBoxSaleMethod.Size = new System.Drawing.Size(218, 25);
			this.comboBoxSaleMethod.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DimGray;
			this.label3.Location = new System.Drawing.Point(22, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "CANTIDAD A VENDER:";
			// 
			// numericUpDownSaleCant
			// 
			this.numericUpDownSaleCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.numericUpDownSaleCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDownSaleCant.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.numericUpDownSaleCant.Location = new System.Drawing.Point(181, 127);
			this.numericUpDownSaleCant.Maximum = new decimal(new int[] {
			10,
			0,
			0,
			0});
			this.numericUpDownSaleCant.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.numericUpDownSaleCant.Name = "numericUpDownSaleCant";
			this.numericUpDownSaleCant.Size = new System.Drawing.Size(58, 20);
			this.numericUpDownSaleCant.TabIndex = 2;
			this.numericUpDownSaleCant.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// buttonSaveSale
			// 
			this.buttonSaveSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.buttonSaveSale.FlatAppearance.BorderSize = 0;
			this.buttonSaveSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonSaveSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonSaveSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSaveSale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSaveSale.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSaveSale.Location = new System.Drawing.Point(14, 252);
			this.buttonSaveSale.Name = "buttonSaveSale";
			this.buttonSaveSale.Size = new System.Drawing.Size(344, 40);
			this.buttonSaveSale.TabIndex = 4;
			this.buttonSaveSale.Text = "Guardar";
			this.buttonSaveSale.UseVisualStyleBackColor = false;
			this.buttonSaveSale.Click += new System.EventHandler(this.ButtonSaveSaleClick);
			// 
			// textBoxSaleIdProduct
			// 
			this.textBoxSaleIdProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxSaleIdProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxSaleIdProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSaleIdProduct.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxSaleIdProduct.Location = new System.Drawing.Point(22, 80);
			this.textBoxSaleIdProduct.Name = "textBoxSaleIdProduct";
			this.textBoxSaleIdProduct.Size = new System.Drawing.Size(336, 23);
			this.textBoxSaleIdProduct.TabIndex = 1;
			this.textBoxSaleIdProduct.Text = "ID DEL PRODUCTO";
			this.textBoxSaleIdProduct.Enter += new System.EventHandler(this.TextBoxSaleIdProductEnter);
			this.textBoxSaleIdProduct.Leave += new System.EventHandler(this.TextBoxSaleIdProductLeave);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label2.Location = new System.Drawing.Point(22, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Datos de la venta:";
			// 
			// buttonDeleteSale
			// 
			this.buttonDeleteSale.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonDeleteSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.buttonDeleteSale.FlatAppearance.BorderSize = 0;
			this.buttonDeleteSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonDeleteSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonDeleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeleteSale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeleteSale.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonDeleteSale.Location = new System.Drawing.Point(28, 491);
			this.buttonDeleteSale.Name = "buttonDeleteSale";
			this.buttonDeleteSale.Size = new System.Drawing.Size(175, 40);
			this.buttonDeleteSale.TabIndex = 5;
			this.buttonDeleteSale.Text = "Eliminar Venta";
			this.buttonDeleteSale.UseVisualStyleBackColor = false;
			this.buttonDeleteSale.Click += new System.EventHandler(this.ButtonDeleteSaleClick);
			// 
			// dataGridViewSales
			// 
			this.dataGridViewSales.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSales.Location = new System.Drawing.Point(28, 68);
			this.dataGridViewSales.Name = "dataGridViewSales";
			this.dataGridViewSales.Size = new System.Drawing.Size(560, 390);
			this.dataGridViewSales.TabIndex = 15;
			// 
			// FormSales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(1000, 565);
			this.Controls.Add(this.dataGridViewSales);
			this.Controls.Add(this.buttonDeleteSale);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormSales";
			this.Text = "FormSales";
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaleCant)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
