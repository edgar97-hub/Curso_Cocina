namespace WindowsFormsApp1
{
    partial class Gestion_Receta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_rece = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ingredientes = new System.Windows.Forms.Panel();
            this.preparacion = new System.Windows.Forms.Panel();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_receta = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.preparacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_rece
            // 
            this.name_rece.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_rece.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_rece.Location = new System.Drawing.Point(57, 77);
            this.name_rece.Multiline = false;
            this.name_rece.Name = "name_rece";
            this.name_rece.Size = new System.Drawing.Size(204, 34);
            this.name_rece.TabIndex = 0;
            this.name_rece.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.Webp_net_resizeimage__14_;
            this.button1.Location = new System.Drawing.Point(219, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 34);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ingredientes
            // 
            this.ingredientes.AutoScroll = true;
            this.ingredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ingredientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ingredientes.Location = new System.Drawing.Point(50, 203);
            this.ingredientes.Name = "ingredientes";
            this.ingredientes.Size = new System.Drawing.Size(305, 309);
            this.ingredientes.TabIndex = 3;
            // 
            // preparacion
            // 
            this.preparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.preparacion.Controls.Add(this.richTextBox4);
            this.preparacion.Location = new System.Drawing.Point(378, 203);
            this.preparacion.Name = "preparacion";
            this.preparacion.Size = new System.Drawing.Size(297, 309);
            this.preparacion.TabIndex = 4;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(11, 13);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox4.Size = new System.Drawing.Size(274, 284);
            this.richTextBox4.TabIndex = 2;
            this.richTextBox4.Text = "";
            // 
            // guardar
            // 
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(470, 534);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(86, 34);
            this.guardar.TabIndex = 5;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(49, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "ingredientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(385, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "preparacion";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(378, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 138);
            this.panel1.TabIndex = 12;
            // 
            // name_receta
            // 
            this.name_receta.AutoSize = true;
            this.name_receta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_receta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_receta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name_receta.Location = new System.Drawing.Point(53, 30);
            this.name_receta.Name = "name_receta";
            this.name_receta.Size = new System.Drawing.Size(117, 21);
            this.name_receta.TabIndex = 11;
            this.name_receta.Text = "name_receta";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.Webp_net_resizeimage__15_;
            this.button2.Location = new System.Drawing.Point(255, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 41);
            this.button2.TabIndex = 81;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gestion_Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 580);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.name_receta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.preparacion);
            this.Controls.Add(this.ingredientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_rece);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Receta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receta";
            this.Load += new System.EventHandler(this.Gestion_Receta_Load);
            this.preparacion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox name_rece;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ingredientes;
        private System.Windows.Forms.Panel preparacion;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name_receta;
        private System.Windows.Forms.Button button2;
    }
}