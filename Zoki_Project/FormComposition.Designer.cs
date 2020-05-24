namespace Zoki_Project
{
    partial class FormComposition
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
            this.listViewComposition = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompanyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.labelProvider = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewComposition
            // 
            this.listViewComposition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.CompanyName,
            this.Type,
            this.Product,
            this.Number});
            this.listViewComposition.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewComposition.FullRowSelect = true;
            this.listViewComposition.GridLines = true;
            this.listViewComposition.HideSelection = false;
            this.listViewComposition.Location = new System.Drawing.Point(8, 113);
            this.listViewComposition.MultiSelect = false;
            this.listViewComposition.Name = "listViewComposition";
            this.listViewComposition.Size = new System.Drawing.Size(527, 160);
            this.listViewComposition.TabIndex = 20;
            this.listViewComposition.UseCompatibleStateImageBehavior = false;
            this.listViewComposition.View = System.Windows.Forms.View.Details;
            this.listViewComposition.SelectedIndexChanged += new System.EventHandler(this.listViewComposition_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // CompanyName
            // 
            this.CompanyName.Text = "Название компании";
            this.CompanyName.Width = 140;
            // 
            // Type
            // 
            this.Type.Text = "Тип товара";
            this.Type.Width = 86;
            // 
            // Product
            // 
            this.Product.Text = "Товар";
            this.Product.Width = 91;
            // 
            // Number
            // 
            this.Number.Text = "Количество";
            this.Number.Width = 147;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonDel.Location = new System.Drawing.Point(440, 279);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(95, 48);
            this.buttonDel.TabIndex = 42;
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
            this.buttonEdit.Location = new System.Drawing.Point(339, 279);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 48);
            this.buttonEdit.TabIndex = 41;
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
            this.buttonAdd.Location = new System.Drawing.Point(238, 279);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 48);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(12, 86);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProvider.TabIndex = 46;
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProvider.Location = new System.Drawing.Point(8, 68);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(77, 15);
            this.labelProvider.TabIndex = 45;
            this.labelProvider.Text = "Поставщик:";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(155, 86);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProduct.TabIndex = 48;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProduct.Location = new System.Drawing.Point(151, 68);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(45, 15);
            this.labelProduct.TabIndex = 47;
            this.labelProduct.Text = "Товар:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Zoki_Project.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(282, 1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(253, 106);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 49;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormComposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 330);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewComposition);
            this.Name = "FormComposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.FormComposition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewComposition;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader CompanyName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}