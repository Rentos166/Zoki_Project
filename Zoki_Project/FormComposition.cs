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
    public partial class FormComposition : Form
    {
        void ShowComposition()
        {
            //Предварительно очищаем все listView
            listViewComposition.Items.Clear();
            //Проходим по коллекции продуктов, которые находятся в базе с помощью foreach
            foreach (CompositionSet compositionSet in Program.zokiDb.CompositionSet)
            {
                //Создадим новый элемент в listView с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    compositionSet.Id.ToString(),
                    compositionSet.ProviderSet.CompanyName,
                    compositionSet.ProductSet.Type,
                    compositionSet.ProductSet.Name,
                    compositionSet.ProductSet.Number.ToString()
                });
                //указываем по какому тегу выбраны элементы
                item.Tag = compositionSet;
                listViewComposition.Items.Add(item);
            }
            listViewComposition.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowProviders()
        {
            //очищаем comboBox
            comboBoxProvider.Items.Clear();
            foreach (ProviderSet providerSet in Program.zokiDb.ProviderSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                string[] item = { providerSet.Id.ToString() + ".", providerSet.CompanyName };
                comboBoxProvider.Items.Add(string.Join(" ", item));
            }
        }
        void ShowProducts()
        {
            //очищаем comboBox
            comboBoxProduct.Items.Clear();
            foreach (ProductSet productSet in Program.zokiDb.ProductSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                string[] item = { productSet.Id.ToString() + ".", "Тип: " + productSet.Type + ", " + "Наз-е: " + productSet.Name + ", " + "Кол-во: " + productSet.Number };
                comboBoxProduct.Items.Add(string.Join(" ", item));
            }
        }
        public FormComposition()
        {
            InitializeComponent();
            ShowComposition();
            ShowProviders();
            ShowProducts();
        }

        private void FormComposition_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem != null && comboBoxProvider.SelectedItem != null)
            {
                //создаем новый экземпляр класса Товары
                CompositionSet compositionSet = new CompositionSet();
                //из выбранной строки в comboBoxProvider отделяем Id поставщика (он отделен точкой) и делаем ссылку compositionSet.IdProvider
                compositionSet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                //тоже самое с товаром
                compositionSet.IdProduct = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                //Добавляем в таблицу CompositionSet новый товар compositionSet
                Program.zokiDb.CompositionSet.Add(compositionSet);
                //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                Program.zokiDb.SaveChanges();
                ShowComposition();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listViewComposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewComposition.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                CompositionSet compositionSet = listViewComposition.SelectedItems[0].Tag as CompositionSet;
                //указываем, что может быть изменено
                //находим в comboBoxProvider необходимую строку по Id поставщика из productSet.IdProvider и задаем ее отображение comboBox-y
                comboBoxProvider.SelectedIndex = comboBoxProvider.FindString(compositionSet.IdProvider.ToString());
                comboBoxProduct.SelectedIndex = comboBoxProduct.FindString(compositionSet.IdProduct.ToString());
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                comboBoxProvider.SelectedItem = null;
                comboBoxProduct.SelectedItem = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewComposition.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                CompositionSet compositionSet = listViewComposition.SelectedItems[0].Tag as CompositionSet;
                //указываем, что может быть изменено
                //из выбранной строки в comboBoxProvider отделяем Id поставщика (он отделен точкой) и делаем ссылку compositionSet.IdProvider
                compositionSet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                //тоже самое с товаром
                compositionSet.IdProduct = Convert.ToInt32(comboBoxProduct.SelectedItem.ToString().Split('.')[0]);
                Program.zokiDb.SaveChanges();
                ShowComposition();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewComposition.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    CompositionSet compositionSet = listViewComposition.SelectedItems[0].Tag as CompositionSet;
                    Program.zokiDb.CompositionSet.Remove(compositionSet);
                    Program.zokiDb.SaveChanges();
                    ShowComposition();
                }
                comboBoxProduct.SelectedItem = null;
                comboBoxProvider.SelectedItem = null;
            }
            catch

            {

                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
