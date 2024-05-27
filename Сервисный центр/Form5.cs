using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сервисный_центр
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автоDataSet1.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.автоDataSet1.Клиент);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.клиентTableAdapter.Update(this.автоDataSet1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.RemoveCurrent();
            this.клиентTableAdapter.Update(this.автоDataSet1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
