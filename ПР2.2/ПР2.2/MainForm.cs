using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.hostelDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Priveleges". При необходимости она может быть перемещена или удалена.
            this.privelegesTableAdapter.Fill(this.hostelDataSet.Priveleges);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.hostelDataSet.Rooms);
            dataGridView1.AutoGenerateColumns = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            roomsTableAdapter.Update(hostelDataSet);
            privelegesTableAdapter.Update(hostelDataSet);
            studentsTableAdapter.Update(hostelDataSet);
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = roomsBindingSource;
            dataGridView1.DataSource = roomsBindingSource;
            label1.Text = "Rooms";
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = studentsBindingSource;
            dataGridView1.DataSource = studentsBindingSource;
            label1.Text = "Students";
        }

        private void privelegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = privelegesBindingSource;
            dataGridView1.DataSource = privelegesBindingSource;
            label1.Text = "Priveleges";
        }

        private void розселенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RSForm rs = new RSForm();
            rs.ShowDialog();
            privelegesTableAdapter.Fill(hostelDataSet.Priveleges);
            studentsTableAdapter.Fill(hostelDataSet.Students);
            roomsTableAdapter.Fill(hostelDataSet.Rooms);
        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryEdit qe = new QueryEdit();
            qe.Show();  
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm edt = new EditForm();
            edt.ShowDialog();
            studentsTableAdapter.Fill(hostelDataSet.Students);
            hostelDataSet.AcceptChanges();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HostelDataSet.StudentsDataTable st = new HostelDataSet.StudentsDataTable();
            studentsTableAdapter.FillBy(st,
            Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            EditForm edt = new EditForm(row[1].ToString(), Convert.ToDateTime(row[2]),
                           row[3].ToString(), row[4].ToString(), row[5].ToString(), Convert.ToInt32(row[6]),
                           row[7].ToString(), Convert.ToInt32(row[8]), Convert.ToInt32(row[0]));
            edt.ShowDialog();
            studentsTableAdapter.Fill(hostelDataSet.Students);
            hostelDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            studentsTableAdapter.Fill(hostelDataSet.Students);
            hostelDataSet.AcceptChanges();
        }
    }
}
