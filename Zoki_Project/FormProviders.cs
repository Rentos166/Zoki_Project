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
    public partial class FormProviders : Form
    {
        void ShowProviders()
        {
            //Предварительно очищаем listView
            listViewProviders.Items.Clear();
            //Проходимся по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (ProviderSet providerSet in Program.zokiDb.ProviderSet)
            {      
                    //создаем новый элемент в listView
                    //для этого создаем новый массив строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    //указываем необходимые поля
                    providerSet.Id.ToString(),
                    providerSet.CompanyName,
                    providerSet.TypeProduct,
                    providerSet.Product,
                    "г. " + providerSet.Address_City+", " + "ул. " + providerSet.Address_Street+", "+
                    "д. " + providerSet.Address_House,
                    providerSet.Phone,
                    providerSet.Email

                    });
                //указываем по какому тегу будем брать элементы
                item.Tag = providerSet;
                //добавляем элементы в listView для отображения
                listViewProviders.Items.Add(item);
            }
        }
        public FormProviders()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowProviders();
        }

        private void FormProviders_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса Поставщик
                ProviderSet providerSet = new ProviderSet();
                //Делаем ссылку на объект, который хранится в textBox-ax
                providerSet.CompanyName = textBoxCompanyName.Text;
                providerSet.Product = textBoxProduct.Text;
                providerSet.Address_City = textBoxCity.Text;
                providerSet.Address_Street = textBoxStreet.Text;
                providerSet.Address_House = textBoxHouse.Text;
                providerSet.Phone = textBoxPhone.Text;
                providerSet.Email = textBoxEmail.Text;
                if (comboBoxType.SelectedIndex == 0)
                {
                    providerSet.TypeProduct = "Для кошек";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    providerSet.TypeProduct = "Для собак";
                }
                else
                {
                    providerSet.TypeProduct = "Для рыбок";
                }
                if (providerSet.CompanyName == "" || providerSet.Product == "" || providerSet.TypeProduct =="")
                {
                    throw new Exception("Данные о поставщике не заполнены");
                }
                //Добавляем в таблицу ProviderSet нового клиента providerSet
                Program.zokiDb.ProviderSet.Add(providerSet);
                //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                Program.zokiDb.SaveChanges();
                ShowProviders();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //условие, если в listView выбран 1 элемент
                if (listViewProviders.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    ProviderSet providerSet = listViewProviders.SelectedItems[0].Tag as ProviderSet;
                    //указываем, что может быть изменено
                    providerSet.CompanyName = textBoxCompanyName.Text;
                    providerSet.Product = textBoxProduct.Text;
                    providerSet.Address_City = textBoxCity.Text;
                    providerSet.Address_Street = textBoxStreet.Text;
                    providerSet.Address_House = textBoxHouse.Text;
                    providerSet.Phone = textBoxPhone.Text;
                    providerSet.Email = textBoxEmail.Text;
                    if (comboBoxType.SelectedIndex == 0)
                    {
                        providerSet.TypeProduct = "Для кошек";
                    }
                    else if (comboBoxType.SelectedIndex == 1)
                    {
                        providerSet.TypeProduct = "Для собак";
                    }
                    else
                    {
                        providerSet.TypeProduct = "Для рыбок";
                    }
                    if (providerSet.CompanyName == "" || providerSet.Product == "" || providerSet.TypeProduct == "")
                    {
                        throw new Exception("Данные о поставщике не заполнены");
                    }
                    //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                    Program.zokiDb.SaveChanges();
                    ShowProviders();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProviders.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                ProviderSet providerSet = listViewProviders.SelectedItems[0].Tag as ProviderSet;
                //указываем, что может быть изменено
                textBoxCompanyName.Text = providerSet.CompanyName;
                textBoxProduct.Text = providerSet.Product;
                providerSet.Address_City = textBoxCity.Text;
                providerSet.Address_Street = textBoxStreet.Text;
                providerSet.Address_House = textBoxHouse.Text;
                textBoxPhone.Text = providerSet.Phone;
                textBoxEmail.Text = providerSet.Email;
                if (comboBoxType.SelectedIndex == 0)
                {
                    providerSet.TypeProduct = "Для кошек";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    providerSet.TypeProduct = "Для собак";
                }
                else
                {
                    providerSet.TypeProduct = "Для рыбок";
                }
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxCompanyName.Text = "";
                textBoxProduct.Text = "";
                textBoxCity.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxCity.Text = "";
                textBoxHouse.Text = "";
                textBoxStreet.Text = "";
                comboBoxType.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if (listViewProviders.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    ProviderSet providerSet = listViewProviders.SelectedItems[0].Tag as ProviderSet;
                    //удаляем из модели и базы данных
                    Program.zokiDb.ProviderSet.Remove(providerSet);
                    //сохраняем изменения
                    Program.zokiDb.SaveChanges();
                    //отображаем обновленный список
                    ShowProviders();
                }
                //очищаем textBox-ы
                textBoxCompanyName.Text = "";
                textBoxProduct.Text = "";
                textBoxCity.Text = "";
                textBoxHouse.Text = "";
                textBoxStreet.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                comboBoxType.SelectedItem = null;
            }
            //если возникает какая-то ошибка, к примеру, запись используется, выводим всплывающее сообщение
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

