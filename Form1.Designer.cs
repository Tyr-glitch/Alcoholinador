namespace FachaAlcohol
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gpAdd = new System.Windows.Forms.GroupBox();
            this.cbDrinks = new System.Windows.Forms.ComboBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.rbModify = new System.Windows.Forms.RadioButton();
            this.btnFacha = new System.Windows.Forms.Button();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvDrinks = new System.Windows.Forms.DataGridView();
            this.gpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // gpAdd
            // 
            this.gpAdd.BackColor = System.Drawing.Color.Transparent;
            this.gpAdd.Controls.Add(this.cbDrinks);
            this.gpAdd.Controls.Add(this.lblName2);
            this.gpAdd.Controls.Add(this.rbDelete);
            this.gpAdd.Controls.Add(this.rbModify);
            this.gpAdd.Controls.Add(this.btnFacha);
            this.gpAdd.Controls.Add(this.rbAdd);
            this.gpAdd.Controls.Add(this.nudPrice);
            this.gpAdd.Controls.Add(this.btnModify);
            this.gpAdd.Controls.Add(this.btnDelete);
            this.gpAdd.Controls.Add(this.btnAdd);
            this.gpAdd.Controls.Add(this.nudQuantity);
            this.gpAdd.Controls.Add(this.txtName);
            this.gpAdd.Controls.Add(this.lblPrice);
            this.gpAdd.Controls.Add(this.lblQuantity);
            this.gpAdd.Controls.Add(this.lblName);
            this.gpAdd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpAdd.Location = new System.Drawing.Point(29, 34);
            this.gpAdd.Name = "gpAdd";
            this.gpAdd.Size = new System.Drawing.Size(275, 627);
            this.gpAdd.TabIndex = 0;
            this.gpAdd.TabStop = false;
            this.gpAdd.Text = "Agregar Productos";
            // 
            // cbDrinks
            // 
            this.cbDrinks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrinks.FormattingEnabled = true;
            this.cbDrinks.Location = new System.Drawing.Point(92, 54);
            this.cbDrinks.Name = "cbDrinks";
            this.cbDrinks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbDrinks.Size = new System.Drawing.Size(173, 31);
            this.cbDrinks.TabIndex = 15;
            this.cbDrinks.SelectedIndexChanged += new System.EventHandler(this.cbDrinks_SelectedIndexChanged);
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(8, 57);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(68, 23);
            this.lblName2.TabIndex = 14;
            this.lblName2.Text = "Bebida";
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDelete.Location = new System.Drawing.Point(194, 31);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(75, 23);
            this.rbDelete.TabIndex = 13;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "Eliminar";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
            // 
            // rbModify
            // 
            this.rbModify.AutoSize = true;
            this.rbModify.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbModify.Location = new System.Drawing.Point(96, 31);
            this.rbModify.Name = "rbModify";
            this.rbModify.Size = new System.Drawing.Size(86, 23);
            this.rbModify.TabIndex = 12;
            this.rbModify.TabStop = true;
            this.rbModify.Text = "Modificar";
            this.rbModify.UseVisualStyleBackColor = true;
            this.rbModify.CheckedChanged += new System.EventHandler(this.rbModify_CheckedChanged);
            // 
            // btnFacha
            // 
            this.btnFacha.BackgroundImage = global::FachaAlcohol.Properties.Resources._63_635105_ink_well_my_priends_siegbrau_dark_souls_dark;
            this.btnFacha.Location = new System.Drawing.Point(0, 321);
            this.btnFacha.Name = "btnFacha";
            this.btnFacha.Size = new System.Drawing.Size(275, 306);
            this.btnFacha.TabIndex = 9;
            this.btnFacha.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdd.Location = new System.Drawing.Point(10, 31);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(76, 23);
            this.rbAdd.TabIndex = 11;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Agregar";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(96, 100);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(56, 32);
            this.nudPrice.TabIndex = 10;
            this.nudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Yellow;
            this.btnModify.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModify.Location = new System.Drawing.Point(87, 281);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(79, 34);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(172, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(6, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(96, 135);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(56, 32);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 32);
            this.txtName.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 102);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(95, 23);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Precio    $";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(6, 137);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(84, 23);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Cantidad";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // dgvDrinks
            // 
            this.dgvDrinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrinks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrinks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrinks.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDrinks.Location = new System.Drawing.Point(364, 45);
            this.dgvDrinks.Name = "dgvDrinks";
            this.dgvDrinks.ReadOnly = true;
            this.dgvDrinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrinks.Size = new System.Drawing.Size(734, 616);
            this.dgvDrinks.TabIndex = 1;
            this.dgvDrinks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrinks_CellContentClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::FachaAlcohol.Properties.Resources._899515198_preview_vlcsnap_2017_04_06_23h57m32s201;
            this.ClientSize = new System.Drawing.Size(1132, 696);
            this.Controls.Add(this.dgvDrinks);
            this.Controls.Add(this.gpAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Alcoholinador";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gpAdd.ResumeLayout(false);
            this.gpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvDrinks;
        private System.Windows.Forms.Button btnFacha;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.RadioButton rbModify;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.ComboBox cbDrinks;
        private System.Windows.Forms.Label lblName2;
    }
}

