using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Form1 : Form
    {
        UserStoreContext db;
        public Form1()
        {
            InitializeComponent();
            db = new UserStoreContext();
            dataGridView1.DataSource = db.Products.ToList();
            //SeedDataCategories();
        }
        public void SeedDataCategories()
        {
            db.Categories.Add(new Category() { Name = "Product" });
            db.Categories.Add(new Category() { Name = "Appliances" });
            db.Categories.Add(new Category() { Name = "Household chemicals" });
            db.Categories.Add(new Category() { Name = "Cosmetics" });
            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
            if (addProduct.IsAccepted)
            {
                db.Products.Add(addProduct.Product);
                db.SaveChanges();
                RefreshData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product temp = db.Products.FirstOrDefault(p => p.Id == dataGridView1.CurrentRow.Index + 1);
            EditProduct EditProduct = new EditProduct(temp);
            EditProduct.ShowDialog();
            if (EditProduct.IsAccepted)
            {
                db.Products.Remove(db.Products.FirstOrDefault(t => t.Id == dataGridView1.SelectedRows[0].Index));
                db.Products.Add(EditProduct.product);
                db.SaveChanges();
                RefreshData();
            }
        }
        private void RefreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket(db.Products.FirstOrDefault(p => p.Id == dataGridView1.CurrentRow.Index + 1));
            basket.ShowDialog();
        }
    }
}
