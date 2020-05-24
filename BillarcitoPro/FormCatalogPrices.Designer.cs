/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 22/11/2019
 * Time: 05:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BillarcitoPro
{
	partial class FormCatalogPrices
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxProductPrice;
		private System.Windows.Forms.Button buttonEditPrice;
		private System.Windows.Forms.TextBox textBoxProductId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewCatalogPrices;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.buttonEditPrice = new System.Windows.Forms.Button();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCatalogPrices = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogPrices)).BeginInit();
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
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "CATALOGO DE PRECIOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.textBoxProductPrice);
            this.panel1.Controls.Add(this.buttonEditPrice);
            this.panel1.Controls.Add(this.textBoxProductId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(630, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 518);
            this.panel1.TabIndex = 4;
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(22, 248);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(336, 241);
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
            this.textBoxProductPrice.Location = new System.Drawing.Point(22, 118);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(336, 23);
            this.textBoxProductPrice.TabIndex = 2;
            this.textBoxProductPrice.Text = "PRECIO DEL PRODUCTO";
            this.textBoxProductPrice.Enter += new System.EventHandler(this.TextBoxProductPriceEnter);
            this.textBoxProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxProductPriceKeyPress);
            this.textBoxProductPrice.Leave += new System.EventHandler(this.TextBoxProductPriceLeave);
            // 
            // buttonEditPrice
            // 
            this.buttonEditPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonEditPrice.FlatAppearance.BorderSize = 0;
            this.buttonEditPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonEditPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEditPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditPrice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEditPrice.Location = new System.Drawing.Point(22, 166);
            this.buttonEditPrice.Name = "buttonEditPrice";
            this.buttonEditPrice.Size = new System.Drawing.Size(344, 40);
            this.buttonEditPrice.TabIndex = 3;
            this.buttonEditPrice.Text = "Editar precio";
            this.buttonEditPrice.UseVisualStyleBackColor = false;
            this.buttonEditPrice.Click += new System.EventHandler(this.ButtonEditPriceClick);
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductId.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxProductId.Location = new System.Drawing.Point(22, 77);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(336, 23);
            this.textBoxProductId.TabIndex = 1;
            this.textBoxProductId.Text = "ID DEL PRODUCTO";
            this.textBoxProductId.Enter += new System.EventHandler(this.TextBoxProductIdEnter);
            this.textBoxProductId.Leave += new System.EventHandler(this.TextBoxProductIdLeave);
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
            // dataGridViewCatalogPrices
            // 
            this.dataGridViewCatalogPrices.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCatalogPrices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCatalogPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalogPrices.Location = new System.Drawing.Point(28, 68);
            this.dataGridViewCatalogPrices.Name = "dataGridViewCatalogPrices";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCatalogPrices.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCatalogPrices.Size = new System.Drawing.Size(560, 390);
            this.dataGridViewCatalogPrices.TabIndex = 5;
            // 
            // FormCatalogPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1000, 565);
            this.Controls.Add(this.dataGridViewCatalogPrices);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCatalogPrices";
            this.Text = "FormCatalogPrices";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogPrices)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
