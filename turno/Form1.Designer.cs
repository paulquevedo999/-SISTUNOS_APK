
namespace turno
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel44 = new System.Windows.Forms.Panel();
            this.cargando = new System.Windows.Forms.PictureBox();
            this.txtservicio = new System.Windows.Forms.TextBox();
            this.preferencialopt = new System.Windows.Forms.CheckBox();
            this.TXTINICIAL = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel44.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargando)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(944, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 29);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(982, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 29);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel44
            // 
            this.panel44.AutoScroll = true;
            this.panel44.BackColor = System.Drawing.Color.White;
            this.panel44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel44.Controls.Add(this.cargando);
            this.panel44.Location = new System.Drawing.Point(1, 40);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(1030, 602);
            this.panel44.TabIndex = 140;
            // 
            // cargando
            // 
            this.cargando.Image = ((System.Drawing.Image)(resources.GetObject("cargando.Image")));
            this.cargando.Location = new System.Drawing.Point(98, 206);
            this.cargando.Name = "cargando";
            this.cargando.Size = new System.Drawing.Size(844, 152);
            this.cargando.TabIndex = 0;
            this.cargando.TabStop = false;
            this.cargando.Visible = false;
            // 
            // txtservicio
            // 
            this.txtservicio.Location = new System.Drawing.Point(611, 6);
            this.txtservicio.Name = "txtservicio";
            this.txtservicio.Size = new System.Drawing.Size(275, 20);
            this.txtservicio.TabIndex = 0;
            this.txtservicio.Visible = false;
            // 
            // preferencialopt
            // 
            this.preferencialopt.Appearance = System.Windows.Forms.Appearance.Button;
            this.preferencialopt.AutoSize = true;
            this.preferencialopt.BackColor = System.Drawing.Color.Gainsboro;
            this.preferencialopt.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.preferencialopt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preferencialopt.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.preferencialopt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.preferencialopt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preferencialopt.Location = new System.Drawing.Point(2, 3);
            this.preferencialopt.Name = "preferencialopt";
            this.preferencialopt.Size = new System.Drawing.Size(215, 33);
            this.preferencialopt.TabIndex = 141;
            this.preferencialopt.Text = "TURNO PREFERENCIAL";
            this.preferencialopt.UseVisualStyleBackColor = false;
            this.preferencialopt.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TXTINICIAL
            // 
            this.TXTINICIAL.Location = new System.Drawing.Point(487, 7);
            this.TXTINICIAL.Name = "TXTINICIAL";
            this.TXTINICIAL.Size = new System.Drawing.Size(118, 20);
            this.TXTINICIAL.TabIndex = 142;
            this.TXTINICIAL.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 143;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1030, 641);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TXTINICIAL);
            this.Controls.Add(this.txtservicio);
            this.Controls.Add(this.preferencialopt);
            this.Controls.Add(this.panel44);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnero";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel44.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel44;
        private System.Windows.Forms.TextBox txtservicio;
        private System.Windows.Forms.CheckBox preferencialopt;
        private System.Windows.Forms.TextBox TXTINICIAL;
        private System.Windows.Forms.PictureBox cargando;
        private System.Windows.Forms.Button button3;
    }
}

