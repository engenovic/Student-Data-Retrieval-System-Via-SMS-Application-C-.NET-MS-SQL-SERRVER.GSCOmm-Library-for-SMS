namespace SDRS
{
    partial class frmViewStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewStudents));
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnExport12 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnImport12 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnPrint12 = new Guna.UI.WinForms.GunaGradientButton();
            this.cbxGender12 = new Guna.UI.WinForms.GunaComboBox();
            this.cbxForm12 = new Guna.UI.WinForms.GunaComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvViewStudents = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(3, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 47);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(201, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "|  View Students  |";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.btnExport12);
            this.gunaGroupBox1.Controls.Add(this.btnImport12);
            this.gunaGroupBox1.Controls.Add(this.btnPrint12);
            this.gunaGroupBox1.Controls.Add(this.cbxGender12);
            this.gunaGroupBox1.Controls.Add(this.cbxForm12);
            this.gunaGroupBox1.Controls.Add(this.bunifuCustomLabel3);
            this.gunaGroupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 47);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(684, 139);
            this.gunaGroupBox1.TabIndex = 16;
            this.gunaGroupBox1.Text = "View Registered Students";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnExport12
            // 
            this.btnExport12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport12.AnimationHoverSpeed = 0.07F;
            this.btnExport12.AnimationSpeed = 0.03F;
            this.btnExport12.BaseColor1 = System.Drawing.Color.MediumSlateBlue;
            this.btnExport12.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport12.BorderColor = System.Drawing.Color.Black;
            this.btnExport12.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport12.FocusedColor = System.Drawing.Color.Empty;
            this.btnExport12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExport12.ForeColor = System.Drawing.Color.White;
            this.btnExport12.Image = global::SDRS.Properties.Resources.upload_24px;
            this.btnExport12.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport12.Location = new System.Drawing.Point(541, 94);
            this.btnExport12.Name = "btnExport12";
            this.btnExport12.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport12.OnHoverBaseColor2 = System.Drawing.Color.MediumSlateBlue;
            this.btnExport12.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExport12.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExport12.OnHoverImage = null;
            this.btnExport12.OnPressedColor = System.Drawing.Color.Black;
            this.btnExport12.Size = new System.Drawing.Size(121, 42);
            this.btnExport12.TabIndex = 22;
            this.btnExport12.Text = "Export Excel";
            this.btnExport12.Click += new System.EventHandler(this.btnExport12_Click);
            // 
            // btnImport12
            // 
            this.btnImport12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport12.AnimationHoverSpeed = 0.07F;
            this.btnImport12.AnimationSpeed = 0.03F;
            this.btnImport12.BaseColor1 = System.Drawing.Color.Crimson;
            this.btnImport12.BaseColor2 = System.Drawing.Color.Lime;
            this.btnImport12.BorderColor = System.Drawing.Color.Black;
            this.btnImport12.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImport12.FocusedColor = System.Drawing.Color.Empty;
            this.btnImport12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImport12.ForeColor = System.Drawing.Color.White;
            this.btnImport12.Image = global::SDRS.Properties.Resources.download_24px;
            this.btnImport12.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImport12.Location = new System.Drawing.Point(541, 28);
            this.btnImport12.Name = "btnImport12";
            this.btnImport12.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.btnImport12.OnHoverBaseColor2 = System.Drawing.Color.Crimson;
            this.btnImport12.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImport12.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImport12.OnHoverImage = null;
            this.btnImport12.OnPressedColor = System.Drawing.Color.Black;
            this.btnImport12.Size = new System.Drawing.Size(121, 42);
            this.btnImport12.TabIndex = 21;
            this.btnImport12.Text = "Import Excel";
            this.btnImport12.Click += new System.EventHandler(this.btnImport12_Click);
            // 
            // btnPrint12
            // 
            this.btnPrint12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint12.AnimationHoverSpeed = 0.07F;
            this.btnPrint12.AnimationSpeed = 0.03F;
            this.btnPrint12.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPrint12.BaseColor2 = System.Drawing.Color.Violet;
            this.btnPrint12.BorderColor = System.Drawing.Color.Black;
            this.btnPrint12.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint12.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint12.ForeColor = System.Drawing.Color.White;
            this.btnPrint12.Image = global::SDRS.Properties.Resources.print_24px;
            this.btnPrint12.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrint12.Location = new System.Drawing.Point(348, 53);
            this.btnPrint12.Name = "btnPrint12";
            this.btnPrint12.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnPrint12.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnPrint12.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint12.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint12.OnHoverImage = null;
            this.btnPrint12.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint12.Size = new System.Drawing.Size(106, 42);
            this.btnPrint12.TabIndex = 20;
            this.btnPrint12.Text = "Print";
            this.btnPrint12.Click += new System.EventHandler(this.btnPrint12_Click);
            // 
            // cbxGender12
            // 
            this.cbxGender12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGender12.BackColor = System.Drawing.Color.Transparent;
            this.cbxGender12.BaseColor = System.Drawing.Color.White;
            this.cbxGender12.BorderColor = System.Drawing.Color.Silver;
            this.cbxGender12.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxGender12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender12.FocusedColor = System.Drawing.Color.Empty;
            this.cbxGender12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxGender12.ForeColor = System.Drawing.Color.Black;
            this.cbxGender12.FormattingEnabled = true;
            this.cbxGender12.Location = new System.Drawing.Point(53, 76);
            this.cbxGender12.Name = "cbxGender12";
            this.cbxGender12.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxGender12.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxGender12.Size = new System.Drawing.Size(121, 26);
            this.cbxGender12.TabIndex = 19;
            this.cbxGender12.SelectedIndexChanged += new System.EventHandler(this.cbxGender12_SelectedIndexChanged);
            // 
            // cbxForm12
            // 
            this.cbxForm12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxForm12.BackColor = System.Drawing.Color.Transparent;
            this.cbxForm12.BaseColor = System.Drawing.Color.White;
            this.cbxForm12.BorderColor = System.Drawing.Color.Silver;
            this.cbxForm12.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxForm12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxForm12.FocusedColor = System.Drawing.Color.Empty;
            this.cbxForm12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxForm12.ForeColor = System.Drawing.Color.Black;
            this.cbxForm12.FormattingEnabled = true;
            this.cbxForm12.Location = new System.Drawing.Point(53, 44);
            this.cbxForm12.Name = "cbxForm12";
            this.cbxForm12.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxForm12.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxForm12.Size = new System.Drawing.Size(121, 26);
            this.cbxForm12.TabIndex = 18;
            this.cbxForm12.SelectedIndexChanged += new System.EventHandler(this.cbxForm12_SelectedIndexChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(8, 82);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(48, 13);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Gender: ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(10, 44);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(36, 13);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Form: ";
            // 
            // dgvViewStudents
            // 
            this.dgvViewStudents.AllowUserToAddRows = false;
            this.dgvViewStudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dgvViewStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvViewStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewStudents.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViewStudents.DoubleBuffered = true;
            this.dgvViewStudents.EnableHeadersVisualStyles = false;
            this.dgvViewStudents.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvViewStudents.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.dgvViewStudents.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvViewStudents.Location = new System.Drawing.Point(3, 192);
            this.dgvViewStudents.Name = "dgvViewStudents";
            this.dgvViewStudents.ReadOnly = true;
            this.dgvViewStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvViewStudents.RowTemplate.DividerHeight = 1;
            this.dgvViewStudents.RowTemplate.Height = 25;
            this.dgvViewStudents.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewStudents.Size = new System.Drawing.Size(659, 217);
            this.dgvViewStudents.TabIndex = 17;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.dgvViewStudents);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewStudents";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmViewStudents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Guna.UI.WinForms.GunaGradientButton btnPrint12;
        private Guna.UI.WinForms.GunaComboBox cbxGender12;
        private Guna.UI.WinForms.GunaComboBox cbxForm12;
        private Guna.UI.WinForms.GunaGradientButton btnExport12;
        private Guna.UI.WinForms.GunaGradientButton btnImport12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvViewStudents;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}