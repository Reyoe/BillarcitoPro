/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 23/11/2019
 * Time: 01:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BillarcitoPro
{
	partial class FormTablesAdmin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox buttonClose;
		private System.Windows.Forms.Panel panelTittle;
		private System.Windows.Forms.Button buttonDeleteAll;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonDeleteReg;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTablesAdmin));
			this.buttonClose = new System.Windows.Forms.PictureBox();
			this.panelTittle = new System.Windows.Forms.Panel();
			this.buttonDeleteAll = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonDeleteReg = new System.Windows.Forms.Button();
			this.labelError = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
			this.panelTittle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonClose
			// 
			this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
			this.buttonClose.Location = new System.Drawing.Point(603, 0);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(25, 25);
			this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.buttonClose.TabIndex = 0;
			this.buttonClose.TabStop = false;
			this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// panelTittle
			// 
			this.panelTittle.BackColor = System.Drawing.Color.Red;
			this.panelTittle.Controls.Add(this.buttonClose);
			this.panelTittle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTittle.Location = new System.Drawing.Point(0, 0);
			this.panelTittle.Name = "panelTittle";
			this.panelTittle.Size = new System.Drawing.Size(631, 25);
			this.panelTittle.TabIndex = 1;
			this.panelTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTittleMouseDown);
			// 
			// buttonDeleteAll
			// 
			this.buttonDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.buttonDeleteAll.FlatAppearance.BorderSize = 0;
			this.buttonDeleteAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonDeleteAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeleteAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeleteAll.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonDeleteAll.Location = new System.Drawing.Point(23, 333);
			this.buttonDeleteAll.Name = "buttonDeleteAll";
			this.buttonDeleteAll.Size = new System.Drawing.Size(263, 40);
			this.buttonDeleteAll.TabIndex = 1;
			this.buttonDeleteAll.Text = "Eliminar Todo";
			this.buttonDeleteAll.UseVisualStyleBackColor = false;
			this.buttonDeleteAll.Click += new System.EventHandler(this.ButtonDeleteAllClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(23, 43);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(580, 223);
			this.dataGridView1.TabIndex = 5;
			// 
			// buttonDeleteReg
			// 
			this.buttonDeleteReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.buttonDeleteReg.FlatAppearance.BorderSize = 0;
			this.buttonDeleteReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonDeleteReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonDeleteReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeleteReg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeleteReg.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonDeleteReg.Location = new System.Drawing.Point(340, 333);
			this.buttonDeleteReg.Name = "buttonDeleteReg";
			this.buttonDeleteReg.Size = new System.Drawing.Size(263, 40);
			this.buttonDeleteReg.TabIndex = 2;
			this.buttonDeleteReg.Text = "Eliminar Registro";
			this.buttonDeleteReg.UseVisualStyleBackColor = false;
			this.buttonDeleteReg.Click += new System.EventHandler(this.ButtonDeleteRegClick);
			// 
			// labelError
			// 
			this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(23, 269);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(580, 51);
			this.labelError.TabIndex = 7;
			this.labelError.Text = "Error:";
			this.labelError.Visible = false;
			// 
			// FormTablesAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(631, 400);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.buttonDeleteReg);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonDeleteAll);
			this.Controls.Add(this.panelTittle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormTablesAdmin";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormTablesAdmin";
			((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
			this.panelTittle.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
