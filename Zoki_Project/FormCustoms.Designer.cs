namespace Zoki_Project
{
    partial class FormCustoms
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
            this.comboBoxPersonal = new System.Windows.Forms.ComboBox();
            this.labelPersonal = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.listViewCustoms = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FioClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdPersonal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FioPersonal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelNumberProduct = new System.Windows.Forms.Label();
            this.textBoxNumberProduct = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPersonal
            // 
            this.comboBoxPersonal.FormattingEnabled = true;
            this.comboBoxPersonal.Location = new System.Drawing.Point(12, 108);
            this.comboBoxPersonal.Name = "comboBoxPersonal";
            this.comboBoxPersonal.Size = new System.Drawing.Size(133, 21);
            this.comboBoxPersonal.TabIndex = 50;
            this.comboBoxPersonal.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // labelPersonal
            // 
            this.labelPersonal.AutoSize = true;
            this.labelPersonal.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPersonal.Location = new System.Drawing.Point(8, 90);
            this.labelPersonal.Name = "labelPersonal";
            this.labelPersonal.Size = new System.Drawing.Size(68, 15);
            this.labelPersonal.TabIndex = 49;
            this.labelPersonal.Text = "Персонал:";
            this.labelPersonal.Click += new System.EventHandler(this.labelProduct_Click);
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(13, 150);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(132, 21);
            this.comboBoxProduct.TabIndex = 52;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProduct.Location = new System.Drawing.Point(9, 132);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(45, 15);
            this.labelProduct.TabIndex = 51;
            this.labelProduct.Text = "Товар:";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(12, 60);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(133, 21);
            this.comboBoxClient.TabIndex = 54;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(8, 42);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(52, 15);
            this.labelClient.TabIndex = 53;
            this.labelClient.Text = "Клиент:";
            // 
            // listViewCustoms
            // 
            this.listViewCustoms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.IdClient,
            this.FioClient,
            this.PhoneClient,
            this.IdPersonal,
            this.FioPersonal,
            this.Type,
            this.Product,
            this.Number,
            this.Date});
            this.listViewCustoms.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewCustoms.FullRowSelect = true;
            this.listViewCustoms.GridLines = true;
            this.listViewCustoms.HideSelection = false;
            this.listViewCustoms.Location = new System.Drawing.Point(151, 122);
            this.listViewCustoms.MultiSelect = false;
            this.listViewCustoms.Name = "listViewCustoms";
            this.listViewCustoms.Size = new System.Drawing.Size(981, 128);
            this.listViewCustoms.TabIndex = 55;
            this.listViewCustoms.UseCompatibleStateImageBehavior = false;
            this.listViewCustoms.View = System.Windows.Forms.View.Details;
            this.listViewCustoms.SelectedIndexChanged += new System.EventHandler(this.listViewCustoms_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // IdClient
            // 
            this.IdClient.Text = "Id клиента";
            this.IdClient.Width = 74;
            // 
            // FioClient
            // 
            this.FioClient.Text = "ФИО клиента";
            this.FioClient.Width = 136;
            // 
            // IdPersonal
            // 
            this.IdPersonal.Text = "Id сотрудника";
            this.IdPersonal.Width = 95;
            // 
            // FioPersonal
            // 
            this.FioPersonal.Text = "ФИО сотрудника";
            this.FioPersonal.Width = 140;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Zoki_Project.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(151, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(981, 106);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 56;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(10, 212);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 15);
            this.labelDate.TabIndex = 57;
            this.labelDate.Text = "Дата:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(13, 230);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(133, 20);
            this.textBoxDate.TabIndex = 58;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonDel.Location = new System.Drawing.Point(962, 256);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(176, 30);
            this.buttonDel.TabIndex = 61;
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
            this.buttonEdit.Location = new System.Drawing.Point(790, 256);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(166, 30);
            this.buttonEdit.TabIndex = 60;
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
            this.buttonAdd.Location = new System.Drawing.Point(597, 256);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(187, 30);
            this.buttonAdd.TabIndex = 59;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Type
            // 
            this.Type.Text = "Тип товара";
            this.Type.Width = 114;
            // 
            // Number
            // 
            this.Number.Text = "Количество";
            this.Number.Width = 82;
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            this.Date.Width = 95;
            // 
            // Product
            // 
            this.Product.Text = "Товар";
            this.Product.Width = 102;
            // 
            // PhoneClient
            // 
            this.PhoneClient.Text = "Номер клиента";
            this.PhoneClient.Width = 110;
            // 
            // labelNumberProduct
            // 
            this.labelNumberProduct.AutoSize = true;
            this.labelNumberProduct.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberProduct.Location = new System.Drawing.Point(10, 174);
            this.labelNumberProduct.Name = "labelNumberProduct";
            this.labelNumberProduct.Size = new System.Drawing.Size(80, 15);
            this.labelNumberProduct.TabIndex = 62;
            this.labelNumberProduct.Text = "Количество:";
            // 
            // textBoxNumberProduct
            // 
            this.textBoxNumberProduct.Location = new System.Drawing.Point(13, 190);
            this.textBoxNumberProduct.Name = "textBoxNumberProduct";
            this.textBoxNumberProduct.Size = new System.Drawing.Size(132, 20);
            this.textBoxNumberProduct.TabIndex = 63;
            // 
            // FormCustoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 294);
            this.Controls.Add(this.textBoxNumberProduct);
            this.Controls.Add(this.labelNumberProduct);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.listViewCustoms);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.comboBoxPersonal);
            this.Controls.Add(this.labelPersonal);
            this.Name = "FormCustoms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPersonal;
        private System.Windows.Forms.Label labelPersonal;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ListView listViewCustoms;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader IdClient;
        private System.Windows.Forms.ColumnHeader FioClient;
        private System.Windows.Forms.ColumnHeader IdPersonal;
        private System.Windows.Forms.ColumnHeader FioPersonal;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader PhoneClient;
        private System.Windows.Forms.Label labelNumberProduct;
        private System.Windows.Forms.TextBox textBoxNumberProduct;
    }
}