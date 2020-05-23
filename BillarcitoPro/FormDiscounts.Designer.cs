/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 23/11/2019
 * Time: 01:08 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BillarcitoPro
{
	partial class FormDiscounts
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown numericUpDownDiscountRequ;
		private System.Windows.Forms.Label labelError;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDownDiscounFree;
		private System.Windows.Forms.Button buttonSaveDiscount;
		private System.Windows.Forms.TextBox textBoxDiscountName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonEditDiscount;
		private System.Windows.Forms.Button buttonDeleteDiscount;
		private System.Windows.Forms.DataGridView dataGridViewSales;
		
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownDiscountRequ = new System.Windows.Forms.NumericUpDown();
            this.labelError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownDiscounFree = new System.Windows.Forms.NumericUpDown();
            this.buttonSaveDiscount = new System.Windows.Forms.Button();
            this.textBoxDiscountName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEditDiscount = new System.Windows.Forms.Button();
            this.buttonDeleteDiscount = new System.Windows.Forms.Button();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscountRequ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscounFree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "DESCUENTOS EN JUEGOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.numericUpDownDiscountRequ);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDownDiscounFree);
            this.panel1.Controls.Add(this.buttonSaveDiscount);
            this.panel1.Controls.Add(this.textBoxDiscountName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(630, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 518);
            this.panel1.TabIndex = 6;
            // 
            // numericUpDownDiscountRequ
            // 
            this.numericUpDownDiscountRequ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.numericUpDownDiscountRequ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownDiscountRequ.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDownDiscountRequ.Location = new System.Drawing.Point(181, 180);
            this.numericUpDownDiscountRequ.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDiscountRequ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDiscountRequ.Name = "numericUpDownDiscountRequ";
            this.numericUpDownDiscountRequ.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownDiscountRequ.TabIndex = 3;
            this.numericUpDownDiscountRequ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(14, 314);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(344, 195);
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
            this.label4.Text = "HORAS NECESARIAS";
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
            this.label3.Text = "HORAS DE REGALO";
            // 
            // numericUpDownDiscounFree
            // 
            this.numericUpDownDiscounFree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.numericUpDownDiscounFree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownDiscounFree.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numericUpDownDiscounFree.Location = new System.Drawing.Point(181, 127);
            this.numericUpDownDiscounFree.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDiscounFree.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDiscounFree.Name = "numericUpDownDiscounFree";
            this.numericUpDownDiscounFree.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownDiscounFree.TabIndex = 2;
            this.numericUpDownDiscounFree.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSaveDiscount
            // 
            this.buttonSaveDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonSaveDiscount.FlatAppearance.BorderSize = 0;
            this.buttonSaveDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonSaveDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveDiscount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSaveDiscount.Location = new System.Drawing.Point(14, 225);
            this.buttonSaveDiscount.Name = "buttonSaveDiscount";
            this.buttonSaveDiscount.Size = new System.Drawing.Size(344, 40);
            this.buttonSaveDiscount.TabIndex = 4;
            this.buttonSaveDiscount.Text = "Guardar";
            this.buttonSaveDiscount.UseVisualStyleBackColor = false;
            this.buttonSaveDiscount.Click += new System.EventHandler(this.ButtonSaveDiscountClick);
            // 
            // textBoxDiscountName
            // 
            this.textBoxDiscountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxDiscountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiscountName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscountName.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDiscountName.Location = new System.Drawing.Point(22, 80);
            this.textBoxDiscountName.Name = "textBoxDiscountName";
            this.textBoxDiscountName.Size = new System.Drawing.Size(336, 23);
            this.textBoxDiscountName.TabIndex = 1;
            this.textBoxDiscountName.Text = "NOMBRE DEL DESCUENTO";
            this.textBoxDiscountName.Enter += new System.EventHandler(this.TextBoxDiscountNameEnter);
            this.textBoxDiscountName.Leave += new System.EventHandler(this.TextBoxDiscountNameLeave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos del descuento:";
            // 
            // buttonEditDiscount
            // 
            this.buttonEditDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonEditDiscount.FlatAppearance.BorderSize = 0;
            this.buttonEditDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonEditDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditDiscount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEditDiscount.Location = new System.Drawing.Point(89, 492);
            this.buttonEditDiscount.Name = "buttonEditDiscount";
            this.buttonEditDiscount.Size = new System.Drawing.Size(175, 40);
            this.buttonEditDiscount.TabIndex = 5;
            this.buttonEditDiscount.Text = "Editar Descuento";
            this.buttonEditDiscount.UseVisualStyleBackColor = false;
            this.buttonEditDiscount.Click += new System.EventHandler(this.ButtonEditDiscountClick);
            // 
            // buttonDeleteDiscount
            // 
            this.buttonDeleteDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonDeleteDiscount.FlatAppearance.BorderSize = 0;
            this.buttonDeleteDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonDeleteDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDeleteDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteDiscount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDeleteDiscount.Location = new System.Drawing.Point(324, 492);
            this.buttonDeleteDiscount.Name = "buttonDeleteDiscount";
            this.buttonDeleteDiscount.Size = new System.Drawing.Size(175, 40);
            this.buttonDeleteDiscount.TabIndex = 6;
            this.buttonDeleteDiscount.Text = "Eliminar Descuento";
            this.buttonDeleteDiscount.UseVisualStyleBackColor = false;
            this.buttonDeleteDiscount.Click += new System.EventHandler(this.ButtonDeleteDiscountClick);
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(28, 68);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Size = new System.Drawing.Size(560, 390);
            this.dataGridViewSales.TabIndex = 17;
            // 
            // FormDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1000, 565);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.buttonDeleteDiscount);
            this.Controls.Add(this.buttonEditDiscount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDiscounts";
            this.Text = "FormDiscounts";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscountRequ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscounFree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
