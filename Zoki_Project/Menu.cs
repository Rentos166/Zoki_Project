﻿using System;
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
            if (FormAuthorization.users.type == "seller") buttonOpenPersonal.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAuthorization.users.login;
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Клиент и открываем ее
            Form formClient = new FormClients();
            formClient.Show();
        }

        private void buttonOpenHotel_Click(object sender, EventArgs e)
        {
            Form formHotel = new FormHotel();
            formHotel.Show();
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

        private void buttonOpenProducts_Click(object sender, EventArgs e)
        {
            Form formProducts = new FormProducts();
            formProducts.Show();
        }

        private void buttonOpenComposition_Click(object sender, EventArgs e)
        {
            Form formComposition = new FormComposition();
            formComposition.Show();
        }

        private void buttonOpenCustoms_Click(object sender, EventArgs e)
        {
            Form formCustoms = new FormCustoms();
            formCustoms.Show();
        }

        private void buttonOpenFinance_Click(object sender, EventArgs e)
        {
            Form formFinance = new FormFinance();
            formFinance.Show();
        }
    }
}
