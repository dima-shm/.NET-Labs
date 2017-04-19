using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Result : Form
    {
        IEnumerable<Animal> animal;
        int currentRow;
        public Result(IEnumerable<Animal> _animal)
        {
            InitializeComponent();
            InitFirstRow();
            currentRow = 0;
            animal = _animal;
        }
        private void InitFirstRow()
        {
            for (int x = 0; x < 9; x++)
            {
                DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();
                Column.Width = 95;
                dataGridView1.Columns.Add(Column);
            }
            dataGridView1.Rows.Add("Name", "Type", "Age", "Record on Red Book", "Date of receipt",
                                    "Habitat continent", "Habitat latitude", "Habitat longitude", "Description");
        }
        public void ShowResult()
        {
            foreach (Animal item in animal)
            {
                dataGridView1.Rows.Add();
                currentRow++;
                dataGridView1.Rows[currentRow].Cells[0].Value = item.Name;
                dataGridView1.Rows[currentRow].Cells[1].Value = item.Type;
                dataGridView1.Rows[currentRow].Cells[2].Value = item.Age;
                dataGridView1.Rows[currentRow].Cells[3].Value = item.IsRcordOnRedBook;
                dataGridView1.Rows[currentRow].Cells[4].Value = item.DateOfReceipt;
                dataGridView1.Rows[currentRow].Cells[5].Value = item.Habitat.Continent;
                dataGridView1.Rows[currentRow].Cells[6].Value = item.Habitat.Latitude;
                dataGridView1.Rows[currentRow].Cells[7].Value = item.Habitat.Longitude;
                dataGridView1.Rows[currentRow].Cells[8].Value = item.Description;
            }
        }
    }
}
