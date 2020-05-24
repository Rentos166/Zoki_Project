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
    public struct User
    {
        public string login;
        public string password;
        public string type;
    }
    public partial class FormAuthorization : Form
    {
        public static User users = new User();
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //если логин и пароль пустые
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //если логин и пароль ввели
            else
            {
                bool key = false;
                //ищем в базе данных пользователя с такими логином и паролем и запоминаем их
                foreach (Users user in Program.zokiDb.Users)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        key = true;
                        users.login = user.Login;
                        users.password = user.Password;
                        users.type = user.Type;
                    }
                }
                //если пользователя не нашли
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                //если пользователя нашли
                else
                {
                    MessageBox.Show("Вы вошли в систему как: " + FormAuthorization.users.login, "Авторизация успешна", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    Menu memu = new Menu();
                    memu.Show();
                    this.Hide();
                }
            }
        }
    }
}
