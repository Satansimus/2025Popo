using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сервисный_центр
{
    public partial class Form2 : Form
    {
        DataBase database = new DataBase();
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            this.Hide();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "";
            string password = "";
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                login = textBox1.Text;
                password = textBox2.Text;

                string querystring = $"insert into register(login_user, password_user) values('{login}', '{password}')";


                SqlCommand command = new SqlCommand(querystring, database.GetConnection());
                database.openConnection();
                if (!checkUser())
                {
                    MessageBox.Show("Аккаунт успешно создан!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    command.ExecuteNonQuery();
                    Form1 frm = new Form1();
                    this.Hide();
                    frm.ShowDialog();
                }
                database.closeConnection();
            }
        }
        private Boolean checkUser()
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!", "Ошибка!");
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
