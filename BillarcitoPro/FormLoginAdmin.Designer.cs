/*
 * Created by SharpDevelop.
 * User: ivana
 * Date: 21/11/2019
 * Time: 07:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BillarcitoPro
{
	partial class AdminLoginForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelTittle;
		private System.Windows.Forms.Panel panelVertical;
		private System.Windows.Forms.PictureBox buttonClose;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonLOGIN;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.panelTittle = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.panelVertical = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLOGIN = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.panelTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.panelVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTittle
            // 
            this.panelTittle.BackColor = System.Drawing.Color.Red;
            this.panelTittle.Controls.Add(this.buttonClose);
            this.panelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittle.Location = new System.Drawing.Point(0, 0);
            this.panelTittle.Name = "panelTittle";
            this.panelTittle.Size = new System.Drawing.Size(566, 25);
            this.panelTittle.TabIndex = 0;
            this.panelTittle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTittleMouseDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(541, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonCloseClick);
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.Red;
            this.panelVertical.Controls.Add(this.pictureBox1);
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical.Location = new System.Drawing.Point(0, 25);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(201, 275);
            this.panelVertical.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(227, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "_____________________________________________________";
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxUser.Location = new System.Drawing.Point(227, 92);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(305, 16);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.Text = "USUARIO";
            this.textBoxUser.Enter += new System.EventHandler(this.TextBoxUserEnter);
            this.textBoxUser.Leave += new System.EventHandler(this.TextBoxUserLeave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassword.Location = new System.Drawing.Point(227, 143);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(305, 16);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "CONTRASEÑA";
            this.textBoxPassword.Enter += new System.EventHandler(this.TextBoxPasswordEnter);
            this.textBoxPassword.Leave += new System.EventHandler(this.TextBoxPasswordLeave);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(227, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "_____________________________________________________";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(270, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN Administrador";
            // 
            // buttonLOGIN
            // 
            this.buttonLOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonLOGIN.FlatAppearance.BorderSize = 0;
            this.buttonLOGIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonLOGIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLOGIN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLOGIN.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonLOGIN.Location = new System.Drawing.Point(240, 237);
            this.buttonLOGIN.Name = "buttonLOGIN";
            this.buttonLOGIN.Size = new System.Drawing.Size(263, 40);
            this.buttonLOGIN.TabIndex = 3;
            this.buttonLOGIN.Text = "Iniciar Sesión";
            this.buttonLOGIN.UseVisualStyleBackColor = false;
            this.buttonLOGIN.Click += new System.EventHandler(this.ButtonLOGINClick);
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(227, 192);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(305, 20);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "Error: ";
            this.labelError.Visible = false;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(566, 300);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonLOGIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelVertical);
            this.Controls.Add(this.panelTittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLoginForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginForm";
            this.panelTittle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.panelVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
