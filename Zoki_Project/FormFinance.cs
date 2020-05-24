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
    public partial class FormFinance : Form
    {
        void ShowFinance()
        {
            //Предварительно очищаем все listView
            listViewFinance.Items.Clear();
            //Проходим по коллекции продуктов, которые находятся в базе с помощью foreach
            foreach (FinanceSet financeSet in Program.zokiDb.FinanceSet)
            {
                //Создадим новый элемент в listView с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                {
                    financeSet.Id.ToString(),
                    financeSet.Date,
                    financeSet.Gain.ToString(),
                    financeSet.Costs.ToString(),
                    financeSet.Profit.ToString()
                });
                item.Tag = financeSet;
                listViewFinance.Items.Add(item);
            }
            listViewFinance.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public FormFinance()
        {
            InitializeComponent();
            ShowFinance();
        }

        private void FormFinance_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDate.SelectedItem != null  && textBoxGains.Text != "" && textBoxCosts.Text != "")
            {
                FinanceSet financeSet = new FinanceSet();
                financeSet.Gain = Convert.ToInt32(textBoxGains.Text);
                financeSet.Costs = Convert.ToInt32(textBoxCosts.Text);
                int X;
                X = financeSet.Gain - financeSet.Costs;
                if(X>0)
                {
                    financeSet.Profit = "+" + X;
                }
                else if (X<0)
                {
                    financeSet.Profit = "0";
                }
                else
                {
                    financeSet.Profit = X.ToString();
                }
                if(comboBoxDate.SelectedIndex == 0)
                {
                    financeSet.Date = "За 3 месяца";
                }
                else if (comboBoxDate.SelectedIndex == 1)
                {
                    financeSet.Date = "За полгода";
                }
                else
                {
                    financeSet.Date = "За год";
                }
                //Добавляем в таблицу FinanceSet новую прибыль financeSet
                Program.zokiDb.FinanceSet.Add(financeSet);
                //Сохраняем изменения в модели zokiDb (экземпляр которой был создан ранее)
                Program.zokiDb.SaveChanges();
                ShowFinance();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listViewFinance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFinance.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                FinanceSet financeSet = listViewFinance.SelectedItems[0].Tag as FinanceSet;
                //указываем, что может быть изменено
                textBoxGains.Text = financeSet.Gain.ToString();
                textBoxCosts.Text = financeSet.Costs.ToString();
                comboBoxDate.Text = financeSet.Date;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxGains.Text = "";
                textBoxCosts.Text = "";
                comboBoxDate.SelectedItem = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //создаем новый экземпляр класса Финансы
            FinanceSet financeSet = listViewFinance.SelectedItems[0].Tag as FinanceSet;
            financeSet.Gain = Convert.ToInt32(textBoxGains.Text);
            financeSet.Costs = Convert.ToInt32(textBoxCosts.Text);
            int X;
            X = financeSet.Gain - financeSet.Costs;
            if (X > 0)
            {
                financeSet.Profit = "+" + X;
            }
            else if (X < 0)
            {
                financeSet.Profit = "0";
            }
            else
            {
                financeSet.Profit = X.ToString();
            }
            if (comboBoxDate.SelectedIndex == 0)
            {
                financeSet.Date = "За 3 месяца";
            }
            else if (comboBoxDate.SelectedIndex == 1)
            {
                financeSet.Date = "За полгода";
            }
            else
            {
                financeSet.Date = "За год";
            }
            Program.zokiDb.SaveChanges();
            ShowFinance();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFinance.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    FinanceSet financeSet = listViewFinance.SelectedItems[0].Tag as FinanceSet;
                    Program.zokiDb.FinanceSet.Remove(financeSet);
                    Program.zokiDb.SaveChanges();
                    ShowFinance();
                }
                comboBoxDate.SelectedItem = null;
                textBoxGains.Text = "";
                textBoxCosts.Text = "";
            }
            catch

            {

                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxGains_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace 
            {
                e.Handled = true;
            }
        }
    }
}
