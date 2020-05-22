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
    public partial class FormClients : Form
    {
        void ShowClient()
        {
            //Предварительно очищаем listView
            listViewClients.Items.Clear();
            //Проходимся по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (ClientSet clientsSet in Program.zokiDb.ClientSet)
            {
                //создаем новый элемент в listView
                //для этого создаем новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    //указываем необходимые поля
                    clientsSet.Id.ToString(),
                    clientsSet.Firstname,
                    clientsSet.MiddleName,
                    clientsSet.LastName,
                    clientsSet.Phone,
                    clientsSet.Email,
                    clientsSet.Address

                });
                //указываем по какому тегу будем брать элементы
                item.Tag = clientsSet;
                //добавляем элементы в listView для отображения
                listViewClients.Items.Add(item);
            }
        }
        public FormClients()
        {
            InitializeComponent();
            ShowClient();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormClients_Load(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем новый экземпляр класса Клиент
                ClientSet clientsSet = new ClientSet();
                //Делаем ссылку на объект, который хранится в textBox-ax
                clientsSet.Firstname = textBoxFirstName.Text;
                clientsSet.MiddleName = textBoxMiddleName.Text;
                clientsSet.LastName = textBoxLastName.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;
                clientsSet.Address = textBoxAddress.Text;
                if (clientsSet.Firstname == "" || clientsSet.MiddleName == "" || clientsSet.LastName == "")
                {
                    throw new Exception("Не заполнены поля ФИО");
                }
                //Добавляем в таблицу ClientSet нового клиента clientSet
                Program.zokiDb.ClientSet.Add(clientsSet);
                //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                Program.zokiDb.SaveChanges();
                ShowClient();
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //условие, если в listView выбран 1 элемент
                if (listViewClients.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    ClientSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientSet;
                    //указываем, что может быть изменено
                    clientsSet.Firstname = textBoxFirstName.Text;
                    clientsSet.MiddleName = textBoxMiddleName.Text;
                    clientsSet.LastName = textBoxLastName.Text;
                    clientsSet.Phone = textBoxPhone.Text;
                    clientsSet.Email = textBoxEmail.Text;
                    clientsSet.Address = textBoxAddress.Text;
                    if (clientsSet.Firstname == "" || clientsSet.MiddleName == "" || clientsSet.LastName == "")
                    {
                        throw new Exception("Не заполнены поля ФИО");
                    }
                    //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                    Program.zokiDb.SaveChanges();
                    ShowClient();
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //условие, если выбран 1 элемент
            if (listViewClients.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                ClientSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientSet;
                //указываем, что может быть изменено
                textBoxFirstName.Text = clientsSet.Firstname;
                textBoxMiddleName.Text = clientsSet.MiddleName;
                textBoxLastName.Text = clientsSet.LastName;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;
                textBoxAddress.Text = clientsSet.Address;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxAddress.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if (listViewClients.SelectedItems.Count == 1)
                {
                    //ищем этот элемент
                    ClientSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientSet;
                    //удаляем из модели и базы данных
                    Program.zokiDb.ClientSet.Remove(clientsSet);
                    //сохраняем изменения
                    Program.zokiDb.SaveChanges();
                    //отображаем обновленный список
                    ShowClient();
                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxAddress.Text = "";
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
