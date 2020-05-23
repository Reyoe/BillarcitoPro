/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 22/11/2019
 * Time: 06:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BillarcitoPro
{
	partial class FormEmployees
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxEmpPass;
		private System.Windows.Forms.Button buttonSaveEmployee;
		private System.Windows.Forms.TextBox textBoxEmpUser;
		private System.Windows.Forms.TextBox textBoxEmpTel;
		private System.Windows.Forms.TextBox textBoxEmpLName;
		private System.Windows.Forms.TextBox textBoxEmpName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewEmployee;
		private System.Windows.Forms.Button buttonDeleteEmployee;
		private System.Windows.Forms.Button buttonEditEmployee;
		private System.Windows.Forms.ComboBox comboBoxPosition;
		private System.Windows.Forms.Label label3;
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelError = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxPosition = new System.Windows.Forms.ComboBox();
			this.textBoxEmpPass = new System.Windows.Forms.TextBox();
			this.buttonSaveEmployee = new System.Windows.Forms.Button();
			this.textBoxEmpUser = new System.Windows.Forms.TextBox();
			this.textBoxEmpTel = new System.Windows.Forms.TextBox();
			this.textBoxEmpLName = new System.Windows.Forms.TextBox();
			this.textBoxEmpName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
			this.buttonDeleteEmployee = new System.Windows.Forms.Button();
			this.buttonEditEmployee = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
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
			this.label1.Size = new System.Drawing.Size(220, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "TRABAJADORES";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.panel1.Controls.Add(this.labelError);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.comboBoxPosition);
			this.panel1.Controls.Add(this.textBoxEmpPass);
			this.panel1.Controls.Add(this.buttonSaveEmployee);
			this.panel1.Controls.Add(this.textBoxEmpUser);
			this.panel1.Controls.Add(this.textBoxEmpTel);
			this.panel1.Controls.Add(this.textBoxEmpLName);
			this.panel1.Controls.Add(this.textBoxEmpName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(630, 47);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(370, 518);
			this.panel1.TabIndex = 2;
			// 
			// labelError
			// 
			this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(14, 445);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(344, 64);
			this.labelError.TabIndex = 16;
			this.labelError.Text = "Error: ";
			this.labelError.Visible = false;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DimGray;
			this.label3.Location = new System.Drawing.Point(22, 327);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "POSICION:";
			// 
			// comboBoxPosition
			// 
			this.comboBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxPosition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxPosition.ForeColor = System.Drawing.Color.LightGray;
			this.comboBoxPosition.FormattingEnabled = true;
			this.comboBoxPosition.Items.AddRange(new object[] {
			"EMPLEADO",
			"ADMINISTRADOR"});
			this.comboBoxPosition.Location = new System.Drawing.Point(140, 327);
			this.comboBoxPosition.Name = "comboBoxPosition";
			this.comboBoxPosition.Size = new System.Drawing.Size(218, 25);
			this.comboBoxPosition.TabIndex = 6;
			// 
			// textBoxEmpPass
			// 
			this.textBoxEmpPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxEmpPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxEmpPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEmpPass.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxEmpPass.Location = new System.Drawing.Point(22, 281);
			this.textBoxEmpPass.Name = "textBoxEmpPass";
			this.textBoxEmpPass.Size = new System.Drawing.Size(336, 23);
			this.textBoxEmpPass.TabIndex = 5;
			this.textBoxEmpPass.Text = "CONTRASEÑA";
			this.textBoxEmpPass.Enter += new System.EventHandler(this.TextBoxEmpPassEnter);
			this.textBoxEmpPass.Leave += new System.EventHandler(this.TextBoxEmpPassLeave);
			// 
			// buttonSaveEmployee
			// 
			this.buttonSaveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.buttonSaveEmployee.FlatAppearance.BorderSize = 0;
			this.buttonSaveEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonSaveEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonSaveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSaveEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSaveEmployee.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonSaveEmployee.Location = new System.Drawing.Point(14, 393);
			this.buttonSaveEmployee.Name = "buttonSaveEmployee";
			this.buttonSaveEmployee.Size = new System.Drawing.Size(344, 40);
			this.buttonSaveEmployee.TabIndex = 7;
			this.buttonSaveEmployee.Text = "Guardar";
			this.buttonSaveEmployee.UseVisualStyleBackColor = false;
			this.buttonSaveEmployee.Click += new System.EventHandler(this.ButtonSaveEmployeeClick);
			// 
			// textBoxEmpUser
			// 
			this.textBoxEmpUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxEmpUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxEmpUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEmpUser.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxEmpUser.Location = new System.Drawing.Point(22, 230);
			this.textBoxEmpUser.Name = "textBoxEmpUser";
			this.textBoxEmpUser.Size = new System.Drawing.Size(336, 23);
			this.textBoxEmpUser.TabIndex = 4;
			this.textBoxEmpUser.Text = "USUARIO";
			this.textBoxEmpUser.Enter += new System.EventHandler(this.TextBoxEmpUserEnter);
			this.textBoxEmpUser.Leave += new System.EventHandler(this.TextBoxEmpUserLeave);
			// 
			// textBoxEmpTel
			// 
			this.textBoxEmpTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxEmpTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxEmpTel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEmpTel.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxEmpTel.Location = new System.Drawing.Point(22, 179);
			this.textBoxEmpTel.Name = "textBoxEmpTel";
			this.textBoxEmpTel.Size = new System.Drawing.Size(336, 23);
			this.textBoxEmpTel.TabIndex = 3;
			this.textBoxEmpTel.Text = "TELEFONO";
			this.textBoxEmpTel.Enter += new System.EventHandler(this.TextBoxEmpTelEnter);
			this.textBoxEmpTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEmpTelKeyPress);
			this.textBoxEmpTel.Leave += new System.EventHandler(this.TextBoxEmpTelLeave);
			// 
			// textBoxEmpLName
			// 
			this.textBoxEmpLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxEmpLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxEmpLName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEmpLName.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxEmpLName.Location = new System.Drawing.Point(22, 128);
			this.textBoxEmpLName.Name = "textBoxEmpLName";
			this.textBoxEmpLName.Size = new System.Drawing.Size(336, 23);
			this.textBoxEmpLName.TabIndex = 2;
			this.textBoxEmpLName.Text = "APELLIDO(S)";
			this.textBoxEmpLName.Enter += new System.EventHandler(this.TextBoxEmpLNameEnter);
			this.textBoxEmpLName.Leave += new System.EventHandler(this.TextBoxEmpLNameLeave);
			// 
			// textBoxEmpName
			// 
			this.textBoxEmpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.textBoxEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxEmpName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEmpName.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxEmpName.Location = new System.Drawing.Point(22, 77);
			this.textBoxEmpName.Name = "textBoxEmpName";
			this.textBoxEmpName.Size = new System.Drawing.Size(336, 23);
			this.textBoxEmpName.TabIndex = 1;
			this.textBoxEmpName.Text = "NOMBRE(S)";
			this.textBoxEmpName.Enter += new System.EventHandler(this.TextBoxEmpNameEnter);
			this.textBoxEmpName.Leave += new System.EventHandler(this.TextBoxEmpNameLeave);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label2.Location = new System.Drawing.Point(22, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Datos del trabajador:";
			// 
			// dataGridViewEmployee
			// 
			this.dataGridViewEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmployee.Location = new System.Drawing.Point(28, 68);
			this.dataGridViewEmployee.Name = "dataGridViewEmployee";
			this.dataGridViewEmployee.Size = new System.Drawing.Size(560, 390);
			this.dataGridViewEmployee.TabIndex = 5;
			// 
			// buttonDeleteEmployee
			// 
			this.buttonDeleteEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.buttonDeleteEmployee.FlatAppearance.BorderSize = 0;
			this.buttonDeleteEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonDeleteEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeleteEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeleteEmployee.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonDeleteEmployee.Location = new System.Drawing.Point(324, 492);
			this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
			this.buttonDeleteEmployee.Size = new System.Drawing.Size(175, 40);
			this.buttonDeleteEmployee.TabIndex = 9;
			this.buttonDeleteEmployee.Text = "Eliminar Trabajador";
			this.buttonDeleteEmployee.UseVisualStyleBackColor = false;
			this.buttonDeleteEmployee.Click += new System.EventHandler(this.ButtonDeleteEmployeeClick);
			// 
			// buttonEditEmployee
			// 
			this.buttonEditEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.buttonEditEmployee.FlatAppearance.BorderSize = 0;
			this.buttonEditEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonEditEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonEditEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEditEmployee.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonEditEmployee.Location = new System.Drawing.Point(89, 492);
			this.buttonEditEmployee.Name = "buttonEditEmployee";
			this.buttonEditEmployee.Size = new System.Drawing.Size(175, 40);
			this.buttonEditEmployee.TabIndex = 8;
			this.buttonEditEmployee.Text = "Editar Trabajador";
			this.buttonEditEmployee.UseVisualStyleBackColor = false;
			this.buttonEditEmployee.Click += new System.EventHandler(this.ButtonEditEmployeeClick);
			// 
			// FormEmployees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(1000, 565);
			this.Controls.Add(this.buttonDeleteEmployee);
			this.Controls.Add(this.buttonEditEmployee);
			this.Controls.Add(this.dataGridViewEmployee);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormEmployees";
			this.Text = "FormEmployees";
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
