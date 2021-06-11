using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tsbAddProduct_Click(object sender, EventArgs e)
        {
            AddEditProduct ap = new AddEditProduct(" Add ");
            ap.ShowDialog();
            fillProducts();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.storeDBDataSet.Sales);
            this.categoriesTableAdapter.Fill(this.storeDBDataSet.Categories);
            fillProducts();
            countRow("Products");
        }

        private void fillProducts()
        {
            string query = @"SELECT Products.ID As Код, Products.Name_product AS НазваниеТовара, 
Categories.Name AS Категория, Products.Quantity AS Количество,
Products.Price AS Цена
            FROM Categories INNER JOIN Products ON Categories.[ID] =
Products.[ID_category]";
            fillDataGridViewFromQuery(query);
        }

        private void fillDataGridViewFromQuery(string query)
        {
            try
            {
                OleDbConnection sqlconn = new
                OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0;Data
                    Source =|DataDirectory|\StoreDB.mdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dgvProducts.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                countRow("Products");
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                countRow("Categories");
            }
            else
            {
                countRow("Sales");

            }
        }
        private void countRow(string nameTable)
        {
            try
            {
                string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data
                    Source =| DataDirectory |\StoreDB.mdb";
                OleDbConnection con = new OleDbConnection(connectionString);
                OleDbCommand com = con.CreateCommand();
                com.CommandText = "SELECT count(*) FROM " +nameTable;
                con.Open();
                int n = Convert.ToInt32(com.ExecuteScalar());
                tsslCountRows.Text = "Количество записей в таблице: " +Convert.ToString(n);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string query = " SELECT Products.Id AS Код, Products.Name_product AS НазваниеТовара, Categories.Name AS Категория, Products.Quantity AS Количество, Products.Price AS Цена " +
            "FROM Categories INNER JOIN Products ON Categories.[Id] = Products.[Id_category]" +  "WHERE Products.[Name_product] Like \"%" + tstbNameProduct.Text + "%\" ";
            fillDataGridViewFromQuery(query);
        }

        private void tsbReply_Click(object sender, EventArgs e)
        {
            fillProducts();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = " SELECT Products.Id AS Код, Products.Name_product AS НазваниеТовара, Categories.Name AS Категория, Products.Quantity AS Количество, Products.Price AS Цена " +
            "FROM Categories INNER JOIN Products ON Categories.[Id] = Products.[Id_category]" +
            " WHERE Categories.[Name] = \"" + comboBox1.Text + "\"";
            fillDataGridViewFromQuery(query);
        }

        private void tsbDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new
                OleDbConnection(@" Provider = Microsoft.Jet.OLEDB.4.0; Data
                    Source =| DataDirectory |\StoreDB.mdb ");
                sqlconn.Open();
                string query = " DELETE FROM Products WHERE Id = " +
                 dgvProducts.CurrentRow.Cells[0].Value.ToString() + " ; " ;
                OleDbDataAdapter oda = new OleDbDataAdapter(query, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                sqlconn.Close();
                fillProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbEditProduct_Click(object sender, EventArgs e)
        {
            AddEditProduct ap = new
            AddEditProduct(dgvProducts.CurrentRow.Cells[0].Value.ToString(),
            dgvProducts.CurrentRow.Cells[1].Value.ToString(),
            dgvProducts.CurrentRow.Cells[2].Value.ToString(),
            dgvProducts.CurrentRow.Cells[3].Value.ToString(),
            dgvProducts.CurrentRow.Cells[4].Value.ToString(),
            " Edit ");
            ap.ShowDialog();
            fillProducts();
        }

        private void tsbBasket_Click(object sender, EventArgs e)
        {
            Basket b = new Basket(dgvProducts.CurrentRow.Cells[0].Value.ToString(),
            dgvProducts.CurrentRow.Cells[1].Value.ToString(),
            dgvProducts.CurrentRow.Cells[3].Value.ToString(),
            dgvProducts.CurrentRow.Cells[4].Value.ToString());
            b.ShowDialog();
        }
    }
}
