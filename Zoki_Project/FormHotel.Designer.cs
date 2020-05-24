namespace Zoki_Project
{
    partial class FormHotel
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
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelTypeRoom = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxNumberRoom = new System.Windows.Forms.TextBox();
            this.labelNumberRoom = new System.Windows.Forms.Label();
            this.comboBoxTypeRoom = new System.Windows.Forms.ComboBox();
            this.textBoxNumberProduct = new System.Windows.Forms.TextBox();
            this.labelNumberProduct = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewHotel = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FioClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxPersonal = new System.Windows.Forms.ComboBox();
            this.labelPersonal = new System.Windows.Forms.Label();
            this.IdPersonal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FioPersonal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(12, 56);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(146, 21);
            this.comboBoxClient.TabIndex = 56;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(8, 38);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(52, 15);
            this.labelClient.TabIndex = 55;
            this.labelClient.Text = "Клиент:";
            // 
            // labelTypeRoom
            // 
            this.labelTypeRoom.AutoSize = true;
            this.labelTypeRoom.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeRoom.Location = new System.Drawing.Point(9, 121);
            this.labelTypeRoom.Name = "labelTypeRoom";
            this.labelTypeRoom.Size = new System.Drawing.Size(88, 15);
            this.labelTypeRoom.TabIndex = 66;
            this.labelTypeRoom.Text = "Тип комнаты:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(12, 217);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(146, 20);
            this.textBoxDate.TabIndex = 65;
            this.textBoxDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDate_KeyPress);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(9, 199);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(39, 15);
            this.labelDate.TabIndex = 64;
            this.labelDate.Text = "Дата:";
            // 
            // textBoxNumberRoom
            // 
            this.textBoxNumberRoom.Location = new System.Drawing.Point(12, 176);
            this.textBoxNumberRoom.Name = "textBoxNumberRoom";
            this.textBoxNumberRoom.Size = new System.Drawing.Size(146, 20);
            this.textBoxNumberRoom.TabIndex = 69;
            this.textBoxNumberRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberRoom_KeyPress);
            // 
            // labelNumberRoom
            // 
            this.labelNumberRoom.AutoSize = true;
            this.labelNumberRoom.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberRoom.Location = new System.Drawing.Point(9, 160);
            this.labelNumberRoom.Name = "labelNumberRoom";
            this.labelNumberRoom.Size = new System.Drawing.Size(107, 15);
            this.labelNumberRoom.TabIndex = 68;
            this.labelNumberRoom.Text = "Номер комнаты:";
            // 
            // comboBoxTypeRoom
            // 
            this.comboBoxTypeRoom.FormattingEnabled = true;
            this.comboBoxTypeRoom.Items.AddRange(new object[] {
            "Для кошек",
            "Для собак"});
            this.comboBoxTypeRoom.Location = new System.Drawing.Point(11, 139);
            this.comboBoxTypeRoom.Name = "comboBoxTypeRoom";
            this.comboBoxTypeRoom.Size = new System.Drawing.Size(147, 21);
            this.comboBoxTypeRoom.TabIndex = 70;
            // 
            // textBoxNumberProduct
            // 
            this.textBoxNumberProduct.Location = new System.Drawing.Point(-266, 186);
            this.textBoxNumberProduct.Name = "textBoxNumberProduct";
            this.textBoxNumberProduct.Size = new System.Drawing.Size(60, 20);
            this.textBoxNumberProduct.TabIndex = 77;
            // 
            // labelNumberProduct
            // 
            this.labelNumberProduct.AutoSize = true;
            this.labelNumberProduct.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberProduct.Location = new System.Drawing.Point(-341, 170);
            this.labelNumberProduct.Name = "labelNumberProduct";
            this.labelNumberProduct.Size = new System.Drawing.Size(80, 15);
            this.labelNumberProduct.TabIndex = 76;
            this.labelNumberProduct.Text = "Количество:";
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonDel.Location = new System.Drawing.Point(859, 243);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(192, 48);
            this.buttonDel.TabIndex = 75;
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
            this.buttonEdit.Location = new System.Drawing.Point(661, 243);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(192, 48);
            this.buttonEdit.TabIndex = 74;
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
            this.buttonAdd.Location = new System.Drawing.Point(464, 243);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(192, 48);
            this.buttonAdd.TabIndex = 73;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-266, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-341, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "Дата:";
            // 
            // listViewHotel
            // 
            this.listViewHotel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.IdClient,
            this.FioClient,
            this.PhoneClient,
            this.IdPersonal,
            this.FioPersonal,
            this.TypeRoom,
            this.NumberRoom,
            this.Date});
            this.listViewHotel.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewHotel.FullRowSelect = true;
            this.listViewHotel.GridLines = true;
            this.listViewHotel.HideSelection = false;
            this.listViewHotel.Location = new System.Drawing.Point(164, 109);
            this.listViewHotel.MultiSelect = false;
            this.listViewHotel.Name = "listViewHotel";
            this.listViewHotel.Size = new System.Drawing.Size(887, 128);
            this.listViewHotel.TabIndex = 80;
            this.listViewHotel.UseCompatibleStateImageBehavior = false;
            this.listViewHotel.View = System.Windows.Forms.View.Details;
            this.listViewHotel.SelectedIndexChanged += new System.EventHandler(this.listViewHotel_SelectedIndexChanged);
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
            // PhoneClient
            // 
            this.PhoneClient.Text = "Номер клиента";
            this.PhoneClient.Width = 110;
            // 
            // TypeRoom
            // 
            this.TypeRoom.Text = "Тип комнаты";
            this.TypeRoom.Width = 103;
            // 
            // NumberRoom
            // 
            this.NumberRoom.Text = "Номер комнаты";
            this.NumberRoom.Width = 115;
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            this.Date.Width = 70;
            // 
            // comboBoxPersonal
            // 
            this.comboBoxPersonal.FormattingEnabled = true;
            this.comboBoxPersonal.Location = new System.Drawing.Point(12, 98);
            this.comboBoxPersonal.Name = "comboBoxPersonal";
            this.comboBoxPersonal.Size = new System.Drawing.Size(146, 21);
            this.comboBoxPersonal.TabIndex = 82;
            // 
            // labelPersonal
            // 
            this.labelPersonal.AutoSize = true;
            this.labelPersonal.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPersonal.Location = new System.Drawing.Point(8, 80);
            this.labelPersonal.Name = "labelPersonal";
            this.labelPersonal.Size = new System.Drawing.Size(72, 15);
            this.labelPersonal.TabIndex = 81;
            this.labelPersonal.Text = "Сотрудник:";
            // 
            // IdPersonal
            // 
            this.IdPersonal.Text = "Id сотрудника";
            this.IdPersonal.Width = 96;
            // 
            // FioPersonal
            // 
            this.FioPersonal.Text = "ФИО сотрудника";
            this.FioPersonal.Width = 118;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Zoki_Project.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(164, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(887, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 79;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 297);
            this.Controls.Add(this.comboBoxPersonal);
            this.Controls.Add(this.labelPersonal);
            this.Controls.Add(this.listViewHotel);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.textBoxNumberProduct);
            this.Controls.Add(this.labelNumberProduct);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTypeRoom);
            this.Controls.Add(this.textBoxNumberRoom);
            this.Controls.Add(this.labelNumberRoom);
            this.Controls.Add(this.labelTypeRoom);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelClient);
            this.Name = "FormHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отель";
            this.Load += new System.EventHandler(this.FormHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelTypeRoom;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxNumberRoom;
        private System.Windows.Forms.Label labelNumberRoom;
        private System.Windows.Forms.ComboBox comboBoxTypeRoom;
        private System.Windows.Forms.TextBox textBoxNumberProduct;
        private System.Windows.Forms.Label labelNumberProduct;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewHotel;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader IdClient;
        private System.Windows.Forms.ColumnHeader FioClient;
        private System.Windows.Forms.ColumnHeader PhoneClient;
        private System.Windows.Forms.ColumnHeader TypeRoom;
        private System.Windows.Forms.ColumnHeader NumberRoom;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader IdPersonal;
        private System.Windows.Forms.ColumnHeader FioPersonal;
        private System.Windows.Forms.ComboBox comboBoxPersonal;
        private System.Windows.Forms.Label labelPersonal;
    }
}