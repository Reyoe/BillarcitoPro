/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 23/11/2019
 * Time: 10:51 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BillarcitoPro
{
	partial class FormMessage
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelTittle;
		private System.Windows.Forms.Label labelTittle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAccept;
		
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
			this.panelTittle = new System.Windows.Forms.Panel();
			this.labelTittle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonAccept = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panelTittle
			// 
			this.panelTittle.BackColor = System.Drawing.Color.Red;
			this.panelTittle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTittle.Location = new System.Drawing.Point(0, 0);
			this.panelTittle.Name = "panelTittle";
			this.panelTittle.Size = new System.Drawing.Size(426, 25);
			this.panelTittle.TabIndex = 3;
			// 
			// labelTittle
			// 
			this.labelTittle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelTittle.Location = new System.Drawing.Point(87, 28);
			this.labelTittle.Name = "labelTittle";
			this.labelTittle.Size = new System.Drawing.Size(251, 23);
			this.labelTittle.TabIndex = 11;
			this.labelTittle.Text = "Limite en la Mesa";
			this.labelTittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(12, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(402, 59);
			this.label1.TabIndex = 12;
			this.label1.Text = "Una mesa que está en juego terminó su tiempo.\r\nSe recomienda ir a la opción \"Mesa" +
	"s\" y  cobrar\r\nel tiempo de juego.\r\n";
			// 
			// buttonAccept
			// 
			this.buttonAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.buttonAccept.FlatAppearance.BorderSize = 0;
			this.buttonAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.buttonAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAccept.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAccept.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.buttonAccept.Location = new System.Drawing.Point(136, 145);
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.Size = new System.Drawing.Size(150, 31);
			this.buttonAccept.TabIndex = 1;
			this.buttonAccept.Text = "Aceptar";
			this.buttonAccept.UseVisualStyleBackColor = false;
			this.buttonAccept.Click += new System.EventHandler(this.ButtonAcceptClick);
			// 
			// FormMessage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(426, 200);
			this.Controls.Add(this.buttonAccept);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelTittle);
			this.Controls.Add(this.panelTittle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMessage";
			this.Opacity = 0.85D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMessage";
			this.ResumeLayout(false);

		}
	}
}
