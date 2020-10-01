namespace SDRS
{
    partial class frmExamMark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamMark));
            this.btnClose4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btnExport12 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnImport12 = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSave11 = new Guna.UI.WinForms.GunaButton();
            this.txtAdmNo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cbxSub = new Guna.UI.WinForms.GunaComboBox();
            this.txtScore = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.dgvMarks = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose4
            // 
            this.btnClose4.FlatAppearance.BorderSize = 0;
            this.btnClose4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose4.ForeColor = System.Drawing.Color.White;
            this.btnClose4.Location = new System.Drawing.Point(3, 12);
            this.btnClose4.Name = "btnClose4";
            this.btnClose4.Size = new System.Drawing.Size(25, 25);
            this.btnClose4.TabIndex = 14;
            this.btnClose4.Text = "X";
            this.btnClose4.UseVisualStyleBackColor = true;
            this.btnClose4.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnClose4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 47);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(201, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "|  Exam Mark Entry  |";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaGradientButton2);
            this.gunaGroupBox1.Controls.Add(this.gunaGradientButton1);
            this.gunaGroupBox1.Controls.Add(this.gunaButton1);
            this.gunaGroupBox1.Controls.Add(this.btnExport12);
            this.gunaGroupBox1.Controls.Add(this.btnImport12);
            this.gunaGroupBox1.Controls.Add(this.btnSave11);
            this.gunaGroupBox1.Controls.Add(this.txtAdmNo);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.cbxSub);
            this.gunaGroupBox1.Controls.Add(this.txtScore);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel6);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 47);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(684, 193);
            this.gunaGroupBox1.TabIndex = 16;
            this.gunaGroupBox1.Text = "Enter Marks";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = global::SDRS.Properties.Resources.reset_50px;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(557, 32);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.MediumOrchid;
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(115, 42);
            this.gunaGradientButton1.TabIndex = 29;
            this.gunaGradientButton1.Text = "Process Marks";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::SDRS.Properties.Resources.search_50px;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(206, 42);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 4;
            this.gunaButton1.Size = new System.Drawing.Size(110, 42);
            this.gunaButton1.TabIndex = 28;
            this.gunaButton1.Text = "Search";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnExport12
            // 
            this.btnExport12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.btnExport12.Location = new System.Drawing.Point(414, 111);
            this.btnExport12.Name = "btnExport12";
            this.btnExport12.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport12.OnHoverBaseColor2 = System.Drawing.Color.MediumSlateBlue;
            this.btnExport12.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExport12.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExport12.OnHoverImage = null;
            this.btnExport12.OnPressedColor = System.Drawing.Color.Black;
            this.btnExport12.Size = new System.Drawing.Size(90, 42);
            this.btnExport12.TabIndex = 25;
            this.btnExport12.Text = "Export ";
            this.btnExport12.Click += new System.EventHandler(this.btnExport12_Click);
            // 
            // btnImport12
            // 
            this.btnImport12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.btnImport12.Location = new System.Drawing.Point(414, 42);
            this.btnImport12.Name = "btnImport12";
            this.btnImport12.OnHoverBaseColor1 = System.Drawing.Color.Lime;
            this.btnImport12.OnHoverBaseColor2 = System.Drawing.Color.Crimson;
            this.btnImport12.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImport12.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImport12.OnHoverImage = null;
            this.btnImport12.OnPressedColor = System.Drawing.Color.Black;
            this.btnImport12.Size = new System.Drawing.Size(90, 42);
            this.btnImport12.TabIndex = 22;
            this.btnImport12.Text = "Import ";
            this.btnImport12.Click += new System.EventHandler(this.btnImport12_Click);
            // 
            // btnSave11
            // 
            this.btnSave11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSave11.AnimationHoverSpeed = 0.07F;
            this.btnSave11.AnimationSpeed = 0.03F;
            this.btnSave11.BackColor = System.Drawing.Color.Transparent;
            this.btnSave11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(90)))));
            this.btnSave11.BorderColor = System.Drawing.Color.Black;
            this.btnSave11.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave11.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave11.ForeColor = System.Drawing.Color.White;
            this.btnSave11.Image = global::SDRS.Properties.Resources.save_close_24px;
            this.btnSave11.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave11.Location = new System.Drawing.Point(206, 111);
            this.btnSave11.Name = "btnSave11";
            this.btnSave11.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave11.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave11.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave11.OnHoverImage = null;
            this.btnSave11.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave11.Radius = 4;
            this.btnSave11.Size = new System.Drawing.Size(110, 42);
            this.btnSave11.TabIndex = 18;
            this.btnSave11.Text = "Award";
            this.btnSave11.Click += new System.EventHandler(this.btnSave11_Click);
            // 
            // txtAdmNo
            // 
            this.txtAdmNo.BaseColor = System.Drawing.Color.White;
            this.txtAdmNo.BorderColor = System.Drawing.Color.Silver;
            this.txtAdmNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdmNo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAdmNo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAdmNo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAdmNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdmNo.Location = new System.Drawing.Point(78, 32);
            this.txtAdmNo.Name = "txtAdmNo";
            this.txtAdmNo.PasswordChar = '\0';
            this.txtAdmNo.Size = new System.Drawing.Size(97, 30);
            this.txtAdmNo.TabIndex = 16;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(20, 32);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(52, 15);
            this.gunaLabel2.TabIndex = 15;
            this.gunaLabel2.Text = "AdmNo:";
            // 
            // cbxSub
            // 
            this.cbxSub.BackColor = System.Drawing.Color.Transparent;
            this.cbxSub.BaseColor = System.Drawing.Color.White;
            this.cbxSub.BorderColor = System.Drawing.Color.Silver;
            this.cbxSub.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSub.FocusedColor = System.Drawing.Color.Empty;
            this.cbxSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxSub.ForeColor = System.Drawing.Color.Black;
            this.cbxSub.FormattingEnabled = true;
            this.cbxSub.Location = new System.Drawing.Point(78, 79);
            this.cbxSub.Name = "cbxSub";
            this.cbxSub.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxSub.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxSub.Size = new System.Drawing.Size(97, 26);
            this.cbxSub.TabIndex = 14;
            // 
            // txtScore
            // 
            this.txtScore.BaseColor = System.Drawing.Color.White;
            this.txtScore.BorderColor = System.Drawing.Color.Silver;
            this.txtScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtScore.FocusedBaseColor = System.Drawing.Color.White;
            this.txtScore.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtScore.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtScore.Location = new System.Drawing.Point(78, 123);
            this.txtScore.Name = "txtScore";
            this.txtScore.PasswordChar = '\0';
            this.txtScore.Size = new System.Drawing.Size(97, 30);
            this.txtScore.TabIndex = 11;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(20, 84);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(49, 15);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Subject:";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(20, 123);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel6.TabIndex = 7;
            this.gunaLabel6.Text = "Score:";
            // 
            // dgvMarks
            // 
            this.dgvMarks.AllowUserToAddRows = false;
            this.dgvMarks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dgvMarks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarks.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMarks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarks.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMarks.DoubleBuffered = true;
            this.dgvMarks.EnableHeadersVisualStyles = false;
            this.dgvMarks.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMarks.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.dgvMarks.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMarks.Location = new System.Drawing.Point(3, 246);
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.ReadOnly = true;
            this.dgvMarks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMarks.RowTemplate.DividerHeight = 1;
            this.dgvMarks.RowTemplate.Height = 25;
            this.dgvMarks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarks.Size = new System.Drawing.Size(659, 162);
            this.dgvMarks.TabIndex = 18;
            // 
            // gunaGradientButton2
            // 
            this.gunaGradientButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton2.AnimationSpeed = 0.03F;
            this.gunaGradientButton2.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.gunaGradientButton2.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaGradientButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.Image = global::SDRS.Properties.Resources.synchronize_64px;
            this.gunaGradientButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton2.Location = new System.Drawing.Point(557, 111);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.MediumOrchid;
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Size = new System.Drawing.Size(115, 42);
            this.gunaGradientButton2.TabIndex = 30;
            this.gunaGradientButton2.Text = "Rank Students";
            this.gunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton2.Click += new System.EventHandler(this.gunaGradientButton2_Click);
            // 
            // frmExamMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.dgvMarks);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExamMark";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmExamMark_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaTextBox txtScore;
        private Guna.UI.WinForms.GunaTextBox txtAdmNo;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cbxSub;
        private Guna.UI.WinForms.GunaButton btnSave11;
        private Guna.UI.WinForms.GunaGradientButton btnImport12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvMarks;
        private Guna.UI.WinForms.GunaGradientButton btnExport12;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
    }
}