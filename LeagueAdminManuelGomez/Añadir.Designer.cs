namespace LeagueAdminManuelGomez
{
    partial class Añadir
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCB = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new LeagueAdminManuelGomez.BotonPersonalizado();
            this.btnAñadir = new LeagueAdminManuelGomez.BotonPersonalizado();
            this.txtID = new MaterialSkin.Controls.MaterialTextBox();
            this.txt2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt3 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt4 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt5 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt6 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt7 = new MaterialSkin.Controls.MaterialTextBox();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCB
            // 
            this.lblCB.AutoSize = true;
            this.lblCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCB.Location = new System.Drawing.Point(23, 26);
            this.lblCB.Name = "lblCB";
            this.lblCB.Size = new System.Drawing.Size(200, 25);
            this.lblCB.TabIndex = 1;
            this.lblCB.Text = "Seleccione la tabla:";
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "Arbitros",
            "Estadios",
            "Equipos"});
            this.cb.Location = new System.Drawing.Point(229, 32);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(158, 21);
            this.cb.TabIndex = 5;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Red;
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.Red;
            this.btnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(693, 22);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(202, 39);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "LIMPIAR CAMPOS";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAñadir.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnAñadir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAñadir.BorderRadius = 20;
            this.btnAñadir.BorderSize = 0;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(465, 22);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(189, 39);
            this.btnAñadir.TabIndex = 6;
            this.btnAñadir.Text = "AÑADIR";
            this.btnAñadir.TextColor = System.Drawing.Color.White;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtID
            // 
            this.txtID.AnimateReadOnly = false;
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Depth = 0;
            this.txtID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtID.LeadingIcon = null;
            this.txtID.Location = new System.Drawing.Point(3, 3);
            this.txtID.MaxLength = 50;
            this.txtID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(250, 50);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "";
            this.txtID.TrailingIcon = null;
            this.txtID.Visible = false;
            // 
            // txt2
            // 
            this.txt2.AnimateReadOnly = false;
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt2.Depth = 0;
            this.txt2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt2.LeadingIcon = null;
            this.txt2.Location = new System.Drawing.Point(303, 3);
            this.txt2.MaxLength = 50;
            this.txt2.MouseState = MaterialSkin.MouseState.OUT;
            this.txt2.Multiline = false;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(250, 50);
            this.txt2.TabIndex = 8;
            this.txt2.Text = "";
            this.txt2.TrailingIcon = null;
            this.txt2.Visible = false;
            // 
            // txt3
            // 
            this.txt3.AnimateReadOnly = false;
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt3.Depth = 0;
            this.txt3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt3.LeadingIcon = null;
            this.txt3.Location = new System.Drawing.Point(3, 90);
            this.txt3.MaxLength = 50;
            this.txt3.MouseState = MaterialSkin.MouseState.OUT;
            this.txt3.Multiline = false;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(250, 50);
            this.txt3.TabIndex = 9;
            this.txt3.Text = "";
            this.txt3.TrailingIcon = null;
            this.txt3.Visible = false;
            // 
            // txt4
            // 
            this.txt4.AnimateReadOnly = false;
            this.txt4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt4.Depth = 0;
            this.txt4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt4.LeadingIcon = null;
            this.txt4.Location = new System.Drawing.Point(303, 90);
            this.txt4.MaxLength = 50;
            this.txt4.MouseState = MaterialSkin.MouseState.OUT;
            this.txt4.Multiline = false;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(250, 50);
            this.txt4.TabIndex = 10;
            this.txt4.Text = "";
            this.txt4.TrailingIcon = null;
            this.txt4.Visible = false;
            // 
            // txt5
            // 
            this.txt5.AnimateReadOnly = false;
            this.txt5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt5.Depth = 0;
            this.txt5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt5.LeadingIcon = null;
            this.txt5.Location = new System.Drawing.Point(3, 177);
            this.txt5.MaxLength = 50;
            this.txt5.MouseState = MaterialSkin.MouseState.OUT;
            this.txt5.Multiline = false;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(250, 50);
            this.txt5.TabIndex = 11;
            this.txt5.Text = "";
            this.txt5.TrailingIcon = null;
            this.txt5.Visible = false;
            // 
            // txt6
            // 
            this.txt6.AnimateReadOnly = false;
            this.txt6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt6.Depth = 0;
            this.txt6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt6.LeadingIcon = null;
            this.txt6.Location = new System.Drawing.Point(303, 177);
            this.txt6.MaxLength = 50;
            this.txt6.MouseState = MaterialSkin.MouseState.OUT;
            this.txt6.Multiline = false;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(250, 50);
            this.txt6.TabIndex = 12;
            this.txt6.Text = "";
            this.txt6.TrailingIcon = null;
            this.txt6.Visible = false;
            // 
            // txt7
            // 
            this.txt7.AnimateReadOnly = false;
            this.txt7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt7.Depth = 0;
            this.txt7.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt7.LeadingIcon = null;
            this.txt7.Location = new System.Drawing.Point(3, 264);
            this.txt7.MaxLength = 50;
            this.txt7.MouseState = MaterialSkin.MouseState.OUT;
            this.txt7.Multiline = false;
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(250, 50);
            this.txt7.TabIndex = 13;
            this.txt7.Text = "";
            this.txt7.TrailingIcon = null;
            this.txt7.Visible = false;
            // 
            // layout
            // 
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Controls.Add(this.txt7, 0, 3);
            this.layout.Controls.Add(this.txt6, 1, 2);
            this.layout.Controls.Add(this.txt5, 0, 2);
            this.layout.Controls.Add(this.txt4, 1, 1);
            this.layout.Controls.Add(this.txt3, 0, 1);
            this.layout.Controls.Add(this.txt2, 1, 0);
            this.layout.Controls.Add(this.txtID, 0, 0);
            this.layout.Location = new System.Drawing.Point(163, 77);
            this.layout.Name = "layout";
            this.layout.RowCount = 4;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.layout.Size = new System.Drawing.Size(600, 346);
            this.layout.TabIndex = 2;
            // 
            // Añadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.layout);
            this.Controls.Add(this.lblCB);
            this.Name = "Añadir";
            this.Size = new System.Drawing.Size(929, 443);
            this.Load += new System.EventHandler(this.Añadir_Load);
            this.layout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCB;
        private System.Windows.Forms.ComboBox cb;
        private BotonPersonalizado btnAñadir;
        private BotonPersonalizado btnLimpiar;
        private MaterialSkin.Controls.MaterialTextBox txtID;
        private MaterialSkin.Controls.MaterialTextBox txt2;
        private MaterialSkin.Controls.MaterialTextBox txt3;
        private MaterialSkin.Controls.MaterialTextBox txt4;
        private MaterialSkin.Controls.MaterialTextBox txt5;
        private MaterialSkin.Controls.MaterialTextBox txt6;
        private MaterialSkin.Controls.MaterialTextBox txt7;
        private System.Windows.Forms.TableLayoutPanel layout;
    }
}
