using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoki_Project
{
    public partial class FormCustoms : Form
    {
        void ShowCustoms()
        {
            //Предварительно очищаем все listView
            listViewCustoms.Items.Clear();
            //Проходим по коллекции продуктов, которые находятся в базе с помощью foreach
            foreach (CustomSet customSet in Program.zokiDb.CustomSet)
            {
                //Создадим новый элемент в listView с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    customSet.Id.ToString(),
                    customSet.ClientSet.Id.ToString(),
                    customSet.ClientSet.LastName +" "+customSet.ClientSet.Firstname.Remove(1) +". "+ customSet.ClientSet.MiddleName.Remove(1)+" .",
                    customSet.ClientSet.Phone,
                    customSet.PersonalSet.Id.ToString(),
                    customSet.PersonalSet.LastName +" "+customSet.PersonalSet.FirstName.Remove(1) +". "+ customSet.PersonalSet.MiddleName.Remove(1)+" .",
                    customSet.ProductSet.Type,
                    customSet.ProductSet.Name,
                    customSet.NumberProduct.ToString(),
                    customSet.Date
                });
                //указываем по какому тегу выбраны элементы
                item.Tag = customSet;
                listViewCustoms.Items.Add(item);
            }
            listViewCustoms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowClients()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientSet clientSet in Program.zokiDb.ClientSet)

            {
                string[] item = { clientSet.Id.ToString() + ".", clientSet.LastName + ".", clientSet.Firstname.Remove(1) + ".", clientSet.MiddleName.Remove(1) + "." };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowPersonal()
        {
            comboBoxPersonal.Items.Clear();
            foreach (PersonalSet personalSet in Program.zokiDb.PersonalSet)

            {
                string[] item = { personalSet.Id.ToString() + ".", personalSet.LastName + ".", personalSet.FirstName.Remove(1) + ".", personalSet.MiddleName.Remove(1) + "." };
                comboBoxPersonal.Items.Add(string.Join(" ", item));
            }
        }
        void ShowProduct()
        {
            comboBoxProduct.Items.Clear();
            foreach (ProductSet productSet in Program.zokiDb.ProductSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                string[] item = { productSet.Id.ToString() + ".", "Тип: " + productSet.Type + ", " + "Наз-е: " + productSet.Name };
                comboBoxProduct.Items.Add(string.Join(" ", item));
            }
        }
        public FormCustoms()
        {
            InitializeComponent();
            ShowCustoms();
            ShowClients();
            ShowPersonal();
            ShowProduct();
        }

        private void labelProduct_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem != null && comboBoxPersonal.SelectedItem != null && comboBoxClient.SelectedItem != null)
            {
                CustomSet customSet = new CustomSet();
                customSet.IdProduct = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                customSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                customSet.IdPersonal = Convert.ToInt32(comboBoxPersonal.SelectedItem.ToString().Split('.')[0]);
                customSet.Date = textBoxDate.Text;
                customSet.NumberProduct = Convert.ToInt32(textBoxNumberProduct.Text);
                Program.zokiDb.CustomSet.Add(customSet);
                //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                Program.zokiDb.SaveChanges();
                ShowCustoms();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listViewCustoms_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewCustoms.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                CustomSet customSet = listViewCustoms.SelectedItems[0].Tag as CustomSet;
                //указываем, что может быть изменено
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(customSet.IdClient.ToString());
                comboBoxProduct.SelectedIndex = comboBoxProduct.FindString(customSet.IdProduct.ToString());
                comboBoxPersonal.SelectedIndex = comboBoxPersonal.FindString(customSet.IdPersonal.ToString());
                textBoxDate.Text = customSet.Date;
                textBoxNumberProduct.Text = customSet.NumberProduct.ToString();
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                comboBoxClient.SelectedItem = null;
                comboBoxProduct.SelectedItem = null;
                comboBoxPersonal.SelectedItem = null;
                textBoxDate.Text = "";
                textBoxNumberProduct.Text = "";
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (listViewCustoms.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                CustomSet customSet = listViewCustoms.SelectedItems[0].Tag as CustomSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(customSet.IdClient.ToString());
                comboBoxProduct.SelectedIndex = comboBoxProduct.FindString(customSet.IdProduct.ToString());
                comboBoxPersonal.SelectedIndex = comboBoxPersonal.FindString(customSet.IdPersonal.ToString());
                customSet.Date = textBoxDate.Text;
                customSet.NumberProduct = Convert.ToInt32(textBoxNumberProduct.Text);
                Program.zokiDb.SaveChanges();
                ShowCustoms();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCustoms.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    CustomSet customSet = listViewCustoms.SelectedItems[0].Tag as CustomSet;
                    Program.zokiDb.CustomSet.Remove(customSet);
                    Program.zokiDb.SaveChanges();
                    ShowCustoms();
                }
                comboBoxClient.SelectedItem = null;
                comboBoxProduct.SelectedItem = null;
                comboBoxPersonal.SelectedItem = null;
                textBoxDate.Text = "";
                textBoxNumberProduct.Text = "";
            }
            catch

            {

                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
