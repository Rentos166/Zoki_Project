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
    public partial class FormHotel : Form
    {
        void ShowHotel()
        {
            //Предварительно очищаем все listView
            listViewHotel.Items.Clear();
            //Проходим по коллекции продуктов, которые находятся в базе с помощью foreach
            foreach (HotelSet hotelSet in Program.zokiDb.HotelSet)
            {
                //Создадим новый элемент в listView с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    hotelSet.Id.ToString(),
                    hotelSet.ClientSet.Id.ToString(),
                    hotelSet.ClientSet.LastName +" "+hotelSet.ClientSet.Firstname.Remove(1) +". "+ hotelSet.ClientSet.MiddleName.Remove(1)+" .",
                    hotelSet.ClientSet.Phone,
                    hotelSet.PersonalSet.Id.ToString(),
                    hotelSet.PersonalSet.LastName +" "+hotelSet.PersonalSet.FirstName.Remove(1) +". "+ hotelSet.PersonalSet.MiddleName.Remove(1)+" .",
                    hotelSet.TypeRoom,
                    hotelSet.NumberRoom.ToString(),
                    hotelSet.Date
                });
                item.Tag = hotelSet;
                listViewHotel.Items.Add(item);
            }
            listViewHotel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowClient()
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
        public FormHotel()
        {
            InitializeComponent();
            ShowHotel();
            ShowClient();
            ShowPersonal();
        }

        private void FormHotel_Load(object sender, EventArgs e)
        {

        }

        private void listViewHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHotel.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                HotelSet hotelSet = listViewHotel.SelectedItems[0].Tag as HotelSet;
                //указываем, что может быть изменено
                //находим в comboBoxClient необходимую строку по Id поставщика из hotelSet.IdClient и задаем ее отображение comboBox-y
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(hotelSet.IdClient.ToString());
                //точно также с персоналом
                comboBoxPersonal.SelectedIndex = comboBoxPersonal.FindString(hotelSet.IdPersonal.ToString());
                textBoxNumberRoom.Text = hotelSet.NumberRoom.ToString();
                textBoxDate.Text = hotelSet.Date;
                comboBoxTypeRoom.Text = hotelSet.TypeRoom;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxNumberRoom.Text = "";
                textBoxDate.Text = "";
                comboBoxClient.SelectedItem = null;
                comboBoxTypeRoom.SelectedItem = null;
                comboBoxPersonal.SelectedItem = null;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Проверяем, что все поля (раскрывающихся списков и текствого поля) были заполнены
            if (comboBoxTypeRoom.SelectedItem != null && comboBoxClient.SelectedItem != null  && textBoxNumberRoom.Text != "" && textBoxDate.Text != "")
            {
                //создаем новый экземпляр класса Отель
                HotelSet hotelSet = new HotelSet();
                //из выбранной строки в comboBoxClient отделяем Id клиента (он отделен точкой) и делаем ссылку hotelSet.IdClient
                hotelSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                hotelSet.IdPersonal = Convert.ToInt32(comboBoxPersonal.SelectedItem.ToString().Split('.')[0]);
                hotelSet.NumberRoom = Convert.ToInt32(textBoxNumberRoom.Text);
                hotelSet.Date = textBoxDate.Text;
                if (comboBoxTypeRoom.SelectedIndex == 0)
                {
                    hotelSet.TypeRoom = "Для кошек";
                }
                else 
                {
                    hotelSet.TypeRoom = "Для собак";
                }
                //Добавляем в таблицу HotelSet забронированный hotelSet
                Program.zokiDb.HotelSet.Add(hotelSet);
                //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                Program.zokiDb.SaveChanges();
                ShowHotel();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //создаем новый экземпляр класса Отель
            HotelSet hotelSet = listViewHotel.SelectedItems[0].Tag as HotelSet;
            //из выбранной строки в comboBoxClient отделяем Id клиента (он отделен точкой) и делаем ссылку hotelSet.IdClient
            hotelSet.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
            hotelSet.IdPersonal = Convert.ToInt32(comboBoxPersonal.SelectedItem.ToString().Split('.')[0]);
            hotelSet.NumberRoom = Convert.ToInt32(textBoxNumberRoom.Text);
            hotelSet.Date = textBoxDate.Text;
            if (comboBoxTypeRoom.SelectedIndex == 0)
            {
                hotelSet.TypeRoom = "Для кошек";
            }
            else
            {
                hotelSet.TypeRoom = "Для собак";
            }
            //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
            Program.zokiDb.SaveChanges();
            ShowHotel();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewHotel.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    HotelSet hotelSet = listViewHotel.SelectedItems[0].Tag as HotelSet;
                    Program.zokiDb.HotelSet.Remove(hotelSet);
                    Program.zokiDb.SaveChanges();
                    ShowHotel();
                }
                comboBoxClient.SelectedItem = null;
                comboBoxPersonal.SelectedItem = null;
                comboBoxTypeRoom.SelectedItem = null;
                textBoxNumberRoom.Text = "";
                textBoxDate.Text = "";
            }
            catch

            {

                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxNumberRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }

        private void textBoxDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 46 && number != 8 && number != 47) //цифры, клавиша BackSpace, точка 
            {
                e.Handled = true;
            }
        }
    }
}
