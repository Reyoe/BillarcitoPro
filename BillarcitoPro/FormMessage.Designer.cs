﻿/*
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessage));
            this.panelTittle = new System.Windows.Forms.Panel();
            this.labelTittle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.aqua = new System.Windows.Forms.PictureBox();
            this.kuro = new System.Windows.Forms.PictureBox();
            this.violet = new System.Windows.Forms.PictureBox();
            this.Asuna = new System.Windows.Forms.PictureBox();
            this.bocchi = new System.Windows.Forms.PictureBox();
            this.rem = new System.Windows.Forms.PictureBox();
            this.yui = new System.Windows.Forms.PictureBox();
            this.taiga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.violet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Asuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocchi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiga)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTittle
            // 
            this.panelTittle.BackColor = System.Drawing.Color.Red;
            this.panelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittle.Location = new System.Drawing.Point(0, 0);
            this.panelTittle.Name = "panelTittle";
            this.panelTittle.Size = new System.Drawing.Size(483, 25);
            this.panelTittle.TabIndex = 3;
            // 
            // labelTittle
            // 
            this.labelTittle.BackColor = System.Drawing.Color.Transparent;
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 59);
            this.label1.TabIndex = 12;
            this.label1.Text = "Una mesa que está en juego terminó su tiempo.\r\nSe recomienda ir a la opción \"Mesa" +
    "s\" y  cobrar\r\nel tiempo de juego.\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.Gray;
            this.buttonAccept.FlatAppearance.BorderSize = 0;
            this.buttonAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccept.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAccept.Location = new System.Drawing.Point(136, 145);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(150, 31);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Aceptar";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.ButtonAcceptClick);
            // 
            // aqua
            // 
            this.aqua.BackColor = System.Drawing.Color.Transparent;
            this.aqua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aqua.BackgroundImage")));
            this.aqua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aqua.Location = new System.Drawing.Point(276, -12);
            this.aqua.Name = "aqua";
            this.aqua.Size = new System.Drawing.Size(248, 273);
            this.aqua.TabIndex = 13;
            this.aqua.TabStop = false;
            this.aqua.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kuro
            // 
            this.kuro.BackColor = System.Drawing.Color.Transparent;
            this.kuro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kuro.BackgroundImage")));
            this.kuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kuro.Location = new System.Drawing.Point(276, 31);
            this.kuro.Name = "kuro";
            this.kuro.Size = new System.Drawing.Size(207, 193);
            this.kuro.TabIndex = 14;
            this.kuro.TabStop = false;
            // 
            // violet
            // 
            this.violet.BackColor = System.Drawing.Color.Transparent;
            this.violet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("violet.BackgroundImage")));
            this.violet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.violet.Location = new System.Drawing.Point(276, 12);
            this.violet.Name = "violet";
            this.violet.Size = new System.Drawing.Size(207, 221);
            this.violet.TabIndex = 15;
            this.violet.TabStop = false;
            // 
            // Asuna
            // 
            this.Asuna.BackColor = System.Drawing.Color.Transparent;
            this.Asuna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Asuna.BackgroundImage")));
            this.Asuna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Asuna.Location = new System.Drawing.Point(303, 45);
            this.Asuna.Name = "Asuna";
            this.Asuna.Size = new System.Drawing.Size(179, 164);
            this.Asuna.TabIndex = 16;
            this.Asuna.TabStop = false;
            // 
            // bocchi
            // 
            this.bocchi.BackColor = System.Drawing.Color.Transparent;
            this.bocchi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bocchi.BackgroundImage")));
            this.bocchi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bocchi.Location = new System.Drawing.Point(332, 31);
            this.bocchi.Name = "bocchi";
            this.bocchi.Size = new System.Drawing.Size(150, 201);
            this.bocchi.TabIndex = 17;
            this.bocchi.TabStop = false;
            // 
            // rem
            // 
            this.rem.BackColor = System.Drawing.Color.Transparent;
            this.rem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rem.BackgroundImage")));
            this.rem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rem.Location = new System.Drawing.Point(292, 32);
            this.rem.Name = "rem";
            this.rem.Size = new System.Drawing.Size(188, 192);
            this.rem.TabIndex = 18;
            this.rem.TabStop = false;
            // 
            // yui
            // 
            this.yui.BackColor = System.Drawing.Color.Transparent;
            this.yui.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yui.BackgroundImage")));
            this.yui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.yui.Location = new System.Drawing.Point(332, 45);
            this.yui.Name = "yui";
            this.yui.Size = new System.Drawing.Size(146, 159);
            this.yui.TabIndex = 19;
            this.yui.TabStop = false;
            // 
            // taiga
            // 
            this.taiga.BackColor = System.Drawing.Color.Transparent;
            this.taiga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taiga.BackgroundImage")));
            this.taiga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.taiga.Location = new System.Drawing.Point(292, 23);
            this.taiga.Name = "taiga";
            this.taiga.Size = new System.Drawing.Size(188, 210);
            this.taiga.TabIndex = 20;
            this.taiga.TabStop = false;
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(483, 236);
            this.Controls.Add(this.panelTittle);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taiga);
            this.Controls.Add(this.yui);
            this.Controls.Add(this.rem);
            this.Controls.Add(this.bocchi);
            this.Controls.Add(this.Asuna);
            this.Controls.Add(this.violet);
            this.Controls.Add(this.kuro);
            this.Controls.Add(this.aqua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMessage";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMessage";
            this.Load += new System.EventHandler(this.FormMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.violet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Asuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocchi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiga)).EndInit();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.PictureBox aqua;
        private System.Windows.Forms.PictureBox kuro;
        private System.Windows.Forms.PictureBox violet;
        private System.Windows.Forms.PictureBox Asuna;
        private System.Windows.Forms.PictureBox bocchi;
        private System.Windows.Forms.PictureBox rem;
        private System.Windows.Forms.PictureBox yui;
        private System.Windows.Forms.PictureBox taiga;
    }
}
