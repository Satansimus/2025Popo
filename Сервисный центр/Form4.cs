using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Сервисный_центр
{
    public partial class Form4 : Form
    {
        DataBase database = new DataBase();
        public Form4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автоDataSet.Заявки". При необходимости она может быть перемещена или удалена.
            this.заявкиTableAdapter.Fill(this.автоDataSet.Заявки);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкиBindingSource.EndEdit();
            this.заявкиTableAdapter.Update(this.автоDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкиBindingSource.RemoveCurrent();
            this.заявкиTableAdapter.Update(this.автоDataSet);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
