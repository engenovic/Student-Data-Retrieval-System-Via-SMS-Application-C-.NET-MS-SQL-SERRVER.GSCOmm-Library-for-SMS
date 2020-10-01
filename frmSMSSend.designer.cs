namespace SDRS
{
    partial class frmSMSSend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSMSSend));
            this.btnClose9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.cbxForm = new Guna.UI.WinForms.GunaComboBox();
            this.btnSend23 = new Guna.UI.WinForms.GunaGradientButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtHi = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvMessages = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.gunaGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose9
            // 
            this.btnClose9.FlatAppearance.BorderSize = 0;
            this.btnClose9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose9.ForeColor = System.Drawing.Color.White;
            this.btnClose9.Location = new System.Drawing.Point(3, 12);
            this.btnClose9.Name = "btnClose9";
            this.btnClose9.Size = new System.Drawing.Size(25, 25);
            this.btnClose9.TabIndex = 14;
            this.btnClose9.Text = "X";
            this.btnClose9.UseVisualStyleBackColor = true;
            this.btnClose9.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnClose9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 47);
            this.panel1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(201, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "|  SMS Sender  |";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.cbxForm);
            this.gunaGroupBox1.Controls.Add(this.btnSend23);
            this.gunaGroupBox1.Controls.Add(this.richTextBox1);
            this.gunaGroupBox1.Controls.Add(this.txtHi);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 45);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(350, 188);
            this.gunaGroupBox1.TabIndex = 16;
            this.gunaGroupBox1.Text = "Bulk SMS";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cbxForm
            // 
            this.cbxForm.BackColor = System.Drawing.Color.Transparent;
            this.cbxForm.BaseColor = System.Drawing.Color.White;
            this.cbxForm.BorderColor = System.Drawing.Color.Silver;
            this.cbxForm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxForm.FocusedColor = System.Drawing.Color.Empty;
            this.cbxForm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxForm.ForeColor = System.Drawing.Color.Black;
            this.cbxForm.FormattingEnabled = true;
            this.cbxForm.Location = new System.Drawing.Point(48, 55);
            this.cbxForm.Name = "cbxForm";
            this.cbxForm.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxForm.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbxForm.Size = new System.Drawing.Size(72, 26);
            this.cbxForm.TabIndex = 25;
            // 
            // btnSend23
            // 
            this.btnSend23.AnimationHoverSpeed = 0.07F;
            this.btnSend23.AnimationSpeed = 0.03F;
            this.btnSend23.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.btnSend23.BaseColor2 = System.Drawing.Color.Yellow;
            this.btnSend23.BorderColor = System.Drawing.Color.Black;
            this.btnSend23.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend23.FocusedColor = System.Drawing.Color.Empty;
            this.btnSend23.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend23.ForeColor = System.Drawing.Color.White;
            this.btnSend23.Image = global::SDRS.Properties.Resources.email_send_24px;
            this.btnSend23.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSend23.Location = new System.Drawing.Point(235, 143);
            this.btnSend23.Name = "btnSend23";
            this.btnSend23.OnHoverBaseColor1 = System.Drawing.Color.Yellow;
            this.btnSend23.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.btnSend23.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSend23.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSend23.OnHoverImage = null;
            this.btnSend23.OnPressedColor = System.Drawing.Color.Black;
            this.btnSend23.Size = new System.Drawing.Size(112, 42);
            this.btnSend23.TabIndex = 24;
            this.btnSend23.Text = "Send";
            this.btnSend23.Click += new System.EventHandler(this.btnSend23_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(126, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 105);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // txtHi
            // 
            this.txtHi.BackColor = System.Drawing.Color.White;
            this.txtHi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHi.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtHi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHi.LineColor = System.Drawing.Color.Gainsboro;
            this.txtHi.Location = new System.Drawing.Point(6, 98);
            this.txtHi.Name = "txtHi";
            this.txtHi.PasswordChar = '\0';
            this.txtHi.Size = new System.Drawing.Size(114, 26);
            this.txtHi.TabIndex = 11;
            this.txtHi.Text = "Hi";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(3, 35);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(117, 17);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "Recipient Groups:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(3, 59);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(38, 15);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "Form:";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.dgvMessages);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(353, 45);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(328, 180);
            this.gunaGroupBox2.TabIndex = 17;
            this.gunaGroupBox2.Text = "SMS History";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dgvMessages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMessages.BackgroundColor = System.Drawing.Color.White;
            this.dgvMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMessages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMessages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMessages.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMessages.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMessages.DoubleBuffered = true;
            this.dgvMessages.EnableHeadersVisualStyles = false;
            this.dgvMessages.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMessages.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.dgvMessages.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMessages.Location = new System.Drawing.Point(3, 28);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMessages.RowTemplate.DividerHeight = 1;
            this.dgvMessages.RowTemplate.Height = 25;
            this.dgvMessages.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMessages.Size = new System.Drawing.Size(303, 134);
            this.dgvMessages.TabIndex = 18;
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox3.Controls.Add(this.txtPhone);
            this.gunaGroupBox3.Controls.Add(this.gunaGradientButton1);
            this.gunaGroupBox3.Controls.Add(this.richTextBox2);
            this.gunaGroupBox3.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox3.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox3.Location = new System.Drawing.Point(3, 236);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Size = new System.Drawing.Size(678, 197);
            this.gunaGroupBox3.TabIndex = 17;
            this.gunaGroupBox3.Text = "Custom SMS";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtPhone
            // 
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(119, 47);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.Size = new System.Drawing.Size(243, 30);
            this.txtPhone.TabIndex = 26;
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Yellow;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = global::SDRS.Properties.Resources.email_send_24px;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(544, 152);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.Yellow;
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(112, 42);
            this.gunaGradientButton1.TabIndex = 25;
            this.gunaGradientButton1.Text = "Send";
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(408, 33);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(248, 113);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(9, 47);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(91, 15);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "Phone Number:";
            // 
            // frmSMSSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox3);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSMSSend";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmSMSSend_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.gunaGroupBox3.ResumeLayout(false);
            this.gunaGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Guna.UI.WinForms.GunaLineTextBox txtHi;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaGradientButton btnSend23;
        private Guna.UI.WinForms.GunaComboBox cbxForm;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvMessages;
    }
}