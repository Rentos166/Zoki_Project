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
    public partial class FormProducts : Form
    {
        void ShowProducts()
        {
            //Предварительно очищаем все listView
            listViewProducts.Items.Clear();
            //Проходим по коллекции продуктов, которые находятся в базе с помощью foreach
            foreach (ProductSet productSet in Program.zokiDb.ProductSet)
            {
                //Создадим новый элемент в listView с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    //Id
                    productSet.Id.ToString(), 
                     //Товар
                    productSet.Type,
                    productSet.Name,
                    //Поставщик
                    productSet.IdProvider.ToString(),
                    productSet.ProviderSet.CompanyName,
                    "г. " + productSet.ProviderSet.Address_City+", " + "ул. " + productSet.ProviderSet.Address_Street+", "+
                    "д. " + productSet.ProviderSet.Address_House,
                    //Количество
                    productSet.Number.ToString(),
                    //Цена
                    productSet.Price.ToString()
                });
                //указываем по какому тегу выбраны элементы
                item.Tag = productSet;
                listViewProducts.Items.Add(item);
            }
        }
        void ShowProviders()
        {
            //очищаем comboBox
            comboBoxProvider.Items.Clear();
            foreach (ProviderSet providerSet in Program.zokiDb.ProviderSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-a
                string[] item = { providerSet.Id.ToString() + ".", providerSet.CompanyName + ",", providerSet.Address_City};
                comboBoxProvider.Items.Add(string.Join(" ", item));
            }
        }
        public FormProducts()
        {
            InitializeComponent();
            ShowProducts();
            ShowProviders();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                ProductSet productSet = listViewProducts.SelectedItems[0].Tag as ProductSet;
                //указываем, что может быть изменено
                //находим в comboBoxProvider необходимую строку по Id поставщика из productSet.IdProvider и задаем ее отображение comboBox-y
                comboBoxProvider.SelectedIndex = comboBoxProvider.FindString(productSet.IdProvider.ToString());
                textBoxNameProduct.Text = productSet.Name;
                textBoxNumber.Text = productSet.Number.ToString();
                textBoxPrice.Text = productSet.Price.ToString();
                comboBoxType.Text = productSet.Type;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxNameProduct.Text = "";
                textBoxNumber.Text = "";
                textBoxPrice.Text = "";
                comboBoxProvider.SelectedItem = null;
                comboBoxType.SelectedItem = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Проверяем, что все поля (раскрывающихся списков и текствого поля) были заполнены
            if (comboBoxType.SelectedItem != null && comboBoxProvider.SelectedItem != null && textBoxNameProduct.Text != "" && textBoxPrice.Text != "" && textBoxNumber.Text != "")
            {
                //создаем новый экземпляр класса Товары
                ProductSet product = new ProductSet();
                //из выбранной строки в comboBoxProvider отделяем Id поставщика (он отделен точкой) и делаем ссылку product.IdProvider
                product.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                product.Name = textBoxNameProduct.Text;
                product.Number = Convert.ToInt32(textBoxNumber.Text);
                product.Price = Convert.ToInt32(textBoxPrice.Text);
                if (comboBoxType.SelectedIndex == 0)
                {
                    product.Type = "Для кошек";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    product.Type = "Для собак";
                }
                else
                {
                    product.Type = "Для рыбок";
                }
                //Добавляем в таблицу ProductSet новый товар product
                Program.zokiDb.ProductSet.Add(product);
                //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                Program.zokiDb.SaveChanges();
                ShowProducts();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

                if (comboBoxType.SelectedItem != null && comboBoxProvider.SelectedItem != null && textBoxNameProduct.Text != "" && textBoxPrice.Text != "" && textBoxNumber.Text != "")
                {
                    //условие, если в listView выбран 1 элемент
                    if (listViewProducts.SelectedItems.Count == 1)
                    {
                        //ищем элемент из таблицы по тегу
                        ProductSet productSet = listViewProducts.SelectedItems[0].Tag as ProductSet;
                        //указываем, что может быть изменено
                        productSet.IdProvider = Convert.ToInt32(comboBoxProvider.SelectedItem.ToString().Split('.')[0]);
                        //указываем, что может быть изменено
                        productSet.Name = textBoxNameProduct.Text;
                        productSet.Number = Convert.ToInt32(textBoxNumber.Text);
                        productSet.Price = Convert.ToInt32(textBoxPrice.Text);
                        if (comboBoxType.SelectedIndex == 0)
                        {
                            productSet.Type = "Для кошек";
                        }
                        else if (comboBoxType.SelectedIndex == 1)
                        {
                            productSet.Type = "Для собак";
                        }
                        else
                        {
                            productSet.Type = "Для рыбок";
                        }
                        //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                        Program.zokiDb.SaveChanges();
                        ShowProducts();
                    }
                    else
                    {
                        //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                        textBoxNameProduct.Text = "";
                        textBoxPrice.Text = "";
                        textBoxNumber.Text = "";
                        comboBoxType.SelectedItem = null;
                        comboBoxProvider.SelectedItem = null;
                    }
                }
                else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                //условие, если в listView выбран 1 элемент
                if (listViewProducts.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    ProductSet productSet = listViewProducts.SelectedItems[0].Tag as ProductSet;
                    //удаляем из модели и базы данных
                    Program.zokiDb.ProductSet.Remove(productSet);
                    //сохраняем изменения
                    Program.zokiDb.SaveChanges();
                    //отображаем обновленный список
                    ShowProducts();
                }
                //очищаем textBox-ы
                textBoxNameProduct.Text = "";
                textBoxPrice.Text = "";
                textBoxNumber.Text = "";
                comboBoxType.SelectedItem = null;
                comboBoxProvider.SelectedItem = null;
            }
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
