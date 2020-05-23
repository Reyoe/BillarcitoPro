/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 22/11/2019
 * Time: 05:55 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BillarcitoPro
{
	partial class FormClients
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonSaveClient;
		private System.Windows.Forms.TextBox textBoxClientUser;
		private System.Windows.Forms.TextBox textBoxClientLName;
		private System.Windows.Forms.TextBox textBoxClientName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewClients;
		private System.Windows.Forms.Button buttonDeleteClient;
		private System.Windows.Forms.Button buttonEditClient;
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelError = new System.Windows.Forms.Label();
			this.buttonSaveClient = new System.Windows.Forms.Button();
			this.textBoxClientUser = new System.Windows.Forms.TextBox();
			this.textBoxClientLName = new System.Windows.Forms.TextBox();
			this.textBoxClientName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewClients = new System.Windows.Forms.DataGridView();
			this.buttonDeleteClient = new System.Windows.Forms.Button();
			this.buttonEditClient = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
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
			this.label1.Size = new System.Drawing.Size(182, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "CLIENTES";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.panel1.Controls.Add(this.labelError);
			this.panel1.Controls.Add(this.buttonSaveClient);
			this.panel1.Controls.Add(this.textBoxClientUser);
			this.panel1.Controls.Add(this.textBoxClientLName);
			this.panel1.Controls.Add(this.textBoxClientName);
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
			this.labelError.Location = new System.Drawing.Point(14, 295);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(344, 203);
			this.labelError.TabIndex = 11;
			this.labelError.Text = "Error: ";
			this.labelError.Visible = false;
			// 
			// buttonSaveClient
			// 
			this.buttonSaveClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.buttonSaveClient.FlatAppearance.BorderSize = 0;
			this.buttonSaveClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonSaveClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSaveClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSaveClient.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSaveClient.Location = new System.Drawing.Point(14, 222);
			this.buttonSaveClient.Name = "buttonSaveClient";
			this.buttonSaveClient.Size = new System.Drawing.Size(344, 40);
			this.buttonSaveClient.TabIndex = 4;
			this.buttonSaveClient.Text = "Guardar";
			this.buttonSaveClient.UseVisualStyleBackColor = false;
			this.buttonSaveClient.Click += new System.EventHandler(this.ButtonSaveClientClick);
			// 
			// textBoxClientUser
			// 
			this.textBoxClientUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxClientUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxClientUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxClientUser.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxClientUser.Location = new System.Drawing.Point(22, 179);
			this.textBoxClientUser.Name = "textBoxClientUser";
			this.textBoxClientUser.Size = new System.Drawing.Size(336, 23);
			this.textBoxClientUser.TabIndex = 3;
			this.textBoxClientUser.Text = "USUARIO/CLAVE DEL CLIENTE";
			this.textBoxClientUser.Enter += new System.EventHandler(this.TextBoxClientUserEnter);
			this.textBoxClientUser.Leave += new System.EventHandler(this.TextBoxClientUserLeave);
			// 
			// textBoxClientLName
			// 
			this.textBoxClientLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxClientLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxClientLName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxClientLName.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxClientLName.Location = new System.Drawing.Point(22, 128);
			this.textBoxClientLName.Name = "textBoxClientLName";
			this.textBoxClientLName.Size = new System.Drawing.Size(336, 23);
			this.textBoxClientLName.TabIndex = 2;
			this.textBoxClientLName.Text = "APELLIDO(S)";
			this.textBoxClientLName.Enter += new System.EventHandler(this.TextBoxClientLNameEnter);
			this.textBoxClientLName.Leave += new System.EventHandler(this.TextBoxClientLNameLeave);
			// 
			// textBoxClientName
			// 
			this.textBoxClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxClientName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxClientName.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxClientName.Location = new System.Drawing.Point(22, 77);
			this.textBoxClientName.Name = "textBoxClientName";
			this.textBoxClientName.Size = new System.Drawing.Size(336, 23);
			this.textBoxClientName.TabIndex = 1;
			this.textBoxClientName.Text = "NOMBRE(S)";
			this.textBoxClientName.Enter += new System.EventHandler(this.TextBoxClientNameEnter);
			this.textBoxClientName.Leave += new System.EventHandler(this.TextBoxClientNameLeave);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label2.Location = new System.Drawing.Point(22, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Datos de los clientes:";
			// 
			// dataGridViewClients
			// 
			this.dataGridViewClients.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewClients.Location = new System.Drawing.Point(28, 68);
			this.dataGridViewClients.Name = "dataGridViewClients";
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dataGridViewClients.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewClients.Size = new System.Drawing.Size(560, 390);
			this.dataGridViewClients.TabIndex = 5;
			// 
			// buttonDeleteClient
			// 
			this.buttonDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonDeleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.buttonDeleteClient.FlatAppearance.BorderSize = 0;
			this.buttonDeleteClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonDeleteClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeleteClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeleteClient.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonDeleteClient.Location = new System.Drawing.Point(324, 492);
			this.buttonDeleteClient.Name = "buttonDeleteClient";
			this.buttonDeleteClient.Size = new System.Drawing.Size(175, 40);
			this.buttonDeleteClient.TabIndex = 6;
			this.buttonDeleteClient.Text = "Eliminar Cliente";
			this.buttonDeleteClient.UseVisualStyleBackColor = false;
			this.buttonDeleteClient.Click += new System.EventHandler(this.ButtonDeleteClientClick);
			// 
			// buttonEditClient
			// 
			this.buttonEditClient.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.buttonEditClient.FlatAppearance.BorderSize = 0;
			this.buttonEditClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonEditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEditClient.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonEditClient.Location = new System.Drawing.Point(89, 492);
			this.buttonEditClient.Name = "buttonEditClient";
			this.buttonEditClient.Size = new System.Drawing.Size(175, 40);
			this.buttonEditClient.TabIndex = 5;
			this.buttonEditClient.Text = "Editar Cliente";
			this.buttonEditClient.UseVisualStyleBackColor = false;
			this.buttonEditClient.Click += new System.EventHandler(this.ButtonEditClientClick);
			// 
			// FormClients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(1000, 565);
			this.Controls.Add(this.buttonDeleteClient);
			this.Controls.Add(this.buttonEditClient);
			this.Controls.Add(this.dataGridViewClients);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormClients";
			this.Text = "FormClients";
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
