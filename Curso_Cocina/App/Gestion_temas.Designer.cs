namespace WindowsFormsApp1
{
    partial class Gestion_temas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.name_receta = new System.Windows.Forms.RichTextBox();
            this.list_temas_rece = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.editar_receta = new System.Windows.Forms.Button();
            this.temas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ayuda_receta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_temas_rece)).BeginInit();
            this.SuspendLayout();
            // 
            // name_receta
            // 
            this.name_receta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_receta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_receta.Location = new System.Drawing.Point(166, 81);
            this.name_receta.Multiline = false;
            this.name_receta.Name = "name_receta";
            this.name_receta.Size = new System.Drawing.Size(146, 34);
            this.name_receta.TabIndex = 16;
            this.name_receta.Text = "";
            // 
            // list_temas_rece
            // 
            this.list_temas_rece.AllowUserToAddRows = false;
            this.list_temas_rece.AllowUserToDeleteRows = false;
            this.list_temas_rece.AllowUserToResizeColumns = false;
            this.list_temas_rece.AllowUserToResizeRows = false;
            this.list_temas_rece.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.list_temas_rece.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.list_temas_rece.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.list_temas_rece.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.list_temas_rece.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.list_temas_rece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_temas_rece.DefaultCellStyle = dataGridViewCellStyle1;
            this.list_temas_rece.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.list_temas_rece.Location = new System.Drawing.Point(41, 266);
            this.list_temas_rece.Name = "list_temas_rece";
            this.list_temas_rece.ReadOnly = true;
            this.list_temas_rece.RowHeadersWidth = 30;
            this.list_temas_rece.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.list_temas_rece.ShowEditingIcon = false;
            this.list_temas_rece.Size = new System.Drawing.Size(404, 182);
            this.list_temas_rece.TabIndex = 45;
            this.list_temas_rece.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_temas_rece_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "name receta";
            // 
            // insert
            // 
            this.insert.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(466, 297);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(89, 28);
            this.insert.TabIndex = 76;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // delete
            // 
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(466, 351);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 28);
            this.delete.TabIndex = 77;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // editar_receta
            // 
            this.editar_receta.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.editar_receta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar_receta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_receta.Location = new System.Drawing.Point(166, 194);
            this.editar_receta.Name = "editar_receta";
            this.editar_receta.Size = new System.Drawing.Size(89, 28);
            this.editar_receta.TabIndex = 78;
            this.editar_receta.Text = "view receta";
            this.editar_receta.UseVisualStyleBackColor = true;
            this.editar_receta.Click += new System.EventHandler(this.editar_receta_Click);
            // 
            // temas
            // 
            this.temas.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.temas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temas.Location = new System.Drawing.Point(41, 194);
            this.temas.Name = "temas";
            this.temas.Size = new System.Drawing.Size(89, 28);
            this.temas.TabIndex = 79;
            this.temas.Text = "temas";
            this.temas.UseVisualStyleBackColor = true;
            this.temas.Click += new System.EventHandler(this.temas_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.Webp_net_resizeimage__15_;
            this.button1.Location = new System.Drawing.Point(166, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 80;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ayuda_receta
            // 
            this.ayuda_receta.BackColor = System.Drawing.Color.White;
            this.ayuda_receta.FlatAppearance.BorderSize = 0;
            this.ayuda_receta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayuda_receta.Image = global::WindowsFormsApp1.Properties.Resources.Webp_net_resizeimage__14_;
            this.ayuda_receta.Location = new System.Drawing.Point(271, 81);
            this.ayuda_receta.Name = "ayuda_receta";
            this.ayuda_receta.Size = new System.Drawing.Size(41, 34);
            this.ayuda_receta.TabIndex = 17;
            this.ayuda_receta.UseVisualStyleBackColor = false;
            this.ayuda_receta.Click += new System.EventHandler(this.ayuda_receta_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 28);
            this.button2.TabIndex = 81;
            this.button2.Text = "recetas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gestion_temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 539);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.temas);
            this.Controls.Add(this.editar_receta);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list_temas_rece);
            this.Controls.Add(this.ayuda_receta);
            this.Controls.Add(this.name_receta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_temas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion_temas";
            this.Load += new System.EventHandler(this.Gestion_temas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_temas_rece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ayuda_receta;
        private System.Windows.Forms.RichTextBox name_receta;
        public System.Windows.Forms.DataGridView list_temas_rece;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button editar_receta;
        private System.Windows.Forms.Button temas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}