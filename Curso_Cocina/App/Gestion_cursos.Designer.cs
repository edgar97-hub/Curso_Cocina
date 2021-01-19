namespace WindowsFormsApp1
{
    partial class Gestion_cursos
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
            this.name_receta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.RichTextBox();
            this.gestion_tema = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cursos = new System.Windows.Forms.DataGridView();
            this.crear_curso = new System.Windows.Forms.Button();
            this.profesor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buscar_curso = new System.Windows.Forms.Button();
            this.delete_curso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // name_receta
            // 
            this.name_receta.AutoSize = true;
            this.name_receta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_receta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_receta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name_receta.Location = new System.Drawing.Point(35, 64);
            this.name_receta.Name = "name_receta";
            this.name_receta.Size = new System.Drawing.Size(105, 21);
            this.name_receta.TabIndex = 22;
            this.name_receta.Text = "name_curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(38, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "temas";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(145, 59);
            this.name.Multiline = false;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 34);
            this.name.TabIndex = 14;
            this.name.Text = "";
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // gestion_tema
            // 
            this.gestion_tema.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.gestion_tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gestion_tema.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_tema.Location = new System.Drawing.Point(145, 114);
            this.gestion_tema.Name = "gestion_tema";
            this.gestion_tema.Size = new System.Drawing.Size(113, 28);
            this.gestion_tema.TabIndex = 79;
            this.gestion_tema.Text = "temas_receta";
            this.gestion_tema.UseVisualStyleBackColor = true;
            this.gestion_tema.Click += new System.EventHandler(this.gestion_tema_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(145, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 28);
            this.button2.TabIndex = 81;
            this.button2.Text = "gestion grupos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(38, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 80;
            this.label1.Text = "Grupos";
            // 
            // cursos
            // 
            this.cursos.AllowUserToAddRows = false;
            this.cursos.AllowUserToDeleteRows = false;
            this.cursos.AllowUserToResizeColumns = false;
            this.cursos.AllowUserToResizeRows = false;
            this.cursos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cursos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cursos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cursos.DefaultCellStyle = dataGridViewCellStyle1;
            this.cursos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cursos.Location = new System.Drawing.Point(42, 323);
            this.cursos.Name = "cursos";
            this.cursos.ReadOnly = true;
            this.cursos.RowHeadersWidth = 30;
            this.cursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cursos.ShowEditingIcon = false;
            this.cursos.Size = new System.Drawing.Size(587, 182);
            this.cursos.TabIndex = 82;
            // 
            // crear_curso
            // 
            this.crear_curso.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.crear_curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crear_curso.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear_curso.Location = new System.Drawing.Point(90, 523);
            this.crear_curso.Name = "crear_curso";
            this.crear_curso.Size = new System.Drawing.Size(116, 28);
            this.crear_curso.TabIndex = 83;
            this.crear_curso.Text = "Create ";
            this.crear_curso.UseVisualStyleBackColor = true;
            this.crear_curso.Click += new System.EventHandler(this.crear_curso_Click);
            // 
            // profesor
            // 
            this.profesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.profesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profesor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profesor.FormattingEnabled = true;
            this.profesor.Location = new System.Drawing.Point(145, 266);
            this.profesor.Name = "profesor";
            this.profesor.Size = new System.Drawing.Size(113, 25);
            this.profesor.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(38, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 94;
            this.label3.Text = "profesor";
            // 
            // buscar_curso
            // 
            this.buscar_curso.BackColor = System.Drawing.Color.White;
            this.buscar_curso.FlatAppearance.BorderSize = 0;
            this.buscar_curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar_curso.Image = global::WindowsFormsApp1.Properties.Resources.Webp_net_resizeimage__14_;
            this.buscar_curso.Location = new System.Drawing.Point(260, 59);
            this.buscar_curso.Name = "buscar_curso";
            this.buscar_curso.Size = new System.Drawing.Size(42, 34);
            this.buscar_curso.TabIndex = 15;
            this.buscar_curso.UseVisualStyleBackColor = false;
            this.buscar_curso.Click += new System.EventHandler(this.buscar_curso_Click);
            // 
            // delete_curso
            // 
            this.delete_curso.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delete_curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_curso.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_curso.Location = new System.Drawing.Point(233, 523);
            this.delete_curso.Name = "delete_curso";
            this.delete_curso.Size = new System.Drawing.Size(116, 28);
            this.delete_curso.TabIndex = 84;
            this.delete_curso.Text = "delete";
            this.delete_curso.UseVisualStyleBackColor = true;
            this.delete_curso.Click += new System.EventHandler(this.delete_curso_Click);
            // 
            // Gestion_cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 652);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profesor);
            this.Controls.Add(this.delete_curso);
            this.Controls.Add(this.crear_curso);
            this.Controls.Add(this.cursos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gestion_tema);
            this.Controls.Add(this.name_receta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscar_curso);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Gestion_cusos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_receta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscar_curso;
        private System.Windows.Forms.Button gestion_tema;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView cursos;
        public System.Windows.Forms.Button crear_curso;
        public System.Windows.Forms.ComboBox profesor;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox name;
        public System.Windows.Forms.Button delete_curso;
    }
}