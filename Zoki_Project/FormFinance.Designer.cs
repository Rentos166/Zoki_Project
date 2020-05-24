namespace Zoki_Project
{
    partial class FormFinance
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
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.textBoxGains = new System.Windows.Forms.TextBox();
            this.labelGains = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxCosts = new System.Windows.Forms.TextBox();
            this.labelCosts = new System.Windows.Forms.Label();
            this.listViewFinance = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gains = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Costs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Profit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Items.AddRange(new object[] {
            "За 3 месяца",
            "За полгода ",
            "За год"});
            this.comboBoxDate.Location = new System.Drawing.Point(12, 96);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(133, 21);
            this.comboBoxDate.TabIndex = 76;
            // 
            // textBoxGains
            // 
            this.textBoxGains.Location = new System.Drawing.Point(13, 133);
            this.textBoxGains.Name = "textBoxGains";
            this.textBoxGains.Size = new System.Drawing.Size(132, 20);
            this.textBoxGains.TabIndex = 75;
            this.textBoxGains.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGains_KeyPress);
            // 
            // labelGains
            // 
            this.labelGains.AutoSize = true;
            this.labelGains.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGains.Location = new System.Drawing.Point(10, 117);
            this.labelGains.Name = "labelGains";
            this.labelGains.Size = new System.Drawing.Size(56, 15);
            this.labelGains.TabIndex = 74;
            this.labelGains.Text = "Доходы:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(10, 78);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 15);
            this.labelDate.TabIndex = 73;
            this.labelDate.Text = "Дата:";
            // 
            // textBoxCosts
            // 
            this.textBoxCosts.Location = new System.Drawing.Point(13, 174);
            this.textBoxCosts.Name = "textBoxCosts";
            this.textBoxCosts.Size = new System.Drawing.Size(133, 20);
            this.textBoxCosts.TabIndex = 72;
            this.textBoxCosts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGains_KeyPress);
            // 
            // labelCosts
            // 
            this.labelCosts.AutoSize = true;
            this.labelCosts.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCosts.Location = new System.Drawing.Point(10, 156);
            this.labelCosts.Name = "labelCosts";
            this.labelCosts.Size = new System.Drawing.Size(62, 15);
            this.labelCosts.TabIndex = 71;
            this.labelCosts.Text = "Расходы:";
            // 
            // listViewFinance
            // 
            this.listViewFinance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Date,
            this.Gains,
            this.Costs,
            this.Profit});
            this.listViewFinance.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewFinance.FullRowSelect = true;
            this.listViewFinance.GridLines = true;
            this.listViewFinance.HideSelection = false;
            this.listViewFinance.Location = new System.Drawing.Point(151, 96);
            this.listViewFinance.MultiSelect = false;
            this.listViewFinance.Name = "listViewFinance";
            this.listViewFinance.Size = new System.Drawing.Size(479, 129);
            this.listViewFinance.TabIndex = 81;
            this.listViewFinance.UseCompatibleStateImageBehavior = false;
            this.listViewFinance.View = System.Windows.Forms.View.Details;
            this.listViewFinance.SelectedIndexChanged += new System.EventHandler(this.listViewFinance_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // Gains
            // 
            this.Gains.Text = "Доходы";
            this.Gains.Width = 96;
            // 
            // Costs
            // 
            this.Costs.Text = "Расходы";
            this.Costs.Width = 136;
            // 
            // Profit
            // 
            this.Profit.Text = "Прибыль";
            this.Profit.Width = 110;
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            this.Date.Width = 70;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonDel.Location = new System.Drawing.Point(533, 231);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(97, 48);
            this.buttonDel.TabIndex = 84;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonEdit.Location = new System.Drawing.Point(430, 231);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(97, 48);
            this.buttonEdit.TabIndex = 83;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonAdd.Location = new System.Drawing.Point(327, 231);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 48);
            this.buttonAdd.TabIndex = 82;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Zoki_Project.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(151, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(479, 88);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 85;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 284);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewFinance);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.textBoxGains);
            this.Controls.Add(this.labelGains);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxCosts);
            this.Controls.Add(this.labelCosts);
            this.Name = "FormFinance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Доходы/расходы";
            this.Load += new System.EventHandler(this.FormFinance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.TextBox textBoxGains;
        private System.Windows.Forms.Label labelGains;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxCosts;
        private System.Windows.Forms.Label labelCosts;
        private System.Windows.Forms.ListView listViewFinance;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Gains;
        private System.Windows.Forms.ColumnHeader Costs;
        private System.Windows.Forms.ColumnHeader Profit;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
    }
}