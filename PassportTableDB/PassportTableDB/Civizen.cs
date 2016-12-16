using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassportTableDB
{
    public partial class Civizen : Form
    {
        public Civizen()
        {
            InitializeComponent();
        }
        DataView CivizenDataView;
        private void button1_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Fill(passportTableDataSet1.Civizen);
            CivizenDataView = new DataView(passportTableDataSet1.Civizen);
            dataGridView1.DataSource = CivizenDataView;
            CivizenDataView.Sort = "surname";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(passportTableDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CivizenDataView.Sort = SortTextBox.Text;
            CivizenDataView.RowFilter = FilterTextBox.Text;
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int temp = 0;
                if (Int32.TryParse((string)e.Value, out temp))
                {
                    MessageBox.Show("Ошибка: Вы ввели некоректные данные.");
                    e.Value = "";
                }
            }
            if (e.ColumnIndex == 2) 
            {
                int temp = 0;
                if (Int32.TryParse((string)e.Value, out temp))
                {
                    MessageBox.Show("Ошибка: Вы ввели некоректные данные.");
                    e.Value = "";
                }
            }
            if (e.ColumnIndex == 5) 
            {
                int temp = 0;
                if (Int32.TryParse((string)e.Value, out temp))
                {
                    MessageBox.Show("Ошибка: Вы ввели некоректные данные.");
                    e.Value = "";
                }
            }
           
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
