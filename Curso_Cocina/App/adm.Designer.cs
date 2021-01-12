namespace WindowsFormsApp1
{
    partial class adm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.manager_cursos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gestion_cursos1 = new WindowsFormsApp1.Gestion_cursos();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.manager_cursos);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 544);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 54);
            this.button4.TabIndex = 9;
            this.button4.Text = "      Home";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(15, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "     schedule";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Red;
            this.panel.Location = new System.Drawing.Point(0, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(10, 49);
            this.panel.TabIndex = 6;
            // 
            // manager_cursos
            // 
            this.manager_cursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manager_cursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manager_cursos.FlatAppearance.BorderSize = 0;
            this.manager_cursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager_cursos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_cursos.ForeColor = System.Drawing.Color.White;
            this.manager_cursos.Image = ((System.Drawing.Image)(resources.GetObject("manager_cursos.Image")));
            this.manager_cursos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.manager_cursos.Location = new System.Drawing.Point(12, 197);
            this.manager_cursos.Name = "manager_cursos";
            this.manager_cursos.Size = new System.Drawing.Size(185, 46);
            this.manager_cursos.TabIndex = 7;
            this.manager_cursos.Text = "      gestion cursos";
            this.manager_cursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manager_cursos.UseVisualStyleBackColor = false;
            this.manager_cursos.Click += new System.EventHandler(this.gestion_cursos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(9, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "    personal infor";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gestion_cursos1
            // 
            this.gestion_cursos1.Location = new System.Drawing.Point(203, 44);
            this.gestion_cursos1.Name = "gestion_cursos1";
            this.gestion_cursos1.Size = new System.Drawing.Size(672, 465);
            this.gestion_cursos1.TabIndex = 2;
            this.gestion_cursos1.Load += new System.EventHandler(this.gestion_cursos1_Load);
            // 
            // adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 544);
            this.Controls.Add(this.gestion_cursos1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button manager_cursos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private Gestion_cursos gestion_cursos1;
    }
}