/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 20/11/2019
 * Time: 02:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BillarcitoPro
{
	partial class Menu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelTittle;
		private System.Windows.Forms.Panel panelVertical;
		private System.Windows.Forms.Panel panelContainer;
		private System.Windows.Forms.PictureBox buttonClose;
		private System.Windows.Forms.PictureBox buttonRestore;
		private System.Windows.Forms.PictureBox buttonMinimize;
		private System.Windows.Forms.PictureBox buttonMaximize;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.Button buttonTables;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonProducts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelProducts;
		private System.Windows.Forms.Button buttonEmployees;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button buttonClients;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button buttonPrices;
		private System.Windows.Forms.Button buttonAdmin;
		private System.Windows.Forms.Panel panelEmployees;
		private System.Windows.Forms.Button buttonSales;
		private System.Windows.Forms.Button buttonLogoutAdmin;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button buttonDiscounts;
		private System.Windows.Forms.Timer timerTables;
		
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelTittle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRestore = new System.Windows.Forms.PictureBox();
            this.buttonMinimize = new System.Windows.Forms.PictureBox();
            this.buttonMaximize = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.panelVertical = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonDiscounts = new System.Windows.Forms.Button();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.panelEmployees = new System.Windows.Forms.Panel();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogoutAdmin = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonClients = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonPrices = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTables = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.timerTables = new System.Windows.Forms.Timer(this.components);
            this.panelTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.panelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTittle
            // 
            this.panelTittle.BackColor = System.Drawing.Color.Red;
            this.panelTittle.Controls.Add(this.label1);
            this.panelTittle.Controls.Add(this.buttonRestore);
            this.panelTittle.Controls.Add(this.buttonMinimize);
            this.panelTittle.Controls.Add(this.buttonMaximize);
            this.panelTittle.Controls.Add(this.buttonClose);
            this.panelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittle.Location = new System.Drawing.Point(0, 0);
            this.panelTittle.Name = "panelTittle";
            this.panelTittle.Size = new System.Drawing.Size(1200, 35);
            this.panelTittle.TabIndex = 0;
            this.panelTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTittleMouseDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Billarcito Pro V1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestore.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestore.Image")));
            this.buttonRestore.Location = new System.Drawing.Point(1131, 3);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(30, 30);
            this.buttonRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonRestore.TabIndex = 3;
            this.buttonRestore.TabStop = false;
            this.buttonRestore.Visible = false;
            this.buttonRestore.Click += new System.EventHandler(this.ButtonRestoreClick);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(1095, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(30, 30);
            this.buttonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Click += new System.EventHandler(this.ButtonMinimizeClick);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.Image")));
            this.buttonMaximize.Location = new System.Drawing.Point(1131, 3);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(30, 30);
            this.buttonMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMaximize.TabIndex = 1;
            this.buttonMaximize.TabStop = false;
            this.buttonMaximize.Click += new System.EventHandler(this.ButtonMaximizeClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1167, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelVertical.Controls.Add(this.panel5);
            this.panelVertical.Controls.Add(this.buttonDiscounts);
            this.panelVertical.Controls.Add(this.panelProducts);
            this.panelVertical.Controls.Add(this.panelEmployees);
            this.panelVertical.Controls.Add(this.buttonProducts);
            this.panelVertical.Controls.Add(this.panel2);
            this.panelVertical.Controls.Add(this.buttonLogoutAdmin);
            this.panelVertical.Controls.Add(this.buttonSales);
            this.panelVertical.Controls.Add(this.buttonAdmin);
            this.panelVertical.Controls.Add(this.buttonEmployees);
            this.panelVertical.Controls.Add(this.panel4);
            this.panelVertical.Controls.Add(this.buttonClients);
            this.panelVertical.Controls.Add(this.panel3);
            this.panelVertical.Controls.Add(this.buttonPrices);
            this.panelVertical.Controls.Add(this.panel1);
            this.panelVertical.Controls.Add(this.buttonTables);
            this.panelVertical.Controls.Add(this.pictureBoxLogo);
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical.Location = new System.Drawing.Point(0, 35);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(200, 565);
            this.panelVertical.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(0, 345);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 53);
            this.panel5.TabIndex = 15;
            // 
            // buttonDiscounts
            // 
            this.buttonDiscounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonDiscounts.FlatAppearance.BorderSize = 0;
            this.buttonDiscounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscounts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiscounts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDiscounts.Location = new System.Drawing.Point(0, 345);
            this.buttonDiscounts.Name = "buttonDiscounts";
            this.buttonDiscounts.Size = new System.Drawing.Size(200, 53);
            this.buttonDiscounts.TabIndex = 5;
            this.buttonDiscounts.Text = "Descuentos en juegos";
            this.buttonDiscounts.UseVisualStyleBackColor = false;
            this.buttonDiscounts.Click += new System.EventHandler(this.Button1Click);
            // 
            // panelProducts
            // 
            this.panelProducts.BackColor = System.Drawing.Color.Red;
            this.panelProducts.Location = new System.Drawing.Point(0, 404);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(10, 53);
            this.panelProducts.TabIndex = 8;
            this.panelProducts.Visible = false;
            // 
            // panelEmployees
            // 
            this.panelEmployees.BackColor = System.Drawing.Color.Red;
            this.panelEmployees.Location = new System.Drawing.Point(0, 463);
            this.panelEmployees.Name = "panelEmployees";
            this.panelEmployees.Size = new System.Drawing.Size(10, 53);
            this.panelEmployees.TabIndex = 11;
            this.panelEmployees.Visible = false;
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProducts.Location = new System.Drawing.Point(0, 404);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(200, 53);
            this.buttonProducts.TabIndex = 6;
            this.buttonProducts.Text = "Productos";
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Visible = false;
            this.buttonProducts.Click += new System.EventHandler(this.ButtonProductsClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(0, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 53);
            this.panel2.TabIndex = 3;
            // 
            // buttonLogoutAdmin
            // 
            this.buttonLogoutAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogoutAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonLogoutAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogoutAdmin.BackgroundImage")));
            this.buttonLogoutAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogoutAdmin.FlatAppearance.BorderSize = 0;
            this.buttonLogoutAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonLogoutAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogoutAdmin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogoutAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogoutAdmin.Location = new System.Drawing.Point(0, 522);
            this.buttonLogoutAdmin.Name = "buttonLogoutAdmin";
            this.buttonLogoutAdmin.Size = new System.Drawing.Size(73, 40);
            this.buttonLogoutAdmin.TabIndex = 13;
            this.buttonLogoutAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogoutAdmin.UseVisualStyleBackColor = false;
            this.buttonLogoutAdmin.Visible = false;
            this.buttonLogoutAdmin.Click += new System.EventHandler(this.ButtonLogoutAdminClick);
            // 
            // buttonSales
            // 
            this.buttonSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonSales.FlatAppearance.BorderSize = 0;
            this.buttonSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSales.Location = new System.Drawing.Point(0, 168);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(200, 53);
            this.buttonSales.TabIndex = 2;
            this.buttonSales.Text = "Ventas";
            this.buttonSales.UseVisualStyleBackColor = false;
            this.buttonSales.Click += new System.EventHandler(this.ButtonSalesClick);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.BackgroundImage")));
            this.buttonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdmin.Location = new System.Drawing.Point(3, 522);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(73, 40);
            this.buttonAdmin.TabIndex = 10;
            this.buttonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.ButtonAdminClick);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonEmployees.FlatAppearance.BorderSize = 0;
            this.buttonEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployees.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEmployees.Location = new System.Drawing.Point(0, 463);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(200, 53);
            this.buttonEmployees.TabIndex = 7;
            this.buttonEmployees.Text = "Trabajadores";
            this.buttonEmployees.UseVisualStyleBackColor = false;
            this.buttonEmployees.Visible = false;
            this.buttonEmployees.Click += new System.EventHandler(this.ButtonEmployeesClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(0, 286);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 53);
            this.panel4.TabIndex = 6;
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonClients.FlatAppearance.BorderSize = 0;
            this.buttonClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClients.Location = new System.Drawing.Point(0, 286);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(200, 53);
            this.buttonClients.TabIndex = 4;
            this.buttonClients.Text = "Clientes";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.ButtonClientsClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(0, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 53);
            this.panel3.TabIndex = 4;
            // 
            // buttonPrices
            // 
            this.buttonPrices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonPrices.FlatAppearance.BorderSize = 0;
            this.buttonPrices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonPrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrices.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrices.Location = new System.Drawing.Point(0, 227);
            this.buttonPrices.Name = "buttonPrices";
            this.buttonPrices.Size = new System.Drawing.Size(200, 53);
            this.buttonPrices.TabIndex = 3;
            this.buttonPrices.Text = "Catalogo de Precios";
            this.buttonPrices.UseVisualStyleBackColor = false;
            this.buttonPrices.Click += new System.EventHandler(this.ButtonPricesClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 53);
            this.panel1.TabIndex = 2;
            // 
            // buttonTables
            // 
            this.buttonTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTables.FlatAppearance.BorderSize = 0;
            this.buttonTables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTables.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTables.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTables.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTables.Location = new System.Drawing.Point(0, 109);
            this.buttonTables.Name = "buttonTables";
            this.buttonTables.Size = new System.Drawing.Size(200, 53);
            this.buttonTables.TabIndex = 1;
            this.buttonTables.Text = "Mesas";
            this.buttonTables.UseVisualStyleBackColor = false;
            this.buttonTables.Click += new System.EventHandler(this.ButtonTablesClick);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 103);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(200, 35);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1000, 565);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // timerTables
            // 
            this.timerTables.Enabled = true;
            this.timerTables.Interval = 1000;
            this.timerTables.Tick += new System.EventHandler(this.TimerTablesTick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelVertical);
            this.Controls.Add(this.panelTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuLoad);
            this.panelTittle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.panelVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
