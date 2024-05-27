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
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            this.Hide();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно зашли!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 frm = new Form3();

                this.Hide();
                frm.ShowDialog();

            }
            else
                MessageBox.Show("Такого аккаунта нет!", "Аккаунт не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
