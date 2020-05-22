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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Клиент и открываем ее
            Form formClient = new FormClients();
            formClient.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenPersonal_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Персонал и открываем ее
            Form formPersonal = new  FormPersonals();
            formPersonal.Show();
        }

        private void buttonOpenProviders_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Поставщики и открываем ее
            Form formProviders = new FormProviders();
            formProviders.Show();
        }
    }
}
