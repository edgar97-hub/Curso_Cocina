namespace WindowsFormsApp1
{
    partial class creacion_temas
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
            this.delete_tema = new System.Windows.Forms.Button();
            this.add_tema = new System.Windows.Forms.Button();
            this.dataGrid_temas = new System.Windows.Forms.DataGridView();
            this.name_tema = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_temas)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_tema
            // 
            this.delete_tema.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.delete_tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_tema.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_tema.Location = new System.Drawing.Point(294, 192);
            this.delete_tema.Name = "delete_tema";
            this.delete_tema.Size = new System.Drawing.Size(67, 28);
            this.delete_tema.TabIndex = 30;
            this.delete_tema.Text = "delete";
            this.delete_tema.UseVisualStyleBackColor = true;
            this.delete_tema.Click += new System.EventHandler(this.delete_tema_Click);
            // 
            // add_tema
            // 
            this.add_tema.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.add_tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_tema.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_tema.Location = new System.Drawing.Point(294, 143);
            this.add_tema.Name = "add_tema";
            this.add_tema.Size = new System.Drawing.Size(67, 28);
            this.add_tema.TabIndex = 29;
            this.add_tema.Text = "add ";
            this.add_tema.UseVisualStyleBackColor = true;
            this.add_tema.Click += new System.EventHandler(this.add_tema_Click);
            // 
            // dataGrid_temas
            // 
            this.dataGrid_temas.AllowUserToAddRows = false;
            this.dataGrid_temas.AllowUserToDeleteRows = false;
            this.dataGrid_temas.AllowUserToResizeColumns = false;
            this.dataGrid_temas.AllowUserToResizeRows = false;
            this.dataGrid_temas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_temas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid_temas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_temas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_temas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_temas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_temas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid_temas.Location = new System.Drawing.Point(45, 143);
            this.dataGrid_temas.Name = "dataGrid_temas";
            this.dataGrid_temas.ReadOnly = true;
            this.dataGrid_temas.RowHeadersWidth = 30;
            this.dataGrid_temas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_temas.ShowEditingIcon = false;
            this.dataGrid_temas.Size = new System.Drawing.Size(243, 149);
            this.dataGrid_temas.TabIndex = 28;
            this.dataGrid_temas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_temas_CellClick);
            // 
            // name_tema
            // 
            this.name_tema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tema.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tema.Location = new System.Drawing.Point(103, 87);
            this.name_tema.Multiline = false;
            this.name_tema.Name = "name_tema";
            this.name_tema.Size = new System.Drawing.Size(153, 34);
            this.name_tema.TabIndex = 27;
            this.name_tema.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(41, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "name";
            // 
            // atras
            // 
            this.atras.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Image = global::WindowsFormsApp1.Properties.Resources.Webp_net_resizeimage__15_;
            this.atras.Location = new System.Drawing.Point(83, 307);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(82, 32);
            this.atras.TabIndex = 81;
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // creacion_temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 345);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.delete_tema);
            this.Controls.Add(this.add_tema);
            this.Controls.Add(this.dataGrid_temas);
            this.Controls.Add(this.name_tema);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "creacion_temas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "creacion_temas";
            this.Load += new System.EventHandler(this.creacion_temas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_temas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_tema;
        public System.Windows.Forms.Button add_tema;
        public System.Windows.Forms.DataGridView dataGrid_temas;
        public System.Windows.Forms.RichTextBox name_tema;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button atras;
    }
}