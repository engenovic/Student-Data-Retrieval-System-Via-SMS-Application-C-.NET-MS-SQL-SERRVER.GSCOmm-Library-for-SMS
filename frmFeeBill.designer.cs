namespace SDRS
{
    partial class frmFeeBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeeBill));
            this.btnClose6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.cbxForm = new System.Windows.Forms.ComboBox();
            this.cbxTerm = new System.Windows.Forms.ComboBox();
            this.cbxBillGroup = new System.Windows.Forms.ComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtKES = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtVote = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnSave11 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dgvFeesBilling = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeesBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose6
            // 
            this.btnClose6.FlatAppearance.BorderSize = 0;
            this.btnClose6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose6.ForeColor = System.Drawing.Color.White;
            this.btnClose6.Location = new System.Drawing.Point(3, 12);
            this.btnClose6.Name = "btnClose6";
            this.btnClose6.Size = new System.Drawing.Size(25, 25);
            this.btnClose6.TabIndex = 14;
            this.btnClose6.Text = "X";
            this.btnClose6.UseVisualStyleBackColor = true;
            this.btnClose6.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnClose6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 47);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(201, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 30);
            this.label6.TabIndex = 18;
            this.label6.Text = "|  Fees Billing  |";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.cbxForm);
            this.gunaGroupBox1.Controls.Add(this.cbxTerm);
            this.gunaGroupBox1.Controls.Add(this.cbxBillGroup);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel8);
            this.gunaGroupBox1.Controls.Add(this.txtKES);
            this.gunaGroupBox1.Controls.Add(this.txtVote);
            this.gunaGroupBox1.Controls.Add(this.btnSave11);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 47);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(684, 214);
            this.gunaGroupBox1.TabIndex = 16;
            this.gunaGroupBox1.Text = "Fees Billing";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cbxForm
            // 
            this.cbxForm.FormattingEnabled = true;
            this.cbxForm.Location = new System.Drawing.Point(109, 46);
            this.cbxForm.Name = "cbxForm";
            this.cbxForm.Size = new System.Drawing.Size(121, 21);
            this.cbxForm.TabIndex = 27;
            this.cbxForm.Text = "Choose Form";
            // 
            // cbxTerm
            // 
            this.cbxTerm.FormattingEnabled = true;
            this.cbxTerm.Location = new System.Drawing.Point(109, 83);
            this.cbxTerm.Name = "cbxTerm";
            this.cbxTerm.Size = new System.Drawing.Size(121, 21);
            this.cbxTerm.TabIndex = 26;
            this.cbxTerm.Text = "Choose Term";
            // 
            // cbxBillGroup
            // 
            this.cbxBillGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBillGroup.FormattingEnabled = true;
            this.cbxBillGroup.Location = new System.Drawing.Point(474, 51);
            this.cbxBillGroup.Name = "cbxBillGroup";
            this.cbxBillGroup.Size = new System.Drawing.Size(121, 21);
            this.cbxBillGroup.TabIndex = 25;
            this.cbxBillGroup.Text = "Choose Billing group";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(389, 53);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(79, 15);
            this.gunaLabel8.TabIndex = 24;
            this.gunaLabel8.Text = "Billing Group:";
            // 
            // txtKES
            // 
            this.txtKES.BackColor = System.Drawing.Color.White;
            this.txtKES.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKES.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtKES.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKES.LineColor = System.Drawing.Color.Gainsboro;
            this.txtKES.Location = new System.Drawing.Point(109, 170);
            this.txtKES.Name = "txtKES";
            this.txtKES.PasswordChar = '\0';
            this.txtKES.Size = new System.Drawing.Size(160, 26);
            this.txtKES.TabIndex = 23;
            this.txtKES.Text = "9000";
            // 
            // txtVote
            // 
            this.txtVote.BackColor = System.Drawing.Color.White;
            this.txtVote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVote.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtVote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVote.LineColor = System.Drawing.Color.Gainsboro;
            this.txtVote.Location = new System.Drawing.Point(109, 121);
            this.txtVote.Name = "txtVote";
            this.txtVote.PasswordChar = '\0';
            this.txtVote.Size = new System.Drawing.Size(160, 26);
            this.txtVote.TabIndex = 22;
            this.txtVote.Text = "Boarding";
            // 
            // btnSave11
            // 
            this.btnSave11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnSave11.Location = new System.Drawing.Point(474, 104);
            this.btnSave11.Name = "btnSave11";
            this.btnSave11.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave11.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave11.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave11.OnHoverImage = null;
            this.btnSave11.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave11.Radius = 4;
            this.btnSave11.Size = new System.Drawing.Size(130, 42);
            this.btnSave11.TabIndex = 18;
            this.btnSave11.Text = "Save";
            this.btnSave11.Click += new System.EventHandler(this.btnSave11_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(48, 48);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(41, 15);
            this.gunaLabel5.TabIndex = 9;
            this.gunaLabel5.Text = "Form: ";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(48, 89);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Term: ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(22, 131);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(67, 15);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Vote Head: ";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(48, 170);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(32, 15);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "KES: ";
            // 
            // dgvFeesBilling
            // 
            this.dgvFeesBilling.AllowUserToAddRows = false;
            this.dgvFeesBilling.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dgvFeesBilling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFeesBilling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFeesBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeesBilling.BackgroundColor = System.Drawing.Color.White;
            this.dgvFeesBilling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFeesBilling.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFeesBilling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeesBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFeesBilling.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFeesBilling.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFeesBilling.DoubleBuffered = true;
            this.dgvFeesBilling.EnableHeadersVisualStyles = false;
            this.dgvFeesBilling.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFeesBilling.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.dgvFeesBilling.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFeesBilling.Location = new System.Drawing.Point(3, 267);
            this.dgvFeesBilling.Name = "dgvFeesBilling";
            this.dgvFeesBilling.ReadOnly = true;
            this.dgvFeesBilling.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFeesBilling.RowTemplate.DividerHeight = 1;
            this.dgvFeesBilling.RowTemplate.Height = 25;
            this.dgvFeesBilling.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFeesBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeesBilling.Size = new System.Drawing.Size(669, 159);
            this.dgvFeesBilling.TabIndex = 19;
            // 
            // frmFeeBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.dgvFeesBilling);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFeeBill";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmFeeBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeesBilling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnSave11;
        private Guna.UI.WinForms.GunaLineTextBox txtKES;
        private Guna.UI.WinForms.GunaLineTextBox txtVote;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvFeesBilling;
        private System.Windows.Forms.ComboBox cbxBillGroup;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private System.Windows.Forms.ComboBox cbxTerm;
        private System.Windows.Forms.ComboBox cbxForm;
    }
}