using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PR_2
{
    public partial class QueryEdit : Form
    {
        public QueryEdit()
        {
            InitializeComponent();
        }

        private void QueryEdit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; DataSource = D:\\study\\Проектування АІС\\PR_2\\PR_2\\bin\\Debug\\Hostel.mdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter(TestInput.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
