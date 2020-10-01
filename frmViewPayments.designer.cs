namespace SDRS
{
    partial class frmViewPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewPayments));
            this.btnClose8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete11 = new Guna.UI.WinForms.GunaButton();
            this.btnPrint12 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaHScrollBar23 = new Guna.UI.WinForms.GunaHScrollBar();
            this.dgvViewPayments = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose8
            // 
            this.btnClose8.FlatAppearance.BorderSize = 0;
            this.btnClose8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose8.ForeColor = System.Drawing.Color.White;
            this.btnClose8.Location = new System.Drawing.Point(3, 12);
            this.btnClose8.Name = "btnClose8";
            this.btnClose8.Size = new System.Drawing.Size(25, 25);
            this.btnClose8.TabIndex = 14;
            this.btnClose8.Text = "X";
            this.btnClose8.UseVisualStyleBackColor = true;
            this.btnClose8.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnClose8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 47);
            this.panel1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(201, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "|  View Payments |";
            // 
            // btnDelete11
            // 
            this.btnDelete11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete11.AnimationHoverSpeed = 0.07F;
            this.btnDelete11.AnimationSpeed = 0.03F;
            this.btnDelete11.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete11.BaseColor = System.Drawing.Color.Red;
            this.btnDelete11.BorderColor = System.Drawing.Color.Black;
            this.btnDelete11.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete11.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete11.ForeColor = System.Drawing.Color.White;
            this.btnDelete11.Image = global::SDRS.Properties.Resources.replace_24px;
            this.btnDelete11.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete11.Location = new System.Drawing.Point(524, 81);
            this.btnDelete11.Name = "btnDelete11";
            this.btnDelete11.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete11.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete11.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete11.OnHoverImage = null;
            this.btnDelete11.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete11.Radius = 4;
            this.btnDelete11.Size = new System.Drawing.Size(99, 42);
            this.btnDelete11.TabIndex = 32;
            this.btnDelete11.Text = "Clear ALL";
            // 
            // btnPrint12
            // 
            this.btnPrint12.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.btnPrint12.Location = new System.Drawing.Point(354, 81);
            this.btnPrint12.Name = "btnPrint12";
            this.btnPrint12.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnPrint12.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnPrint12.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint12.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint12.OnHoverImage = null;
            this.btnPrint12.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint12.Size = new System.Drawing.Size(99, 42);
            this.btnPrint12.TabIndex = 24;
            this.btnPrint12.Text = "Print";
            // 
            // gunaHScrollBar23
            // 
            this.gunaHScrollBar23.BackColor = System.Drawing.Color.Transparent;
            this.gunaHScrollBar23.LargeChange = 10;
            this.gunaHScrollBar23.Location = new System.Drawing.Point(239, 417);
            this.gunaHScrollBar23.Maximum = 100;
            this.gunaHScrollBar23.Name = "gunaHScrollBar23";
            this.gunaHScrollBar23.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaHScrollBar23.Size = new System.Drawing.Size(215, 10);
            this.gunaHScrollBar23.TabIndex = 24;
            this.gunaHScrollBar23.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.gunaHScrollBar23.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaHScrollBar23.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            // 
            // dgvViewPayments
            // 
            this.dgvViewPayments.AllowUserToAddRows = false;
            this.dgvViewPayments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dgvViewPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewPayments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvViewPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewPayments.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewPayments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViewPayments.DoubleBuffered = true;
            this.dgvViewPayments.EnableHeadersVisualStyles = false;
            this.dgvViewPayments.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvViewPayments.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.dgvViewPayments.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvViewPayments.Location = new System.Drawing.Point(0, 156);
            this.dgvViewPayments.Name = "dgvViewPayments";
            this.dgvViewPayments.ReadOnly = true;
            this.dgvViewPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvViewPayments.RowTemplate.DividerHeight = 1;
            this.dgvViewPayments.RowTemplate.Height = 25;
            this.dgvViewPayments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewPayments.Size = new System.Drawing.Size(684, 275);
            this.dgvViewPayments.TabIndex = 33;
            // 
            // frmViewPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.dgvViewPayments);
            this.Controls.Add(this.btnDelete11);
            this.Controls.Add(this.btnPrint12);
            this.Controls.Add(this.gunaHScrollBar23);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewPayments";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmViewPayments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaGradientButton btnPrint12;
        private Guna.UI.WinForms.GunaHScrollBar gunaHScrollBar23;
        private Guna.UI.WinForms.GunaButton btnDelete11;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvViewPayments;
    }
}